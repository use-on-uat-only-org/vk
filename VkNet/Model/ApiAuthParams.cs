using System;
using Newtonsoft.Json;
using VkNet.Enums.Filters;
using VkNet.Enums.SafetyEnums;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model
{
	/// <inheritdoc />
	[Serializable]
	public class ApiAuthParams : IApiAuthParams
	{
		// TODO: добавить поле IsValid в котором проверять достаточно ли параметров для авторизации

		/// <inheritdoc />
		public bool? TwoFactorSupported { get; set; }

		/// <inheritdoc />
		public string Code { get; set; }

		/// <inheritdoc />
		public string ClientSecret { get; set; }

		/// <inheritdoc />
		public ulong? ApplicationId { get; set; }

		/// <inheritdoc />
		public Uri RedirectUri { get; set; }

		/// <inheritdoc />
		[JsonConverter(typeof(SafetyEnumJsonConverter))]
		public Display Display { get; set; }

		/// <inheritdoc />
		public Settings Settings { get; set; }

		/// <inheritdoc />
		public string State { get; set; }

		/// <inheritdoc />
		public string Login { get; set; }

		/// <inheritdoc />
		public string Password { get; set; }

		/// <inheritdoc />
		public long? CaptchaSid { get; set; }

		/// <inheritdoc />
		public string CaptchaKey { get; set; }

		/// <summary>
		/// Формирует параметры авторизации по минимальному набору необходимых полей для авторизации по логину и паролю
		/// </summary>
		/// <param name="appId">Id приложения ВК</param>
		/// <param name="login">Логин</param>
		/// <param name="password">Пароль</param>
		/// <param name="scopeSettings">Права доступа</param>
		/// <returns></returns>
		public static ApiAuthParams Format(ulong appId, string login, string password, Settings scopeSettings)
		{
			return new ApiAuthParams()
			{
				ApplicationId = appId,
				Login = login,
				Password = password,
				Settings = scopeSettings
			};
		}
	}
}