using System;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using VkNet.Enums;
using VkNet.Enums.SafetyEnums;
using VkNet.Model;
using VkNet.Model.Ads;
using VkNet.Model.RequestParams.Ads;
using VkNet.Model.Results.Ads;
using VkNet.Utils;

namespace VkNet.Categories
{
	/// <inheritdoc />
	public partial class AdsCategory
	{
		/// <inheritdoc/>
		public Task<ReadOnlyCollection<bool>> AddOfficeUsersAsync(AdsDataSpecificationParams<UserSpecification> adsDataSpecification,
																CancellationToken token = default)
		{
			return _vk.CallAsync<ReadOnlyCollection<bool>>("ads.addOfficeUsers",
				new VkParameters
				{
					{ "account_id", adsDataSpecification.AccountId },
					{ "data", JsonConvert.SerializeObject(adsDataSpecification.Data) }
				});

			return TypeHelper.TryInvokeMethodAsync(() => AddOfficeUsers(adsDataSpecification));
		}

		/// <inheritdoc/>
		public Task<LinkStatus> CheckLinkAsync(CheckLinkParams checkLinkParams, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => CheckLink(checkLinkParams));
		}

		/// <inheritdoc/>
		public Task<ReadOnlyCollection<CreateAdsResult>> CreateAdsAsync(AdsDataSpecificationParams<AdSpecification> adsDataSpecification,
																		CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => CreateAds(adsDataSpecification));
		}

		/// <inheritdoc/>
		public Task<ReadOnlyCollection<CreateCampaignResult>> CreateCampaignsAsync(
			AdsDataSpecificationParams<CampaignSpecification> campaignsDataSpecification, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => CreateCampaigns(campaignsDataSpecification));
		}

		/// <inheritdoc/>
		public Task<ReadOnlyCollection<CreateClientResult>> CreateClientsAsync(
			AdsDataSpecificationParams<ClientSpecification> clientDataSpecification, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => CreateClients(clientDataSpecification));
		}

		/// <inheritdoc/>
		public Task<CreateLookALikeRequestResult> CreateLookalikeRequestAsync(CreateLookALikeRequestParams createLookALikeRequestParams,
																			CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => CreateLookalikeRequest(createLookALikeRequestParams));
		}

		/// <inheritdoc/>
		public Task<CreateTargetGroupResult> CreateTargetGroupAsync(CreateTargetGroupParams createTargetGroupParams,
																	CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => CreateTargetGroup(createTargetGroupParams));
		}

		/// <inheritdoc/>
		public Task<CreateTargetPixelResult> CreateTargetPixelAsync(CreateTargetPixelParams createTargetPixelParams,
																	CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => CreateTargetPixel(createTargetPixelParams));
		}

		/// <inheritdoc/>
		public Task<ReadOnlyCollection<bool>> DeleteAdsAsync(DeleteAdsParams deleteAdsParams, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => DeleteAds(deleteAdsParams));
		}

		/// <inheritdoc/>
		public Task<ReadOnlyCollection<bool>> DeleteCampaignsAsync(DeleteCampaignsParams deleteCampaignsParams,
																	CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => DeleteCampaigns(deleteCampaignsParams));
		}

		/// <inheritdoc/>
		public Task<ReadOnlyCollection<bool>> DeleteClientsAsync(DeleteClientsParams deleteClientsParams, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => DeleteClients(deleteClientsParams));
		}

		/// <inheritdoc/>
		public Task<bool> DeleteTargetGroupAsync(DeleteTargetGroupParams deleteTargetGroupParams, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => DeleteTargetGroup(deleteTargetGroupParams));
		}

		/// <inheritdoc/>
		public Task<bool> DeleteTargetPixelAsync(DeleteTargetPixelParams deleteTargetPixelParams, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => DeleteTargetPixel(deleteTargetPixelParams));
		}

		/// <param name="token"></param>
		/// <inheritdoc/>
		public Task<ReadOnlyCollection<AdsAccount>> GetAccountsAsync(CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(GetAccounts);
		}

		/// <inheritdoc/>
		public Task<ReadOnlyCollection<Ad>> GetAdsAsync(GetAdsParams getAdsParams, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetAds(getAdsParams));
		}

		/// <inheritdoc/>
		public Task<ReadOnlyCollection<Layout>> GetAdsLayoutAsync(GetAdsLayoutParams getAdsLayoutParams, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetAdsLayout(getAdsLayoutParams));
		}

		/// <inheritdoc/>
		public Task<ReadOnlyCollection<AdsTargetingResult>> GetAdsTargetingAsync(GetAdsTargetingParams getAdsTargetingParams,
																				CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetAdsTargeting(getAdsTargetingParams));
		}

		/// <inheritdoc/>
		public Task<double> GetBudgetAsync(long accountId, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetBudget(accountId));
		}

		/// <inheritdoc/>
		public Task<ReadOnlyCollection<AdsCampaign>> GetCampaignsAsync(AdsGetCampaignsParams adsGetCampaignsParams,
																		CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetCampaigns(adsGetCampaignsParams));
		}

		/// <inheritdoc/>
		public Task<GetCategoriesResult> GetCategoriesAsync(Language lang, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetCategories(lang));
		}

		/// <inheritdoc/>
		public Task<ReadOnlyCollection<GetClientsResult>> GetClientsAsync(long accountId, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetClients(accountId));
		}

		/// <inheritdoc/>
		public Task<ReadOnlyCollection<GetDemographicsResult>> GetDemographicsAsync(GetDemographicsParams getDemographicsParams,
																					CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetDemographics(getDemographicsParams));
		}

		/// <inheritdoc/>
		public Task<GetFloodStatsResult> GetFloodStatsAsync(long accountId, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetFloodStats(accountId));
		}

		/// <inheritdoc/>
		public Task<GetLookalikeRequestsResult> GetLookalikeRequestsAsync(GetLookalikeRequestsParams getLookalikeRequestsParams,
																		CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetLookalikeRequests(getLookalikeRequestsParams));
		}

		/// <inheritdoc/>
		public Task<ReadOnlyCollection<GetOfficeUsersResult>> GetOfficeUsersAsync(long accountId, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetOfficeUsers(accountId));
		}

		/// <inheritdoc/>
		public Task<ReadOnlyCollection<GetPostsReachResult>> GetPostsReachAsync(long accountId, IdsType idsType, string ids,
																				CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetPostsReach(accountId, idsType, ids));
		}

		/// <inheritdoc/>
		public Task<GetRejectionReasonResult> GetRejectionReasonAsync(long accountId, long adId, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetRejectionReason(accountId, adId));
		}

		/// <inheritdoc/>
		public Task<ReadOnlyCollection<GetStatisticsResult>> GetStatisticsAsync(GetStatisticsParams getStatisticsParams,
																				CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetStatistics(getStatisticsParams));
		}

		/// <inheritdoc/>
		public Task<ReadOnlyCollection<GetSuggestionsResult>> GetSuggestionsAsync(GetSuggestionsParams getSuggestionsParams,
																				CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetSuggestions(getSuggestionsParams));
		}

		/// <inheritdoc/>
		public Task<ReadOnlyCollection<GetTargetGroupsResult>> GetTargetGroupsAsync(long accountId, long? clientId = null,
																					bool? extended = null,
																					CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetTargetGroups(accountId, clientId, extended));
		}

		/// <inheritdoc/>
		public Task<ReadOnlyCollection<GetTargetPixelsResult>> GetTargetPixelsAsync(long accountId, long? clientId = null,
																					CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetTargetPixels(accountId, clientId));
		}

		/// <inheritdoc/>
		public Task<GetTargetingStatsResult> GetTargetingStatsAsync(GetTargetingStatsParams getTargetingStatsParams,
																	CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetTargetingStats(getTargetingStatsParams));
		}

		/// <inheritdoc/>
		public Task<Uri> GetUploadUrlAsync(GetUploadUrlParams getUploadUrlParams, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetUploadUrl(getUploadUrlParams));
		}

		/// <param name="token"></param>
		/// <inheritdoc/>
		public Task<Uri> GetVideoUploadUrlAsync(CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(GetVideoUploadUrl);
		}

		/// <inheritdoc/>
		public Task<long> ImportTargetContactsAsync(ImportTargetContactsParams importTargetContactsParams,
													CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => ImportTargetContacts(importTargetContactsParams));
		}

		/// <inheritdoc/>
		public Task<ReadOnlyCollection<bool>> RemoveOfficeUsersAsync(RemoveOfficeUsersParams removeOfficeUsersParams,
																	CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => RemoveOfficeUsers(removeOfficeUsersParams));
		}

		/// <inheritdoc/>
		public Task<RemoveTargetContactsResult> RemoveTargetContactsAsync(RemoveTargetContactsParams removeTargetContactsParams,
																		CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => RemoveTargetContacts(removeTargetContactsParams));
		}

		/// <inheritdoc/>
		public Task<SaveLookALikeRequestResultResult> SaveLookalikeRequestResultAsync(
			SaveLookalikeRequestResultParams saveLookalikeRequestResultParams, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => SaveLookalikeRequestResult(saveLookalikeRequestResultParams));
		}

		/// <inheritdoc/>
		public Task<ShareTargetGroupResult> ShareTargetGroupAsync(ShareTargetGroupParams shareTargetGroupParams,
																CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => ShareTargetGroup(shareTargetGroupParams));
		}

		/// <inheritdoc/>
		public Task<ReadOnlyCollection<UpdateAdsResult>> UpdateAdsAsync(
			AdsDataSpecificationParams<AdEditSpecification> adEditDataSpecification, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => UpdateAds(adEditDataSpecification));
		}

		/// <inheritdoc/>
		public Task<ReadOnlyCollection<UpdateCampaignsResult>> UpdateCampaignsAsync(
			AdsDataSpecificationParams<CampaignModSpecification> campaignModDataSpecification, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => UpdateCampaigns(campaignModDataSpecification));
		}

		/// <inheritdoc/>
		public Task<ReadOnlyCollection<UpdateClientsResult>> UpdateClientsAsync(
			AdsDataSpecificationParams<ClientModSpecification> clientModDataSpecification, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => UpdateClients(clientModDataSpecification));
		}

		/// <inheritdoc/>
		public Task<bool> UpdateTargetGroupAsync(UpdateTargetGroupParams updateTargetGroupParams, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => UpdateTargetGroup(updateTargetGroupParams));
		}

		/// <inheritdoc/>
		public Task<bool> UpdateTargetPixelAsync(UpdateTargetPixelParams updateTargetPixelParams, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => UpdateTargetPixel(updateTargetPixelParams));
		}
	}
}