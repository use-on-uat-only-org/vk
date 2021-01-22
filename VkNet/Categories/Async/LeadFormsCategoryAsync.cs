using System;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;
using VkNet.Model.RequestParams.LeadForms;
using VkNet.Model.Results.LeadForms;
using VkNet.Utils;

namespace VkNet.Categories
{
	/// <inheritdoc/>
	public partial class LeadFormsCategory
	{
		/// <inheritdoc/>
		public Task<LeadFormCreateResult> CreateAsync(LeadFormsCreateParams createParams, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => Create(createParams), token);
		}

		/// <inheritdoc/>
		public Task<LeadFormCreateResult> DeleteAsync(long groupId, long formId, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => Delete(groupId, formId), token);
		}

		/// <inheritdoc/>
		public Task<LeadFormCreateResult> GetAsync(long groupId, long formId, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => Get(groupId, formId), token);
		}

		/// <inheritdoc/>
		public Task<ReadOnlyCollection<LeadFormsGetLeadResult>> GetLeadsAsync(long groupId, long formId, string nextPageToken,
																			ulong? limit = null, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetLeads(groupId, formId, nextPageToken, limit), token);
		}

		/// <param name="token"></param>
		/// <inheritdoc/>
		public Task<Uri> GetUploadURLAsync(CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(GetUploadURL, token);
		}

		/// <inheritdoc/>
		public Task<ReadOnlyCollection<LeadFormCreateResult>> ListAsync(long groupId, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => List(groupId), token);
		}

		/// <inheritdoc/>
		public Task<LeadFormCreateResult> UpdateAsync(LeadFormsUpdateParams updateParams, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => Update(updateParams), token);
		}
	}
}