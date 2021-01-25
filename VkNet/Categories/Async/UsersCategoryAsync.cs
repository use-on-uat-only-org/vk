using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;
using VkNet.Enums.Filters;
using VkNet.Enums.SafetyEnums;
using VkNet.Model;
using VkNet.Model.Group;
using VkNet.Model.RequestParams.Users;
using VkNet.Utils;

namespace VkNet.Categories
{
	/// <inheritdoc />
	public partial class UsersCategory
	{
		/// <inheritdoc />
		public Task<VkCollection<User>> SearchAsync(UserSearchParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => Search(@params: @params), token);
		}

		/// <inheritdoc />
		public Task<bool> IsAppUserAsync(long? userId, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => IsAppUser(userId: userId), token);
		}

		/// <inheritdoc />
		public Task<ReadOnlyCollection<User>> GetAsync(IEnumerable<long> userIds, ProfileFields fields = null, NameCase nameCase = null,
														CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => Get(userIds, fields, nameCase), token);
		}

		/// <inheritdoc />
		public Task<ReadOnlyCollection<User>> GetAsync(IEnumerable<string> screenNames, ProfileFields fields = null,
														NameCase nameCase = null, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => Get(screenNames, fields, nameCase), token);
		}

		/// <inheritdoc />
		public Task<VkCollection<Group>> GetSubscriptionsAsync(long? userId = null, int? count = null, int? offset = null,
																GroupsFields fields = null, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetSubscriptions(userId, count, offset, fields), token);
		}

		/// <inheritdoc />
		public Task<VkCollection<User>> GetFollowersAsync(long? userId = null, int? count = null, int? offset = null,
														ProfileFields fields = null, NameCase nameCase = null,
														CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetFollowers(userId, count, offset, fields, nameCase), token);
		}

		/// <inheritdoc />
		public Task<bool> ReportAsync(long userId, ReportType type, string comment = "", CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => Report(userId, type, comment), token);
		}

		/// <inheritdoc />
		public Task<VkCollection<User>> GetNearbyAsync(UsersGetNearbyParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetNearby(@params: @params), token);
		}
	}
}