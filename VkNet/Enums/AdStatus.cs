using VkNet.Utils;

namespace VkNet.Enums
{
	/// <summary>
	/// Cтатус объявления.
	/// </summary>
	public enum AdStatus
	{
		/// <summary>
		/// Объявление остановлено
		/// </summary>
		[DefaultValue]
		Stopped = 0,

		/// <summary>
		/// Объявление запущено
		/// </summary>
		Active,

		/// <summary>
		/// Объявление удалено
		/// </summary>
		Deleted
	}
}