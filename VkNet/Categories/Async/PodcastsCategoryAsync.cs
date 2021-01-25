using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;
using VkNet.Model.RequestParams.Podcasts;
using VkNet.Model.Results.Podcasts;
using VkNet.Utils;

namespace VkNet.Categories
{
	/// <inheritdoc />
	public partial class PodcastsCategory
	{
		/// <param name="token"></param>
		/// <inheritdoc />
		public Task<bool> ClearRecentSearchesAsync(CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(ClearRecentSearches, token);
		}

		/// <param name="token"></param>
		/// <inheritdoc />
		public Task<ReadOnlyCollection<PodcastsGetPopularResult>> GetPopularAsync(CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(GetPopular, token);
		}

		/// <param name="token"></param>
		/// <inheritdoc />
		public Task<ReadOnlyCollection<string>> GetRecentSearchRequestsAsync(CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(GetRecentSearchRequests, token);
		}

		/// <inheritdoc />
		public Task<PodcastsSearchResult> SearchAsync(PodcastsSearchParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => Search(@params: @params), token);
		}

		/// <inheritdoc />
		public Task<PodcastsSearchResult> SearchPodcastAsync(PodcastsSearchParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => SearchPodcast(@params: @params), token);
		}
	}
}