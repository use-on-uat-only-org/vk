using VkNet.Utils;

namespace VkNet.Enums
{
	/// <summary>
	/// Тип цели.
	/// </summary>
	public enum GoalType
	{
		/// <summary>
		/// Показы.
		/// </summary>
		[DefaultValue]
		Cpc = 1,

		/// <summary>
		/// Переходы.
		/// </summary>
		Cpm = 2,

		/// <summary>
		/// Отправка заявок
		/// </summary>
		OCpm = 3
	}
}