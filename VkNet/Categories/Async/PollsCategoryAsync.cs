using System.Threading;
using System.Threading.Tasks;
using VkNet.Model;
using VkNet.Model.Attachments;
using VkNet.Model.RequestParams.Polls;
using VkNet.Utils;

namespace VkNet.Categories
{
	/// <inheritdoc />
	public partial class PollsCategory
	{
		/// <inheritdoc />
		public Task<Poll> GetByIdAsync(PollsGetByIdParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetById(@params: @params), token);
		}

		/// <inheritdoc />
		public Task<bool> EditAsync(PollsEditParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => Edit(@params: @params), token);
		}

		/// <inheritdoc />
		public Task<bool> AddVoteAsync(PollsAddVoteParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => AddVote(@params: @params), token);
		}

		/// <inheritdoc />
		public Task<bool> DeleteVoteAsync(PollsDeleteVoteParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => DeleteVote(@params: @params), token);
		}

		/// <inheritdoc />
		public Task<VkCollection<PollAnswerVoters>> GetVotersAsync(PollsGetVotersParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetVoters(@params: @params), token);
		}

		/// <inheritdoc />
		public Task<Poll> CreateAsync(PollsCreateParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => Create(@params: @params), token);
		}
	}
}