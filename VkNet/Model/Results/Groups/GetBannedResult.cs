using System;
using Newtonsoft.Json;
using VkNet.Enums.SafetyEnums;
using VkNet.Model.Group;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model.Results.Groups
{
	/// <summary>
	/// Результат запроса groups.getBanned
	/// </summary>
	[Serializable]
	public class GetBannedResult
	{
		/// <summary>
		/// Тип
		/// </summary>
		[JsonProperty(propertyName: "type")]
		[JsonConverter(converterType: typeof(SafetyEnumJsonConverter))]
		public SearchResultType Type { get; set; }

		/// <summary>
		/// Информация о сообществе (для type = group)
		/// </summary>
		[JsonProperty(propertyName: "group")]
		public Group.Group Group { get; set; }

		/// <summary>
		/// Информация о пользователе (для type = profile)
		/// </summary>
		[JsonProperty(propertyName: "profile")]
		public User Profile { get; set; }

		/// <summary>
		/// Информация о блокировке в сообществе.
		/// </summary>
		[JsonProperty(propertyName: "ban_info")]
		public BanInfo BanInfo { get; set; }
	}
}