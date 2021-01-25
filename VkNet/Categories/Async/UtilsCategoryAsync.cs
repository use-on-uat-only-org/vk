using System;
using System.Threading;
using System.Threading.Tasks;
using VkNet.Enums.SafetyEnums;
using VkNet.Model;
using VkNet.Model.RequestParams.Utils;
using VkNet.Model.Results.Utils;
using VkNet.Utils;

namespace VkNet.Categories
{
	/// <inheritdoc />
	public partial class UtilsCategory
	{
		/// <inheritdoc />
		public Task<LinkAccessType> CheckLinkAsync(string url, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => CheckLink(url: url), token);
		}

		/// <inheritdoc />
		public Task<LinkAccessType> CheckLinkAsync(Uri url, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => CheckLink(url: url), token);
		}

		/// <inheritdoc />
		public Task<VkObject> ResolveScreenNameAsync(string screenName, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => ResolveScreenName(screenName: screenName), token);
		}

		/// <param name="token"></param>
		/// <inheritdoc />
		public Task<DateTime> GetServerTimeAsync(CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(GetServerTime, token);
		}

		/// <inheritdoc />
		public Task<ShortLink> GetShortLinkAsync(Uri url, bool isPrivate, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetShortLink(url, isPrivate), token);
		}

		/// <inheritdoc />
		public Task<bool> DeleteFromLastShortenedAsync(string key, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => DeleteFromLastShortened(key: key), token);
		}

		/// <inheritdoc />
		public Task<VkCollection<ShortLink>> GetLastShortenedLinksAsync(ulong count = 10, ulong offset = 0,
																		CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetLastShortenedLinks(count, offset), token);
		}

		/// <inheritdoc />
		public Task<LinkStatsResult> GetLinkStatsAsync(LinkStatsParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetLinkStats(@params: @params), token);
		}
	}
}