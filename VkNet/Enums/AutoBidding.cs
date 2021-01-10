using VkNet.Utils;

namespace VkNet.Enums
{
	/// <summary>
	/// Автоматическое управление ценой.
	/// </summary>
	public enum AutoBidding
	{
		/// <summary>
		/// Выключено.
		/// </summary>
		[DefaultValue]
		Off = 0,

		/// <summary>
		/// Включено.
		/// </summary>
		On = 1
	}
}