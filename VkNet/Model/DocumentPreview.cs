using System;
using Newtonsoft.Json;
using VkNet.Model.Attachments;
using VkNet.Utils;

namespace VkNet.Model
{
	/// <summary>
	/// Информация для предварительного просмотра документа
	/// </summary>
	[Serializable]
	public class DocumentPreview
	{
		/// <summary>
		/// Изображения для предпросмотра.
		/// </summary>
		[JsonProperty("photo")]
		public Photo Photo { get; set; }

		/// <summary>
		/// Данные о граффити
		/// </summary>
		[JsonProperty("graffiti")]
		public Graffiti Graffiti { get; set; }

		/// <summary>
		/// Данные об аудиосообщении.
		/// </summary>
		[JsonProperty("audio_message")]
		public AudioMessage AudioMessage { get; set; }

		/// <summary>
		/// Разобрать из json.
		/// </summary>
		/// <param name="response"> Ответ сервера. </param>
		/// <returns> </returns>
		public static DocumentPreview FromJson(VkResponse response)
		{
			return new()
			{
				Photo = response["photo"],
				Graffiti = response["graffiti"],
				AudioMessage = response["audio_message"]
			};
		}
	}
}