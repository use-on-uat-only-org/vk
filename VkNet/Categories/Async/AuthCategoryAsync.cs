using System.Threading;
using System.Threading.Tasks;
using VkNet.Model;
using VkNet.Model.RequestParams;
using VkNet.Model.RequestParams.Auth;
using VkNet.Model.Results.Auth;
using VkNet.Utils;

namespace VkNet.Categories
{
	/// <inheritdoc />
	public partial class AuthCategory
	{
		/// <inheritdoc />
		public Task<bool> CheckPhoneAsync(string phone, string clientSecret, long? clientId = null, bool? authByPhone = null,
										CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => CheckPhone(phone, clientSecret, clientId, authByPhone), token);
		}

		/// <inheritdoc />
		public Task<string> SignupAsync(AuthSignupParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => Signup(@params: @params), token);
		}

		/// <inheritdoc />
		public Task<AuthConfirmResult> ConfirmAsync(AuthConfirmParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => Confirm(@params: @params), token);
		}

		/// <inheritdoc />
		public Task<string> RestoreAsync(string phone, string lastName, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => Restore(phone, lastName), token);
		}
	}
}