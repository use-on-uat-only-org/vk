using System;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;
using VkNet.Enums.SafetyEnums;
using VkNet.Model;
using VkNet.Utils;

namespace VkNet.Categories
{
	/// <inheritdoc />
	public partial class StreamingCategory
	{
		/// <param name="token"></param>
		/// <inheritdoc />
		public Task<StreamingServerUrl> GetServerUrlAsync(CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(GetServerUrl, token);
		}

		/// <param name="token"></param>
		/// <inheritdoc />
		public Task<StreamingSettings> GetSettingsAsync(CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(GetSettings, token);
		}

		/// <inheritdoc />
		public Task<ReadOnlyCollection<StreamingStats>> GetStatsAsync(string type, string interval, DateTime? startTime = null,
																	DateTime? endTime = null, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetStats(type, interval, startTime, endTime), token);
		}

		/// <inheritdoc />
		public Task<bool> SetSettingsAsync(MonthlyLimit monthlyTier, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => SetSettings(monthlyTier: monthlyTier), token);
		}

		/// <inheritdoc />
		public Task<string> GetStemAsync(string word, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetStem(word: word), token);
		}
	}
}