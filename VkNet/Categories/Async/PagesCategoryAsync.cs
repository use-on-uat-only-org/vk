using System;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;
using VkNet.Enums;
using VkNet.Model;
using VkNet.Model.Attachments;
using VkNet.Model.RequestParams.Pages;
using VkNet.Utils;

namespace VkNet.Categories
{
	/// <inheritdoc />
	public partial class PagesCategory
	{
		/// <inheritdoc />
		public Task<Page> GetAsync(PagesGetParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => Get(@params: @params), token);
		}

		/// <inheritdoc />
		public Task<long> SaveAsync(string text, long groupId, long userId, string title, long? pageId,
									CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => Save(text, groupId, userId, title, pageId), token);
		}

		/// <inheritdoc />
		public Task<long> SaveAccessAsync(long pageId, long groupId, long? userId = null, AccessPages view = AccessPages.All,
										AccessPages edit = AccessPages.Leaders, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => SaveAccess(pageId, groupId, userId, view, edit), token);
		}

		/// <inheritdoc />
		public Task<ReadOnlyCollection<PageVersion>> GetHistoryAsync(long pageId, long groupId, long? userId = null,
																	CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetHistory(pageId, groupId, userId), token);
		}

		/// <inheritdoc />
		public Task<ReadOnlyCollection<Page>> GetTitlesAsync(long groupId, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetTitles(groupId: groupId), token);
		}

		/// <inheritdoc />
		public Task<Page> GetVersionAsync(long versionId, long groupId, bool needHtml = false, long? userId = null,
										CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetVersion(versionId, groupId, needHtml, userId), token);
		}

		/// <inheritdoc />
		public Task<string> ParseWikiAsync(string text, ulong groupId, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => ParseWiki(text, groupId), token);
		}

		/// <inheritdoc />
		public Task<bool> ClearCacheAsync(Uri url, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => ClearCache(url: url), token);
		}
	}
}