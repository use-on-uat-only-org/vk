using VkNet.Utils;

namespace VkNet.Enums
{
	/// <summary>
	/// Возрастные ограничения
	/// </summary>
	public enum AgeLimit
	{
		/// <summary>
		/// Нет ограничений
		/// </summary>
		[DefaultValue]
		Withoutlimit = 1,

		/// <summary>
		/// 16+
		/// </summary>
		Sixteen = 2,

		/// <summary>
		/// 18+
		/// </summary>
		Eighteen
	}
}