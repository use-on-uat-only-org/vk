using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;
using VkNet.Model;
using VkNet.Model.Results.Secure;
using VkNet.Utils;

namespace VkNet.Categories
{
	/// <inheritdoc />
	public partial class SecureCategory
	{
		/// <inheritdoc />
		public Task<bool> AddAppEventAsync(ulong userId, ulong activityId, ulong? value = null, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => AddAppEvent(userId, activityId, value), token);
		}

		/// <inheritdoc />
		public Task<CheckTokenResult> CheckTokenAsync(string token, string ip = null, CancellationToken cancellationToken = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => CheckToken(token, ip), cancellationToken);
		}

		/// <param name="token"></param>
		/// <inheritdoc />
		public Task<ulong> GetAppBalanceAsync(CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(GetAppBalance, token);
		}

		/// <inheritdoc />
		public Task<ReadOnlyCollection<SmsHistoryItem>> GetSmsHistoryAsync(ulong? userId = null, DateTime? dateFrom = null,
																			DateTime? dateTo = null,
																			ulong? limit = null, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetSmsHistory(userId, dateFrom, dateTo, limit), token);
		}

		/// <param name="token"></param>
		/// <inheritdoc />
		public Task<ReadOnlyCollection<Transaction>> GetTransactionsHistoryAsync(CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(GetTransactionsHistory, token);
		}

		/// <inheritdoc />
		public Task<ReadOnlyCollection<SecureLevel>> GetUserLevelAsync(IEnumerable<long> userIds, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetUserLevel(userIds), token);
		}

		/// <inheritdoc />
		public Task<ReadOnlyCollection<EventSticker>> GiveEventStickerAsync(IEnumerable<ulong> userIds, ulong achievementId,
																			CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GiveEventSticker(userIds, achievementId), token);
		}

		/// <inheritdoc />
		public Task<ReadOnlyCollection<ulong>> SendNotificationAsync(string message, IEnumerable<ulong> userIds = null,
																	CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => SendNotification(message, userIds), token);
		}

		/// <inheritdoc />
		public Task<bool> SendSmsNotificationAsync(ulong userId, string message, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => SendSmsNotification(userId, message), token);
		}

		/// <inheritdoc />
		public Task<bool> SetCounterAsync(IEnumerable<string> counters, ulong? userId = null, long? counter = null, bool? increment = null,
										CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => SetCounter(counters, userId, counter, increment), token);
		}
	}
}