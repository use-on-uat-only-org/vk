using System;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using VkNet.Utils;

namespace VkNet.Model.Attachments
{
	/// <inheritdoc />
	[Serializable]
	public class PrettyCards : MediaAttachment
	{
		/// <inheritdoc />
		protected override string Alias => "pretty_cards";

		/// <summary>
		/// Cards
		/// </summary>
		[JsonProperty("cards")]
		public ReadOnlyCollection<PrettyCard> Cards { get; set; }

		/// <summary>
		/// Разобрать из json.
		/// </summary>
		/// <param name="response"> Ответ сервера. </param>
		/// <returns> </returns>
		public static PrettyCards FromJson(VkResponse response)
		{
			return new()
			{
				Cards = response["cards"].ToReadOnlyCollectionOf<PrettyCard>(x => x)
			};
		}
	}
}