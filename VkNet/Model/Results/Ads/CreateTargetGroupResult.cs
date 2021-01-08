using System;
using Newtonsoft.Json;
using VkNet.Utils;

namespace VkNet.Model.Results.Ads
{
	/// <summary>
	/// Результат метода Ads.CreateTargetGroup
	/// </summary>
	[Serializable]
	public class CreateTargetGroupResult
	{
		/// <summary>
		/// Идентификатор аудитории.
		/// </summary>
		[JsonProperty("id")]
		public long Id { get; set; }

		/// <summary>
		/// Разобрать из json.
		/// </summary>
		/// <param name="response"> Ответ сервера. </param>
		/// <returns> </returns>
		public static CreateTargetGroupResult FromJson(VkResponse response)
		{
			return new()
			{
				Id = response["id"]
			};
		}
	}
}