using VkNet.Utils;

namespace VkNet.Enums
{
	/// <summary>
	/// Статус рекламного кабинета.
	/// </summary>
	public enum AccountStatus
	{
		/// <summary>
		/// Активен
		/// </summary>
		Active = 1,

		/// <summary>
		/// Неактивен
		/// </summary>
		[DefaultValue]
		Inactive = 0
	}
}