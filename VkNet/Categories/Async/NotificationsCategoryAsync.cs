using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using VkNet.Model.Results.Notifications;
using VkNet.Utils;

namespace VkNet.Categories
{
	/// <inheritdoc />
	public partial class NotificationsCategory
	{
		/// <inheritdoc />
		public Task<IEnumerable<NotificationGetResult>> GetAsync(ulong? count = null, string startFrom = null,
																IEnumerable<string> filters = null, long? startTime = null,
																long? endTime = null, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => Get(count, startFrom, filters, startTime, endTime), token);
		}

		/// <param name="token"></param>
		/// <inheritdoc />
		public Task<bool> MarkAsViewedAsync(CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(MarkAsViewed, token);
		}
	}
}