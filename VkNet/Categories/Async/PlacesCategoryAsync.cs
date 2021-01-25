using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;
using VkNet.Model;
using VkNet.Model.RequestParams.Places;
using VkNet.Utils;

namespace VkNet.Categories
{
	/// <inheritdoc />
	public partial class PlacesCategory
	{
		/// <inheritdoc />
		public Task<long> AddAsync(PlacesAddParams placesAddParams, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => Add(placesAddParams: placesAddParams), token);
		}

		/// <inheritdoc />
		public Task<long> CheckinAsync(PlacesCheckinParams placesCheckinParams, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => Checkin(placesCheckinParams: placesCheckinParams), token);
		}

		/// <inheritdoc />
		public Task<ReadOnlyCollection<Place>> GetByIdAsync(IEnumerable<ulong> places, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetById(places: places), token);
		}

		/// <inheritdoc />
		public Task<VkCollection<Checkin>> GetCheckinsAsync(PlacesGetCheckinsParams placesGetCheckinsParams, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetCheckins(placesGetCheckinsParams: placesGetCheckinsParams), token);
		}

		/// <param name="token"></param>
		/// <inheritdoc />
		public Task<ReadOnlyCollection<PlaceType>> GetTypesAsync(CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(GetTypes, token);
		}

		/// <inheritdoc />
		public Task<VkCollection<Place>> SearchAsync(PlacesSearchParams placesSearchParams, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => Search(placesSearchParams: placesSearchParams), token);
		}
	}
}