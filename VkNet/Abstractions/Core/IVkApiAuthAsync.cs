using System;
using System.Threading;
using System.Threading.Tasks;
using VkNet.Model.RequestParams.Auth;

namespace VkNet.Abstractions
{
	/// <inheritdoc cref="IVkApiAuth"/>
	public interface IVkApiAuthAsync : IVkApiAuth
	{
		/// <inheritdoc cref="IVkApiAuth.Authorize(IApiAuthParams)"/>
		Task AuthorizeAsync(IApiAuthParams @params, CancellationToken token = default);

		/// <inheritdoc cref="IVkApiAuth.RefreshToken"/>
		Task RefreshTokenAsync(Func<string> code = null, CancellationToken token = default);

		/// <param name="token"></param>
		/// <inheritdoc cref="IVkApiAuth.LogOut"/>
		Task LogOutAsync(CancellationToken token = default);
	}
}