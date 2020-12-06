namespace VkNet.Enums.SafetyEnums
{
	/// <summary>
	/// Тип шаблона.
	/// </summary>
	public class TemplateType : SafetyEnum<TemplateType>
	{
		/// <summary>
		/// Карусель
		/// </summary>
		public static readonly TemplateType Carousel = RegisterPossibleValue("carousel");
	}
}