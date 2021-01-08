using System;
using JetBrains.Annotations;
using Newtonsoft.Json;
using VkNet.Enums.SafetyEnums;
using VkNet.Utils;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model.Keyboard
{
	/// <summary>
	/// Кнопка клавиатуры, отправляемая ботом.
	/// </summary>
	[Serializable]
	[JsonObject(MemberSerialization.OptOut)]
	public class MessageKeyboardButton
	{
		/// <summary>
		/// Информация содержащаяся в кнопке
		/// </summary>
		[JsonProperty("action")]
		public MessageKeyboardButtonAction Action { get; set; }

		/// <summary>
		/// Цвет кнопки
		/// </summary>
		[JsonProperty("color", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(SafetyEnumJsonConverter))]
		public KeyboardButtonColor Color { get; set; }

		/// <summary>
		/// Разобрать из json.
		/// </summary>
		/// <param name="response"> Ответ сервера. </param>
		/// <returns> </returns>
		public static MessageKeyboardButton FromJson([NotNull] VkResponse response)
		{
			return new()
			{
				Action = response["action"],
				Color = response["color"]
			};
		}
	}
}