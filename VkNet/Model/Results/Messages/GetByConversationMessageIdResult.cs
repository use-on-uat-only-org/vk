using System;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using VkNet.Model.Attachments;

namespace VkNet.Model.Results.Messages
{
	/// <summary>
	/// Результат метода messages.getByConversationMessageId
	/// </summary>
	[Serializable]
	public class GetByConversationMessageIdResult
	{
		/// <summary>
		/// Число результатов
		/// </summary>
		[JsonProperty("count")]
		public long Count { get; set; }

		/// <summary>
		/// Массив объектов, описывающих сообщения
		/// </summary>
		[JsonProperty("items")]
		public ReadOnlyCollection<Message> Items { get; set; }

		/// <summary>
		/// Массив объектов пользователей.
		/// </summary>
		[JsonProperty("profiles")]
		public ReadOnlyCollection<User> Profiles { get; set; }

		/// <summary>
		/// Массив объектов сообществ.
		/// </summary>
		[JsonProperty("groups")]
		public ReadOnlyCollection<Group.Group> Groups { get; set; }
	}
}