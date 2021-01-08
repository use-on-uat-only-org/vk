using System;
using Newtonsoft.Json;
using VkNet.Utils;

namespace VkNet.Model.Audio
{
	/// <summary>
	/// Жанр плейлиста.
	/// </summary>
	[Serializable]
	public class AudioPlaylistGenre
	{
		/// <summary>
		/// Идентификатор жанра.
		/// </summary>
		[JsonProperty("id")]
		public long Id { get; set; }

		/// <summary>
		/// Название жанра.
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

	#region Методы

		/// <summary>
		/// Разобрать из json.
		/// </summary>
		/// <param name="response"> Ответ сервера. </param>
		/// <returns> </returns>
		public static AudioPlaylistGenre FromJson(VkResponse response)
		{
			var playlistGenre = new AudioPlaylistGenre
			{
				Id = response["id"],
				Name = response["name"]
			};

			return playlistGenre;
		}

	#endregion
	}
}