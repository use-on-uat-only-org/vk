using System;
using VkNet.Utils;

namespace VkNet.Model
{
	/// <summary>
	/// Точки градиента фона опроса.
	/// </summary>
	[Serializable]
	public class PollBackgroundPoint
	{
		/// <summary>
		/// Положение точки
		/// </summary>
		public int Position { get; set; }

		/// <summary>
		/// HEX-код цвета точки
		/// </summary>
		public string Color { get; set; }

		/// <summary>
		/// Разобрать из json.
		/// </summary>
		/// <param name="response"> Ответ сервера. </param>
		/// <returns> </returns>
		public static PollBackgroundPoint FromJson(VkResponse response)
		{
			return new()
			{
				Color = response["color"],
				Position = response["position"]
			};
		}
	}
}