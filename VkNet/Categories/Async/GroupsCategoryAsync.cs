using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;
using VkNet.Enums.Filters;
using VkNet.Enums.SafetyEnums;
using VkNet.Model;
using VkNet.Model.Group;
using VkNet.Model.RequestParams.Groups;
using VkNet.Model.Results.Groups;
using VkNet.Utils;

namespace VkNet.Categories
{
	/// <inheritdoc />
	public partial class GroupsCategory
	{
		/// <inheritdoc />
		public Task<bool> JoinAsync(long? groupId, bool? notSure = null, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => Join(groupId, notSure), token);
		}

		/// <inheritdoc />
		public Task<bool> LeaveAsync(long groupId, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => Leave(groupId), token);
		}

		/// <inheritdoc />
		public Task<VkCollection<Group>> GetAsync(GroupsGetParams @params, bool skipAuthorization = false,
												CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => Get(@params, skipAuthorization), token);
		}

		/// <inheritdoc />
		public Task<ReadOnlyCollection<Group>> GetByIdAsync(IEnumerable<string> groupIds, string groupId, GroupsFields fields,
															bool skipAuthorization = false, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetById(groupIds, groupId, fields, skipAuthorization), token);
		}

		/// <inheritdoc />
		public Task<VkCollection<User>> GetMembersAsync(GroupsGetMembersParams @params, bool skipAuthorization = false,
														CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetMembers(@params, skipAuthorization), token);
		}

		/// <inheritdoc />
		public Task<ReadOnlyCollection<GroupMember>> IsMemberAsync(string groupId, long? userId, IEnumerable<long> userIds, bool? extended,
																	bool skipAuthorization = false,
																	CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => IsMember(groupId, userId, userIds, extended, skipAuthorization), token);
		}

		/// <inheritdoc />
		public Task<VkCollection<Group>> SearchAsync(GroupsSearchParams @params, bool skipAuthorization = false,
													CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => Search(@params, skipAuthorization), token);
		}

		/// <inheritdoc />
		public Task<VkCollection<Group>> GetInvitesAsync(long? count, long? offset, bool? extended = null,
														CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetInvites(count, offset, extended), token);
		}

		/// <inheritdoc />
		public Task<bool> BanUserAsync(GroupsBanUserParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => BanUser(@params), token);
		}

		/// <inheritdoc />
		public Task<VkCollection<GetBannedResult>> GetBannedAsync(long groupId, long? offset = null, long? count = null,
																GroupsFields fields = null, long? ownerId = null,
																CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetBanned(groupId, offset, count, fields, ownerId), token);
		}

		/// <inheritdoc />
		public Task<bool> UnbanAsync(long groupId, long userId, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => Unban(groupId, userId), token);
		}

		/// <inheritdoc />
		public Task<bool> EditManagerAsync(GroupsEditManagerParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => EditManager(@params), token);
		}

		/// <inheritdoc />
		public Task<GroupsEditParams> GetSettingsAsync(ulong groupId, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetSettings(groupId: groupId), token);
		}

		/// <inheritdoc />
		public Task<bool> EditAsync(GroupsEditParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => Edit(@params), token);
		}

		/// <inheritdoc />
		[Obsolete(ObsoleteText.Obsolete)]
		public Task<bool> EditPlaceAsync(long groupId, Place place = null, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => EditPlace(groupId, place), token);
		}

		/// <inheritdoc />
		public Task<VkCollection<User>> GetInvitedUsersAsync(long groupId, long? offset = null, long? count = null,
															UsersFields fields = null, NameCase nameCase = null,
															CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetInvitedUsers(groupId, offset, count, fields, nameCase), token);
		}

		/// <inheritdoc />
		public Task<bool> InviteAsync(long groupId, long userId, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => Invite(groupId, userId), token);
		}

		/// <inheritdoc />
		public Task<ExternalLink> AddLinkAsync(long groupId, Uri link, string text, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => AddLink(groupId, link, text), token);
		}

		/// <inheritdoc />
		public Task<bool> DeleteLinkAsync(long groupId, ulong linkId, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => DeleteLink(groupId, linkId), token);
		}

		/// <inheritdoc />
		public Task<bool> EditLinkAsync(long groupId, ulong linkId, string text, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => EditLink(groupId, linkId, text), token);
		}

		/// <inheritdoc />
		public Task<bool> ReorderLinkAsync(long groupId, long linkId, long? after, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => ReorderLink(groupId, linkId, after), token);
		}

		/// <inheritdoc />
		public Task<bool> RemoveUserAsync(long groupId, long userId, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => RemoveUser(groupId, userId), token);
		}

		/// <inheritdoc />
		public Task<bool> ApproveRequestAsync(long groupId, long userId, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => ApproveRequest(groupId, userId), token);
		}

		/// <inheritdoc />
		public Task<Group> CreateAsync(string title, string description = null, GroupType type = null, GroupSubType? subtype = null,
										uint? publicCategory = null,
										CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => Create(title, description, type, subtype, publicCategory), token);
		}

		/// <inheritdoc />
		public Task<VkCollection<User>> GetRequestsAsync(long groupId, long? offset = null, long? count = null, UsersFields fields = null,
														CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetRequests(groupId, offset, count, fields), token);
		}

		/// <inheritdoc />
		public Task<VkCollection<Group>> GetCatalogAsync(ulong? categoryId = null, ulong? subcategoryId = null,
														CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetCatalog(categoryId, subcategoryId), token);
		}

		/// <inheritdoc />
		public Task<GroupsCatalogInfo> GetCatalogInfoAsync(bool? extended = null, bool? subcategories = null,
															CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetCatalogInfo(extended, subcategories), token);
		}

		/// <inheritdoc />
		public Task<long> AddCallbackServerAsync(ulong groupId, string url, string title, string secretKey = null,
												CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => AddCallbackServer(groupId, url, title, secretKey), token);
		}

		/// <inheritdoc />
		public Task<bool> DeleteCallbackServerAsync(ulong groupId, ulong serverId, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => DeleteCallbackServer(groupId, serverId), token);
		}

		/// <inheritdoc />
		public Task<bool> EditCallbackServerAsync(ulong groupId, ulong serverId, string url, string title, string secretKey,
												CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => EditCallbackServer(groupId, serverId, url, title, secretKey), token);
		}

		/// <inheritdoc />
		public Task<string> GetCallbackConfirmationCodeAsync(ulong groupId, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetCallbackConfirmationCode(groupId: groupId), token);
		}

		/// <inheritdoc />
		public Task<VkCollection<CallbackServerItem>> GetCallbackServersAsync(ulong groupId, IEnumerable<ulong> serverIds = null,
																			CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetCallbackServers(groupId, serverIds), token);
		}

		/// <inheritdoc />
		public Task<CallbackSettings> GetCallbackSettingsAsync(ulong groupId, ulong serverId, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetCallbackSettings(groupId, serverId), token);
		}

		/// <inheritdoc />
		public Task<bool> SetCallbackSettingsAsync(CallbackServerParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => SetCallbackSettings(@params), token);
		}

		/// <inheritdoc />
		public Task<LongPollServerResponse> GetLongPollServerAsync(ulong groupId, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetLongPollServer(groupId), token);
		}

		/// <inheritdoc />
		public Task<bool> DisableOnlineAsync(ulong groupId, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => DisableOnline(groupId), token);
		}

		/// <inheritdoc />
		public Task<bool> EnableOnlineAsync(ulong groupId, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => EnableOnline(groupId), token);
		}

		/// <inheritdoc />
		public Task<BotsLongPollHistoryResponse> GetBotsLongPollHistoryAsync(BotsLongPollHistoryParams @params,
																			CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetBotsLongPollHistory(@params), token);
		}

		/// <inheritdoc />
		public Task<AddressResult> AddAddressAsync(AddAddressParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => AddAddress(@params), token);
		}

		/// <inheritdoc />
		public Task<AddressResult> EditAddressAsync(EditAddressParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => EditAddress(@params), token);
		}

		/// <inheritdoc />
		public Task<bool> DeleteAddressAsync(ulong groupId, ulong addressId, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => DeleteAddress(groupId, addressId), token);
		}

		/// <inheritdoc />
		public Task<VkCollection<AddressResult>> GetAddressesAsync(GetAddressesParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetAddresses(@params), token);
		}

		/// <inheritdoc />
		public Task<OnlineStatus> GetOnlineStatusAsync(ulong groupId, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetOnlineStatus(groupId), token);
		}

		/// <param name="token"></param>
		/// <inheritdoc />
		public Task<TokenPermissionsResult> GetTokenPermissionsAsync(CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(GetTokenPermissions, token);
		}

		/// <inheritdoc />
		public Task<bool> SetLongPollSettingsAsync(SetLongPollSettingsParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => SetLongPollSettings(@params), token);
		}

		/// <inheritdoc />
		public Task<GetLongPollSettingsResult> GetLongPollSettingsAsync(ulong groupId, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetLongPollSettings(groupId), token);
		}
	}
}