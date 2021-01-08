using System;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using VkNet.Utils;

namespace VkNet.Model
{
	/// <summary>
	/// Информация о вложенной ветке комментариев
	/// </summary>
	[Serializable]
	public class CommentThread
	{
		/// <summary>
		/// Количество комментариев в ветке
		/// </summary>
		[JsonProperty("count")]
		public long? Count { get; set; }

		/// <summary>
		/// Массив объектов комментариев к записи
		/// </summary>
		/// <remarks>
		/// Только для метода wall.getComments
		/// </remarks>
		[JsonProperty("items")]
		public ReadOnlyCollection<Comment> Items { get; set; }

		/// <summary>
		/// Может ли текущий пользователь оставлять комментарии в этой ветке
		/// </summary>
		[JsonProperty("can_post")]
		public bool? CanPost { get; set; }

		/// <summary>
		/// Нужно ли отображать кнопку «ответить» в ветке
		/// </summary>
		[JsonProperty("show_reply_button")]
		public bool? ShowReplyButton { get; set; }

		/// <summary>
		/// Могут ли сообщества оставлять комментарии в ветке.
		/// </summary>
		[JsonProperty("groups_can_post")]
		public bool? GroupsCanPost { get; set; }

		/// <summary>
		/// Разобрать из json.
		/// </summary>
		/// <param name="response"> Ответ сервера. </param>
		/// <returns> </returns>
		public static CommentThread FromJson(VkResponse response)
		{
			return new()
			{
				Count = response["count"],
				Items = response["items"].ToReadOnlyCollectionOf<Comment>(x => x),
				CanPost = response["can_post"],
				ShowReplyButton = response["show_reply_button"],
				GroupsCanPost = response["groups_can_post"]
			};
		}
	}
}