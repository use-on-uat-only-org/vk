using System;
using Newtonsoft.Json;
using VkNet.Utils;

namespace VkNet.Model.Audio
{
	/// <summary>
	/// Неизвестно.
	/// </summary>
	[Serializable]
	public class AudioPlaylistOriginal
	{
		/// <summary>
		/// Идентификатор владельца.
		/// </summary>
		[JsonProperty("owner_id")]
		public long OwnerId { get; set; }

		/// <summary>
		/// Идентификатор плейлиста.
		/// </summary>
		[JsonProperty("playlist_id")]
		public long PlaylistId { get; set; }

		/// <summary>
		/// Ключ доступа.
		/// </summary>
		[JsonProperty("access_key")]
		public string AccessKey { get; set; }

	#region Методы

		/// <summary>
		/// Разобрать из json.
		/// </summary>
		/// <param name="response"> Ответ сервера. </param>
		/// <returns> </returns>
		public static AudioPlaylistOriginal FromJson(VkResponse response)
		{
			var playlistOriginal = new AudioPlaylistOriginal
			{
				OwnerId = response["owner_id"],
				PlaylistId = response["playlist_id"],
				AccessKey = response["access_key"]
			};

			return playlistOriginal;
		}

	#endregion
	}
}