using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using VkNet.Abstractions.Utils;

namespace VkNet.Utils
{
	/// <inheritdoc />
	[UsedImplicitly]
	public class RestClient : IRestClient
	{
		private readonly ILogger<RestClient> _logger;

		/// <inheritdoc cref="RestClient"/>
		public RestClient(HttpClient httpClient, ILogger<RestClient> logger)
		{
			HttpClient = httpClient;
			_logger = logger;
		}

		/// <summary>
		/// Http client
		/// </summary>
		public HttpClient HttpClient { get; }

		/// <inheritdoc />
		public Task<HttpResponse<string>> GetAsync(Uri uri, IEnumerable<KeyValuePair<string, string>> parameters,
													CancellationToken token = default)
		{
			var url = Url.Combine(uri.ToString(), Url.QueryFrom(parameters.ToArray()));

			_logger?.LogDebug($"GET request: {url}");

			return CallAsync(() => HttpClient.GetAsync(new Uri(url), token));
		}

		/// <inheritdoc />
		public Task<HttpResponse<string>> PostAsync(Uri uri, IEnumerable<KeyValuePair<string, string>> parameters,
													CancellationToken token = default)
		{
			if (_logger != null)
			{
				var json = JsonConvert.SerializeObject(parameters);
				_logger.LogDebug($"POST request: {uri}{Environment.NewLine}{Utilities.PrettyPrintJson(json)}");
			}

			var content = new FormUrlEncodedContent(parameters);

			return CallAsync(() => HttpClient.PostAsync(uri, content, token));
		}

		/// <inheritdoc />
		public void Dispose()
		{
			HttpClient?.Dispose();
		}

		private async Task<HttpResponse<string>> CallAsync(Func<Task<HttpResponseMessage>> method)
		{
			var response = await method().ConfigureAwait(false);

			var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

			_logger?.LogDebug($"Response:{Environment.NewLine}{Utilities.PrettyPrintJson(content)}");
			var requestUri = response.RequestMessage.RequestUri;
			var responseUri = response.Headers.Location;

			return response.IsSuccessStatusCode
				? HttpResponse<string>.Success(response.StatusCode, content, requestUri, responseUri)
				: HttpResponse<string>.Fail(response.StatusCode, content, requestUri, responseUri);
		}
	}
}