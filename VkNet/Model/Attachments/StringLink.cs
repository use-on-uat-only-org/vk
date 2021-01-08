using System;
using VkNet.Utils;

namespace VkNet.Model.Attachments
{
	/// <summary>
	/// Строковая ссылка
	/// </summary>
	[Serializable]
	public class StringLink : MediaAttachment
	{
		/// <inheritdoc />
		protected override string Alias => "string";

		/// <summary>
		/// Ссылка
		/// </summary>
		public string Link { get; set; }

		/// <inheritdoc />
		public override string ToString()
		{
			return Link;
		}

		public static StringLink FromJson(VkResponse response)
		{
			return new()
			{
				Link = response["link"]
			};
		}
	}
}