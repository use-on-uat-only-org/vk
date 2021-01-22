using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;
using VkNet.Model;
using VkNet.Model.RequestParams.Leads;
using VkNet.Utils;

namespace VkNet.Categories
{
	/// <inheritdoc />
	public partial class LeadsCategory
	{
		/// <inheritdoc />
		public Task<Checked> CheckUserAsync(CheckUserParams checkUserParams, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => CheckUser(checkUserParams: checkUserParams), token);
		}

		/// <inheritdoc />
		public Task<LeadsComplete> CompleteAsync(string vkSid, string secret, string comment, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => Complete(vkSid, secret, comment), token);
		}

		/// <inheritdoc />
		public Task<Lead> GetStatsAsync(ulong leadId, string secret, string dateStart, string dateEnd, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetStats(leadId, secret, dateStart, dateEnd), token);
		}

		/// <inheritdoc />
		public Task<ReadOnlyCollection<Entry>> GetUsersAsync(GetUsersParams getUsersParams, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetUsers(getUsersParams: getUsersParams), token);
		}

		/// <inheritdoc />
		public Task<MetricHitResponse> MetricHitAsync(string data, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => MetricHit(data: data), token);
		}

		/// <inheritdoc />
		public Task<Start> StartAsync(StartParams startParams, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => Start(startParams: startParams), token);
		}
	}
}