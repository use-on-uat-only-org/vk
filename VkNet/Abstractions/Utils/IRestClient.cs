using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using VkNet.Utils;

namespace VkNet.Abstractions.Utils
{
	/// <summary>
	/// Rest Client
	/// </summary>
	public interface IRestClient : IDisposable
	{
		/// <summary>
		/// Get request
		/// </summary>
		/// <param name="uri"> Uri </param>
		/// <param name="parameters"> </param>
		/// <param name="token"></param>
		/// <returns> String result </returns>
		Task<HttpResponse<string>> GetAsync(Uri uri, IEnumerable<KeyValuePair<string, string>> parameters, CancellationToken token = default);

		/// <summary>
		/// POST запрос
		/// </summary>
		/// <param name="uri"> Uri </param>
		/// <param name="parameters"> Параметры </param>
		/// <param name="token"></param>
		/// <returns> Строковый результат </returns>
		Task<HttpResponse<string>> PostAsync(Uri uri, IEnumerable<KeyValuePair<string, string>> parameters, CancellationToken token = default);
	}
}