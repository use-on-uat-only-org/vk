using System;
using Newtonsoft.Json;
using VkNet.Utils;

namespace VkNet.Model
{
	/// <summary>
	/// Количество
	/// </summary>
	[Serializable]
	public class AmountObject
	{
		/// <summary>
		/// Количество
		/// </summary>
		[JsonProperty("amount")]
		public long Amount { get; set; }

		/// <summary>
		/// Валюта
		/// </summary>
		[JsonProperty("currency")]
		public Currency Currency { get; set; }

		/// <summary>
		/// Текст
		/// </summary>
		[JsonProperty("text")]
		public string Text { get; set; }

		/// <summary>
		/// Разобрать из json.
		/// </summary>
		/// <param name="response"> Ответ сервера. </param>
		/// <returns> </returns>
		public static AmountObject FromJson(VkResponse response)
		{
			return new()
			{
				Text = response["text"],
				Amount = response["amount"],
				Currency = response["currency"]
			};
		}
	}
}