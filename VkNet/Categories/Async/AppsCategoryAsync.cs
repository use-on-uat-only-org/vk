using System.Threading;
using System.Threading.Tasks;
using VkNet.Enums.Filters;
using VkNet.Enums.SafetyEnums;
using VkNet.Model;
using VkNet.Model.Apps;
using VkNet.Model.RequestParams.App;
using VkNet.Model.Results.Apps;
using VkNet.Utils;

namespace VkNet.Categories
{
	/// <inheritdoc />
	public partial class AppsCategory
	{
		/// <inheritdoc />
		public Task<VkCollection<App>> GetCatalogAsync(AppGetCatalogParams @params, bool skipAuthorization = false,
														CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetCatalog(@params, skipAuthorization), token);
		}

		/// <inheritdoc />
		public Task<AppGetObject> GetAsync(AppGetParams @params, bool skipAuthorization = false, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => Get(@params, skipAuthorization), token);
		}

		/// <inheritdoc />
		public Task<long> SendRequestAsync(AppSendRequestParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => SendRequest(@params: @params), token);
		}

		/// <inheritdoc />
		public Task<bool> DeleteAppRequestsAsync(CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(DeleteAppRequests, token);
		}

		/// <inheritdoc />
		public Task<VkCollection<User>> GetFriendsListAsync(AppRequestType type, bool? extended = null, long? count = null,
															long? offset = null, UsersFields fields = null,
															CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetFriendsList(type, extended, count, offset), token);
		}

		/// <inheritdoc />
		public Task<LeaderboardResult> GetLeaderboardAsync(AppRatingType type, bool? global = null, bool? extended = null,
															CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetLeaderboard(type, global, extended), token);
		}

		/// <inheritdoc />
		public Task<long> GetScoreAsync(long userId, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetScore(userId: userId), token);
		}
	}
}