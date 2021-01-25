using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using VkNet.Enums;
using VkNet.Enums.Filters;
using VkNet.Model;
using VkNet.Model.Attachments;
using VkNet.Model.RequestParams.Wall;
using VkNet.Model.Results.Wall;
using VkNet.Utils;

namespace VkNet.Categories
{
	/// <inheritdoc />
	public partial class WallCategory
	{
		/// <inheritdoc />
		public Task<WallGetObject> GetAsync(WallGetParams @params, bool skipAuthorization = false, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => Get(@params, skipAuthorization), token);
		}

		/// <inheritdoc />
		public Task<WallGetCommentsResult> GetCommentsAsync(WallGetCommentsParams @params, bool skipAuthorization = false,
															CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetComments(@params, skipAuthorization), token);
		}

		/// <inheritdoc />
		public Task<WallGetObject> GetByIdAsync(IEnumerable<string> posts, bool? extended = null, long? copyHistoryDepth = null,
												ProfileFields fields = null, bool skipAuthorization = false,
												CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetById(posts, extended, copyHistoryDepth, fields, skipAuthorization), token);
		}

		/// <inheritdoc />
		public Task<long> PostAsync(WallPostParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => Post(@params: @params), token);
		}

		/// <inheritdoc />
		public Task<RepostResult> RepostAsync(string @object, string message, long? groupId, bool markAsAds,
											CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => Repost(@object, message, groupId, markAsAds), token);
		}

		/// <inheritdoc />
		public Task<long> EditAsync(WallEditParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => Edit(@params: @params), token);
		}

		/// <inheritdoc />
		public Task<bool> DeleteAsync(long? ownerId = null, long? postId = null, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => Delete(ownerId, postId), token);
		}

		/// <inheritdoc />
		public Task<bool> RestoreAsync(long? ownerId = null, long? postId = null, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => Restore(ownerId, postId), token);
		}

		/// <inheritdoc />
		public Task<long> CreateCommentAsync(WallCreateCommentParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => CreateComment(@params: @params), token);
		}

		/// <inheritdoc />
		public Task<bool> DeleteCommentAsync(long? ownerId, long commentId, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => DeleteComment(ownerId, commentId), token);
		}

		/// <inheritdoc />
		public Task<bool> RestoreCommentAsync(long commentId, long? ownerId, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => RestoreComment(commentId, ownerId), token);
		}

		/// <inheritdoc />
		public Task<WallGetObject> SearchAsync(WallSearchParams @params, bool skipAuthorization = false, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => Search(@params, skipAuthorization), token);
		}

		/// <inheritdoc />
		public Task<WallGetObject> GetRepostsAsync(long? ownerId, long? postId, long? offset, long? count, bool skipAuthorization = false,
													CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetReposts(ownerId, postId, offset, count, skipAuthorization), token);
		}

		/// <inheritdoc />
		public Task<bool> PinAsync(long postId, long? ownerId = null, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => Pin(postId, ownerId), token);
		}

		/// <inheritdoc />
		public Task<bool> UnpinAsync(long postId, long? ownerId = null, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => Unpin(postId, ownerId), token);
		}

		/// <inheritdoc />
		public Task<bool> EditCommentAsync(long commentId, string message, long? ownerId = null,
											IEnumerable<MediaAttachment> attachments = null, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => EditComment(commentId, message, ownerId, attachments), token);
		}

		/// <inheritdoc />
		public Task<bool> ReportPostAsync(long ownerId, long postId, ReportReason? reason = null, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => ReportPost(ownerId, postId, reason), token);
		}

		/// <inheritdoc />
		public Task<bool> ReportCommentAsync(long ownerId, long commentId, ReportReason? reason, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => ReportComment(ownerId, commentId, reason), token);
		}

		/// <inheritdoc />
		public Task<bool> EditAdsStealthAsync(EditAdsStealthParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => EditAdsStealth(@params: @params), token);
		}

		/// <inheritdoc />
		public Task<long> PostAdsStealthAsync(PostAdsStealthParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => PostAdsStealth(@params: @params), token);
		}

		/// <inheritdoc />
		public Task<bool> OpenCommentsAsync(long ownerId, long postId, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => OpenComments(ownerId, postId), token);
		}

		/// <inheritdoc />
		public Task<bool> CloseCommentsAsync(long ownerId, long postId, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => CloseComments(ownerId, postId), token);
		}

		/// <inheritdoc />
		public Task<bool> CheckCopyrightLinkAsync(string link, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => CheckCopyrightLink(link), token);
		}

		/// <inheritdoc />
		public Task<WallGetCommentResult> GetCommentAsync(int ownerId, int commentId, bool? extended = null, string fields = null,
														bool skipAuthorization = false, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetComment(ownerId, commentId, extended, fields, skipAuthorization),
				token);
		}
	}
}