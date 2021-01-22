using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using VkNet.Enums.Filters;
using VkNet.Enums.SafetyEnums;
using VkNet.Model;
using VkNet.Model.RequestParams.NewsFeed;
using VkNet.Model.Results.NewsFeed;
using VkNet.Utils;

namespace VkNet.Categories
{
	/// <inheritdoc />
	public partial class NewsFeedCategory
	{
		/// <inheritdoc />
		public Task<NewsFeed> GetAsync(NewsFeedGetParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => Get(@params: @params), token);
		}

		/// <inheritdoc />
		public Task<NewsFeed> GetRecommendedAsync(NewsFeedGetRecommendedParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetRecommended(@params: @params), token);
		}

		/// <inheritdoc />
		public Task<NewsFeed> GetCommentsAsync(NewsFeedGetCommentsParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetComments(@params: @params), token);
		}

		/// <inheritdoc />
		public Task<VkCollection<Mention>> GetMentionsAsync(long? ownerId = null, DateTime? startTime = null, DateTime? endTime = null,
															long? offset = null, long? count = null, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetMentions(ownerId, startTime, endTime, offset), token);
		}

		/// <param name="token"></param>
		/// <inheritdoc />
		public Task<NewsBannedList> GetBannedAsync(CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(GetBanned, token);
		}

		/// <inheritdoc />
		public Task<NewsBannedExList> GetBannedExAsync(UsersFields fields = null, NameCase nameCase = null,
														CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetBannedEx(fields, nameCase), token);
		}

		/// <inheritdoc />
		public Task<bool> AddBanAsync(IEnumerable<long> userIds, IEnumerable<long> groupIds, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => AddBan(userIds, groupIds), token);
		}

		/// <inheritdoc />
		public Task<bool> DeleteBanAsync(IEnumerable<long> userIds, IEnumerable<long> groupIds, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => DeleteBan(userIds, groupIds), token);
		}

		/// <inheritdoc />
		public Task<bool> IgnoreItemAsync(NewsObjectTypes type, long ownerId, long itemId, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => IgnoreItem(type, ownerId, itemId), token);
		}

		/// <inheritdoc />
		public Task<bool> UnignoreItemAsync(NewsObjectTypes type, long ownerId, long itemId, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => UnignoreItem(type, ownerId, itemId), token);
		}

		/// <inheritdoc />
		public Task<NewsSearchResult> SearchAsync(NewsFeedSearchParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => Search(@params: @params), token);
		}

		/// <inheritdoc />
		public Task<VkCollection<NewsUserListItem>> GetListsAsync(IEnumerable<long> listIds, bool? extended = null,
																CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetLists(listIds, extended), token);
		}

		/// <inheritdoc />
		public Task<long> SaveListAsync(string title, IEnumerable<long> sourceIds, long? listId = null, bool? noReposts = null,
										CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => SaveList(title, sourceIds, listId, noReposts), token);
		}

		/// <inheritdoc />
		public Task<bool> DeleteListAsync(long listId, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => DeleteList(listId: listId), token);
		}

		/// <inheritdoc />
		public Task<bool> UnsubscribeAsync(CommentObjectType type, long itemId, long? ownerId = null, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => Unsubscribe(type, itemId, ownerId), token);
		}

		/// <inheritdoc />
		public Task<NewsSuggestions> GetSuggestedSourcesAsync(long? offset = null, long? count = null, bool? shuffle = null,
															UsersFields fields = null, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetSuggestedSources(offset, count, shuffle, fields), token);
		}
	}
}