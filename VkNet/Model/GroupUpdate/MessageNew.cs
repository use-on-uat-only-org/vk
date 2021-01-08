using System;
using Newtonsoft.Json;
using VkNet.Model.Attachments;
using VkNet.Utils;

namespace VkNet.Model.GroupUpdate
{
	/// <summary>
	/// Объект, который содержит сообщение и информацию о доступных пользователю функциях.
	/// </summary>
	[Serializable]
	public class MessageNew
	{
		/// <summary>
		/// Сообщение.
		/// </summary>
		[JsonProperty("message")]
		public Message Message { get; set; }

		/// <summary>
		/// Информация о доступных пользователю функциях.
		/// </summary>
		[JsonProperty("client_info")]
		public ClientInfo ClientInfo { get; set; }

	#region Методы

		/// <summary>
		/// </summary>
		/// <param name="response"> </param>
		/// <returns> </returns>
		public static MessageNew FromJson(VkResponse response)
		{
			return new()
			{
				Message = response["message"],
				ClientInfo = response["client_info"]
			};
		}

	#endregion
	}
}