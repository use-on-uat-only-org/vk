using System;
using VkNet.Abstractions.Authorization;
using VkNet.Enums;
using VkNet.Infrastructure;

namespace VkNet.Abstractions
{
	/// <summary>
	/// VkApi
	/// </summary>
	public interface IVkApi : IDisposable, IVkApiAuthAsync, IVkApiCategories, IVkApiCaptcha, IVkInvoke
	{
	#region Properties

		/// <summary>
		/// Ограничение на кол-во запросов в секунду
		/// </summary>
		int RequestsPerSecond { get; set; }

		/// <summary>
		/// Поток авторизации
		/// </summary>
		IAuthorizationFlow AuthorizationFlow { get; set; }

		/// <summary>
		/// Текущая сессия.
		/// </summary>
		TokenManager AccessToken { get; set; }

		/// <summary>
		/// Id авторизованного пользователя
		/// </summary>
		long? UserId { get; }

	#endregion

	#region Methods

		/// <summary>
		/// Установить язык
		/// </summary>
		/// <param name="language"> </param>
		void SetLanguage(Language language);

		/// <summary>
		/// Установить язык
		/// </summary>
		Language? GetLanguage();

	#endregion
	}
}