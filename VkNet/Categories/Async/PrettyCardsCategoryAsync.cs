using System;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;
using VkNet.Model;
using VkNet.Model.RequestParams;
using VkNet.Model.RequestParams.PrettyCards;
using VkNet.Model.Results.PrettyCards;
using VkNet.Utils;

namespace VkNet.Categories
{
	/// <inheritdoc />
	public partial class PrettyCardsCategory
	{
		/// <inheritdoc />
		public Task<PrettyCardsCreateResult> CreateAsync(PrettyCardsCreateParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => Create(@params: @params), token);
		}

		/// <inheritdoc />
		public Task<PrettyCardsDeleteResult> DeleteAsync(PrettyCardsDeleteParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => Delete(@params: @params), token);
		}

		/// <inheritdoc />
		public Task<PrettyCardsEditResult> EditAsync(PrettyCardsEditParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => Edit(@params: @params), token);
		}

		/// <inheritdoc />
		public Task<VkCollection<PrettyCardsGetByIdResult>> GetAsync(PrettyCardsGetParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => Get(@params: @params), token);
		}

		/// <inheritdoc />
		public Task<ReadOnlyCollection<PrettyCardsGetByIdResult>> GetByIdAsync(PrettyCardsGetByIdParams @params,
																				CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetById(@params: @params), token);
		}

		/// <param name="token"></param>
		/// <inheritdoc />
		public Task<Uri> GetUploadUrlAsync(CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(GetUploadUrl, token);
		}
	}
}