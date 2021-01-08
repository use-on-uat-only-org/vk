using System;
using Newtonsoft.Json;
using VkNet.Utils;

namespace VkNet.Model
{
	/// <summary>
	/// Текущее значение
	/// </summary>
	[Serializable]
	public class PrivacySettingsValue
	{
		/// <summary>
		/// Категория
		/// </summary>
		[JsonProperty("category")]
		public string Category { get; set; }

		/// <summary>
		/// Разобрать из json.
		/// </summary>
		/// <param name="response"> Ответ сервера. </param>
		/// <returns> </returns>
		public static PrivacySettingsValue FromJson(VkResponse response)
		{
			return new()
			{
				Category = response["category"]
			};
		}
	}
}