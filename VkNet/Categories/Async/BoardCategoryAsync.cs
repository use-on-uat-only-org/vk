using System.Threading;
using System.Threading.Tasks;
using VkNet.Model;
using VkNet.Model.RequestParams.Board;
using VkNet.Utils;

namespace VkNet.Categories
{
	/// <inheritdoc />
	public partial class BoardCategory
	{
		/// <inheritdoc />
		public Task<VkCollection<Topic>> GetTopicsAsync(BoardGetTopicsParams @params, bool skipAuthorization = false,
														CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(func: () => GetTopics(@params, skipAuthorization), token: token);
		}

		/// <inheritdoc />
		public Task<TopicsFeed> GetCommentsAsync(BoardGetCommentsParams @params, bool skipAuthorization = false,
												CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetComments(@params, skipAuthorization), token);
		}

		/// <inheritdoc />
		public Task<long> AddTopicAsync(BoardAddTopicParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => AddTopic(@params: @params), token);
		}

		/// <inheritdoc />
		public Task<bool> DeleteTopicAsync(BoardTopicParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => DeleteTopic(@params: @params), token);
		}

		/// <inheritdoc />
		public Task<bool> CloseTopicAsync(BoardTopicParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => CloseTopic(@params: @params), token);
		}

		/// <inheritdoc />
		public Task<bool> OpenTopicAsync(BoardTopicParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => OpenTopic(@params: @params), token);
		}

		/// <inheritdoc />
		public Task<bool> FixTopicAsync(BoardTopicParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => FixTopic(@params: @params), token);
		}

		/// <inheritdoc />
		public Task<bool> UnFixTopicAsync(BoardTopicParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => UnFixTopic(@params: @params), token);
		}

		/// <inheritdoc />
		public Task<bool> EditTopicAsync(BoardEditTopicParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => EditTopic(@params: @params), token);
		}

		/// <inheritdoc />
		public Task<long> CreateCommentAsync(BoardCreateCommentParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => CreateComment(@params: @params), token);
		}

		/// <inheritdoc />
		public Task<bool> DeleteCommentAsync(BoardCommentParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => DeleteComment(@params: @params), token);
		}

		/// <inheritdoc />
		public Task<bool> EditCommentAsync(BoardEditCommentParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => EditComment(@params: @params), token);
		}

		/// <inheritdoc />
		public Task<bool> RestoreCommentAsync(BoardCommentParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => RestoreComment(@params: @params), token);
		}
	}
}