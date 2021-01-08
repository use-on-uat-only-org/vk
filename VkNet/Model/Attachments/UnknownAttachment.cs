using System;
using VkNet.Utils;

namespace VkNet.Model.Attachments
{
	/// <summary>
	/// Неизвестное вложение
	/// </summary>
	[Serializable]
	public class UnknownAttachment : MediaAttachment
	{
		/// <inheritdoc />
		protected override string Alias => nameof(UnknownAttachment);

		/// <summary>
		/// Разобрать из json.
		/// </summary>
		/// <param name="response"> Ответ сервера. </param>
		/// <returns> </returns>
		public static UnknownAttachment FromJson(VkResponse response)
		{
			return new()
			{
				Id = response["id"]
			};
		}
	}
}