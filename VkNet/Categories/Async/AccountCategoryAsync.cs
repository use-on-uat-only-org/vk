using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using VkNet.Enums.Filters;
using VkNet.Model;
using VkNet.Model.Account;
using VkNet.Model.RequestParams.Account;
using VkNet.Model.Results.Account;
using VkNet.Utils;

namespace VkNet.Categories
{
	/// <inheritdoc />
	public partial class AccountCategory
	{
		/// <inheritdoc />
		public Task<Counters> GetCountersAsync(CountersFilter filter, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetCounters(filter));
		}

		/// <inheritdoc />
		public Task<bool> SetNameInMenuAsync(string name, long userId, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => SetNameInMenu(name, userId));
		}

		/// <inheritdoc />
		public Task<bool> SetOnlineAsync(bool? voip = null, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => SetOnline(voip));
		}

		/// <param name="token"></param>
		/// <inheritdoc />
		public Task<bool> SetOfflineAsync(CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => SetOffline());
		}

		/// <inheritdoc />
		public Task<bool> RegisterDeviceAsync(AccountRegisterDeviceParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => RegisterDevice(@params));
		}

		/// <inheritdoc />
		public Task<bool> UnregisterDeviceAsync(string deviceId, bool? sandbox = null, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => UnregisterDevice(deviceId, sandbox));
		}

		/// <inheritdoc />
		public Task<bool> SetSilenceModeAsync(string deviceId, int? time = null, int? peerId = null, bool? sound = null,
											CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() =>
				SetSilenceMode(deviceId, time, peerId, sound));
		}

		/// <inheritdoc />
		public Task<AccountPushSettings> GetPushSettingsAsync(string deviceId, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetPushSettings(deviceId));
		}

		/// <inheritdoc />
		public Task<bool> SetPushSettingsAsync(string deviceId, PushSettings settings, string key, List<string> value,
												CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() =>
				SetPushSettings(deviceId, settings, key, value));
		}

		/// <inheritdoc />
		public Task<long> GetAppPermissionsAsync(long userId, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetAppPermissions(userId));
		}

		/// <inheritdoc />
		public Task<InformationAboutOffers> GetActiveOffersAsync(ulong? offset = null, ulong? count = null,
																CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetActiveOffers(offset, count));
		}

		/// <inheritdoc />
		[Obsolete(ObsoleteText.BanUserAsync)]
		public Task<bool> BanUserAsync(long ownerId, CancellationToken token = default)
		{
			return BanAsync(ownerId);
		}

		/// <inheritdoc />
		public Task<bool> BanAsync(long ownerId, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => Ban(ownerId));
		}

		/// <inheritdoc />
		[Obsolete(ObsoleteText.UnbanUserAsync)]
		public Task<bool> UnbanUserAsync(long ownerId, CancellationToken token = default)
		{
			return UnbanAsync(ownerId);
		}

		/// <inheritdoc />
		public Task<bool> UnbanAsync(long ownerId, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => Unban(ownerId));
		}

		/// <inheritdoc />
		public Task<AccountGetBannedResult> GetBannedAsync(int? offset = null, int? count = null, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetBanned(offset, count));
		}

		/// <inheritdoc />
		public Task<AccountInfo> GetInfoAsync(AccountFields fields = null, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetInfo(fields));
		}

		/// <inheritdoc />
		public Task<bool> SetInfoAsync(string name, string value, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => SetInfo(name, value));
		}

		/// <inheritdoc />
		public Task<AccountChangePasswordResult> ChangePasswordAsync(string oldPassword, string newPassword, string restoreSid = null,
																	string changePasswordHash = null, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => ChangePassword(oldPassword,
				newPassword,
				restoreSid,
				changePasswordHash));
		}

		/// <param name="token"></param>
		/// <inheritdoc />
		public Task<AccountSaveProfileInfoParams> GetProfileInfoAsync(CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetProfileInfo());
		}

		/// <inheritdoc />
		public Task<bool> SaveProfileInfoAsync(int cancelRequestId, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => SaveProfileInfo(cancelRequestId));
		}

		/// <inheritdoc />
		public Task<bool> SaveProfileInfoAsync(AccountSaveProfileInfoParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() =>
				SaveProfileInfo(out var _, @params));
		}

		/// <inheritdoc />
		public Task<PrivacySettings> GetPrivacySettingsAsync(CancellationToken token)
		{
			return TypeHelper.TryInvokeMethodAsync(GetPrivacySettings);
		}

		/// <inheritdoc />
		public Task<PrivacySettingsValue> SetPrivacyAsync(string key, string value, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => SetPrivacy(key, value));
		}
	}
}