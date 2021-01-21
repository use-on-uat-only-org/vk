using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;
using VkNet.Enums;
using VkNet.Model;
using VkNet.Model.RequestParams.Database;
using VkNet.Utils;

namespace VkNet.Categories
{
	/// <inheritdoc />
	public partial class DatabaseCategory
	{
		/// <inheritdoc />
		public Task<VkCollection<Country>> GetCountriesAsync(bool? needAll = null, IEnumerable<Iso3166> codes = null, int? count = null,
															int? offset = null, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetCountries(needAll, codes, count, offset), token);
		}

		/// <inheritdoc />
		public Task<VkCollection<Region>> GetRegionsAsync(int countryId, string query = "", int? count = null, int? offset = null,
														CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetRegions(countryId, query, count, offset), token);
		}

		/// <inheritdoc />
		public Task<ReadOnlyCollection<Street>> GetStreetsByIdAsync(int[] streetIds, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetStreetsById(streetIds), token);
		}

		/// <inheritdoc />
		public Task<ReadOnlyCollection<Country>> GetCountriesByIdAsync(int[] countryIds, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetCountriesById(countryIds), token);
		}

		/// <inheritdoc />
		public Task<VkCollection<City>> GetCitiesAsync(GetCitiesParams getCitiesParams, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetCities(getCitiesParams), token);
		}

		/// <inheritdoc />
		public Task<ReadOnlyCollection<City>> GetCitiesByIdAsync(int[] cityIds, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetCitiesById(cityIds), token);
		}

		/// <inheritdoc />
		public Task<VkCollection<University>> GetUniversitiesAsync(int countryId, int cityId, string query = "", int? count = null,
																	int? offset = null,
																	CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetUniversities(countryId, cityId, query, count, offset), token);
		}

		/// <inheritdoc />
		public Task<VkCollection<School>> GetSchoolsAsync(int cityId, string query = "", int? offset = null, int? count = null,
														CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetSchools(cityId, query, offset, count), token);
		}

		/// <inheritdoc />
		public Task<VkCollection<Faculty>> GetFacultiesAsync(long universityId, int? count = null, int? offset = null,
															CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetFaculties(universityId, count, offset), token);
		}

		/// <inheritdoc />
		public Task<ReadOnlyCollection<SchoolClass>> GetSchoolClassesAsync(long countryId, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetSchoolClasses(countryId), token);
		}

		/// <inheritdoc />
		public Task<VkCollection<Chair>> GetChairsAsync(long facultyId, int? count = null, int? offset = null,
														CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetChairs(facultyId, count, offset), token);
		}

		/// <inheritdoc />
		public Task<ReadOnlyCollection<MetroStation>> GetMetroStationsByIdAsync(IEnumerable<ulong> stationIds,
																				CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetMetroStationsById(stationIds), token);
		}

		/// <inheritdoc />
		public Task<VkCollection<MetroStation>> GetMetroStationsAsync(ulong cityId, int? offset = null, int? count = null,
																	bool extended = false, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetMetroStations(cityId, offset, count, extended), token);
		}
	}
}