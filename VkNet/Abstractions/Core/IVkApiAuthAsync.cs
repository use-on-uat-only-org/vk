using System;
using System.Threading.Tasks;
using VkNet.Model;
using VkNet.Model.RequestParams.Auth;

namespace VkNet.Abstractions
{
	/// <inheritdoc cref="IVkApiAuth"/>
	public interface IVkApiAuthAsync : IVkApiAuth
	{
		/// <inheritdoc cref="IVkApiAuth.Authorize(IApiAuthParams)"/>
		Task AuthorizeAsync(IApiAuthParams @params);

		/// <inheritdoc cref="IVkApiAuth.RefreshToken"/>
		Task RefreshTokenAsync(Func<string> code = null);

		/// <inheritdoc cref="IVkApiAuth.LogOut"/>
		Task LogOutAsync();
	}
}