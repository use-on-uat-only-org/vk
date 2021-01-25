using System.Threading;
using System.Threading.Tasks;
using VkNet.Model;
using VkNet.Model.RequestParams;
using VkNet.Model.RequestParams.Search;
using VkNet.Utils;

namespace VkNet.Abstractions
{
	/// <summary>
	/// Методы для работы с поиском.
	/// </summary>
	public interface ISearchCategoryAsync
	{
		/// <summary>
		/// Метод позволяет получить результаты быстрого поиска по произвольной подстроке
		/// </summary>
		/// <param name="params"> Параметры запроса </param>
		/// <param name="token"></param>
		/// <returns>
		/// </returns>
		/// <remarks>
		/// Страница документации ВКонтакте https://vk.com/dev/search.getHints
		/// </remarks>
		Task<VkCollection<SearchHintsItem>> GetHintsAsync(SearchGetHintsParams @params, CancellationToken token);
	}
}