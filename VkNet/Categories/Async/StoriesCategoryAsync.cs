using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using VkNet.Model;
using VkNet.Model.Attachments;
using VkNet.Model.RequestParams.Stories;
using VkNet.Model.Results.Stories;
using VkNet.Utils;

namespace VkNet.Categories
{
	/// <inheritdoc/>
	public partial class StoriesCategory
	{
		/// <inheritdoc/>
		public Task<bool> BanOwnerAsync(IEnumerable<long> ownersIds, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => BanOwner(ownersIds), token);
		}

		/// <inheritdoc/>
		public Task<bool> DeleteAsync(long ownerId, ulong storyId, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => Delete(ownerId, storyId), token);
		}

		/// <inheritdoc/>
		public Task<StoryResult<IEnumerable<Story>>> GetAsync(long? ownerId = null, bool? extended = null,
															CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => Get(ownerId, extended), token);
		}

		/// <inheritdoc/>
		public Task<StoryResult<long>> GetBannedAsync(IEnumerable<string> fields = null, bool? extended = null,
													CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetBanned(extended, fields), token);
		}

		/// <inheritdoc/>
		public Task<StoryResult<Story>> GetByIdAsync(IEnumerable<string> stories, bool? extended = null, IEnumerable<string> fields = null,
													CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetById(stories, extended, fields), token);
		}

		/// <inheritdoc/>
		public Task<StoryServerUrl> GetPhotoUploadServerAsync(GetPhotoUploadServerParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetPhotoUploadServer(@params), token);
		}

		/// <inheritdoc/>
		public Task<StoryResult<IEnumerable<Story>>> GetRepliesAsync(long ownerId, ulong storyId, string accessKey = null,
																	bool? extended = null, IEnumerable<string> fields = null,
																	CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetReplies(ownerId, storyId, accessKey, extended, fields), token);
		}

		/// <inheritdoc/>
		public Task<StoryStatsResult> GetStatsAsync(long ownerId, ulong storyId, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetStats(ownerId, storyId), token);
		}

		/// <inheritdoc/>
		public Task<StoryServerUrl> GetVideoUploadServerAsync(GetVideoUploadServerParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetVideoUploadServer(@params), token);
		}

		/// <inheritdoc/>
		public Task<VkCollection<long>> GetViewersAsync(long ownerId, ulong storyId, ulong? count = null, ulong? offset = null,
														CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetViewers(ownerId, storyId, count, offset), token);
		}

		/// <inheritdoc />
		public Task<VkCollection<User>> GetViewersExtendedAsync(long ownerId, ulong storyId, ulong? count = null, ulong? offset = null,
																CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetViewersExtended(ownerId, storyId, count, offset), token);
		}

		/// <inheritdoc/>
		public Task<bool> HideAllRepliesAsync(long ownerId, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => HideAllReplies(ownerId), token);
		}

		/// <inheritdoc/>
		public Task<bool> HideReplyAsync(long ownerId, ulong storyId, string accessKey = null, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => HideReply(ownerId, storyId, accessKey), token);
		}

		/// <inheritdoc/>
		public Task<bool> UnbanOwnerAsync(IEnumerable<long> ownersIds, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => UnbanOwner(ownersIds), token);
		}
	}
}