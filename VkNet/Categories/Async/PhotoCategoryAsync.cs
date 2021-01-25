using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;
using VkNet.Enums;
using VkNet.Model;
using VkNet.Model.Attachments;
using VkNet.Model.RequestParams;
using VkNet.Model.RequestParams.Photo;
using VkNet.Utils;

namespace VkNet.Categories
{
	/// <inheritdoc />
	public partial class PhotoCategory
	{
		/// <inheritdoc />
		public Task<PhotoAlbum> CreateAlbumAsync(PhotoCreateAlbumParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(func: () => CreateAlbum(@params: @params), token: token);
		}

		/// <inheritdoc />
		public Task<bool> EditAlbumAsync(PhotoEditAlbumParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(func: () => EditAlbum(@params: @params), token: token);
		}

		/// <inheritdoc />
		public Task<VkCollection<PhotoAlbum>> GetAlbumsAsync(PhotoGetAlbumsParams @params, bool skipAuthorization = false,
															CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(func: () => GetAlbums(@params, skipAuthorization), token: token);
		}

		/// <inheritdoc />
		public Task<VkCollection<Photo>> GetAsync(PhotoGetParams @params, bool skipAuthorization = false, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(func: () => Get(@params, skipAuthorization), token: token);
		}

		/// <inheritdoc />
		public Task<int> GetAlbumsCountAsync(long? userId = null, long? groupId = null, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(func: () => GetAlbumsCount(userId, groupId), token: token);
		}

		/// <inheritdoc />
		public Task<ReadOnlyCollection<Photo>> GetByIdAsync(IEnumerable<string> photos, bool? extended = null, bool? photoSizes = null,
															bool skipAuthorization = false, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(func: () => GetById(photos, extended, photoSizes, skipAuthorization), token: token);
		}

		/// <inheritdoc />
		public Task<UploadServerInfo> GetUploadServerAsync(long albumId, long? groupId = null, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(func: () => GetUploadServer(albumId, groupId), token: token);
		}

		/// <inheritdoc />
		public Task<UploadServerInfo> GetOwnerPhotoUploadServerAsync(long? ownerId = null, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(func: () => GetOwnerPhotoUploadServer(ownerId: ownerId), token: token);
		}

		/// <inheritdoc />
		public Task<UploadServerInfo> GetChatUploadServerAsync(ulong chatId, ulong? cropX = null, ulong? cropY = null,
																ulong? cropWidth = null, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(func: () => GetChatUploadServer(chatId, cropX, cropY, cropWidth), token: token);
		}

		/// <inheritdoc />
		public Task<Photo> SaveOwnerPhotoAsync(string response, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(func: () => SaveOwnerPhoto(response), token: token);
		}

		/// <inheritdoc />
		public Task<ReadOnlyCollection<Photo>> SaveWallPhotoAsync(string response, ulong? userId, ulong? groupId = null,
																string caption = null, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => SaveWallPhoto(response, userId, groupId, caption), token);
		}

		/// <inheritdoc />
		public Task<UploadServerInfo> GetWallUploadServerAsync(long? groupId = null, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetWallUploadServer(groupId: groupId), token);
		}

		/// <inheritdoc />
		public Task<UploadServerInfo> GetMessagesUploadServerAsync(long peerId, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetMessagesUploadServer(peerId: peerId), token);
		}

		/// <inheritdoc />
		public Task<ReadOnlyCollection<Photo>> SaveMessagesPhotoAsync(string response, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => SaveMessagesPhoto(response: response), token);
		}

		/// <inheritdoc />
		public Task<UploadServerInfo> GetOwnerCoverPhotoUploadServerAsync(long groupId, long? cropX = null, long? cropY = null,
																		long? cropX2 = 795L, long? cropY2 = 200L,
																		CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetOwnerCoverPhotoUploadServer(groupId, cropX, cropY, cropX2, cropY2), token);
		}

		/// <inheritdoc />
		public Task<GroupCover> SaveOwnerCoverPhotoAsync(string response, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => SaveOwnerCoverPhoto(response: response), token);
		}

		/// <inheritdoc />
		public Task<bool> ReportAsync(long ownerId, ulong photoId, ReportReason reason, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => Report(ownerId, photoId, reason), token);
		}

		/// <inheritdoc />
		public Task<bool> ReportCommentAsync(long ownerId, ulong commentId, ReportReason reason, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => ReportComment(ownerId, commentId, reason), token);
		}

		/// <inheritdoc />
		public Task<VkCollection<Photo>> SearchAsync(PhotoSearchParams @params, bool skipAuthorization = false,
													CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => Search(@params, skipAuthorization), token);
		}

		/// <inheritdoc />
		public Task<ReadOnlyCollection<Photo>> SaveAsync(PhotoSaveParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => Save(@params: @params), token);
		}

		/// <inheritdoc />
		public Task<long> CopyAsync(long ownerId, ulong photoId, string accessKey = null, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => Copy(ownerId, photoId, accessKey), token);
		}

		/// <inheritdoc />
		public Task<bool> EditAsync(PhotoEditParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => Edit(@params: @params), token);
		}

		/// <inheritdoc />
		public Task<bool> MoveAsync(long targetAlbumId, ulong photoId, long? ownerId = null, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => Move(targetAlbumId, photoId, ownerId), token);
		}

		/// <inheritdoc />
		public Task<bool> MakeCoverAsync(ulong photoId, long? ownerId = null, long? albumId = null, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => MakeCover(photoId, ownerId, albumId), token);
		}

		/// <inheritdoc />
		public Task<bool> ReorderAlbumsAsync(long albumId, long? ownerId = null, long? before = null, long? after = null,
											CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => ReorderAlbums(albumId, ownerId, before, after), token);
		}

		/// <inheritdoc />
		public Task<bool> ReorderPhotosAsync(ulong photoId, long? ownerId = null, long? before = null, long? after = null,
											CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => ReorderPhotos(photoId, ownerId, before, after), token);
		}

		/// <inheritdoc />
		public Task<VkCollection<Photo>> GetAllAsync(PhotoGetAllParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetAll(@params: @params), token);
		}

		/// <inheritdoc />
		public Task<VkCollection<Photo>> GetUserPhotosAsync(PhotoGetUserPhotosParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetUserPhotos(@params: @params), token);
		}

		/// <inheritdoc />
		public Task<bool> DeleteAlbumAsync(long albumId, long? groupId = null, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => DeleteAlbum(albumId, groupId), token);
		}

		/// <inheritdoc />
		public Task<bool> DeleteAsync(ulong photoId, long? ownerId = null, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => Delete(photoId, ownerId), token);
		}

		/// <inheritdoc />
		public Task<bool> RestoreAsync(ulong photoId, long? ownerId = null, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => Restore(photoId, ownerId), token);
		}

		/// <inheritdoc />
		public Task<bool> ConfirmTagAsync(ulong photoId, ulong tagId, long? ownerId = null, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => ConfirmTag(photoId, tagId, ownerId), token);
		}

		/// <inheritdoc />
		public Task<VkCollection<Comment>> GetCommentsAsync(PhotoGetCommentsParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetComments(@params: @params), token);
		}

		/// <inheritdoc />
		public Task<VkCollection<Comment>> GetAllCommentsAsync(PhotoGetAllCommentsParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetAllComments(@params: @params), token);
		}

		/// <inheritdoc />
		public Task<long> CreateCommentAsync(PhotoCreateCommentParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => CreateComment(@params: @params), token);
		}

		/// <inheritdoc />
		public Task<bool> DeleteCommentAsync(ulong commentId, long? ownerId = null, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => DeleteComment(commentId, ownerId), token);
		}

		/// <inheritdoc />
		public Task<long> RestoreCommentAsync(ulong commentId, long? ownerId = null, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => RestoreComment(commentId, ownerId), token);
		}

		/// <inheritdoc />
		public Task<bool> EditCommentAsync(ulong commentId, string message, long? ownerId = null,
											IEnumerable<MediaAttachment> attachments = null, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => EditComment(commentId, message, ownerId, attachments), token);
		}

		/// <inheritdoc />
		public Task<ReadOnlyCollection<Tag>> GetTagsAsync(ulong photoId, long? ownerId = null, string accessKey = null,
														CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetTags(photoId, ownerId, accessKey), token);
		}

		/// <inheritdoc />
		public Task<ulong> PutTagAsync(PhotoPutTagParams @params, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => PutTag(@params: @params), token);
		}

		/// <inheritdoc />
		public Task<bool> RemoveTagAsync(ulong tagId, ulong photoId, long? ownerId = null, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => RemoveTag(tagId, photoId, ownerId), token);
		}

		/// <inheritdoc />
		public Task<VkCollection<Photo>> GetNewTagsAsync(uint? offset = null, uint? count = null, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetNewTags(offset, count), token);
		}

		/// <inheritdoc />
		public Task<UploadServerInfo> GetMarketUploadServerAsync(long groupId, bool? mainPhoto = null, long? cropX = null,
																long? cropY = null, long? cropWidth = null,
																CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetMarketUploadServer(groupId, mainPhoto, cropX, cropY, cropWidth), token);
		}

		/// <inheritdoc />
		public Task<UploadServerInfo> GetMarketAlbumUploadServerAsync(long groupId, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetMarketAlbumUploadServer(groupId: groupId), token);
		}

		/// <inheritdoc />
		public Task<ReadOnlyCollection<Photo>> SaveMarketPhotoAsync(long groupId, string response, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => SaveMarketPhoto(groupId, response), token);
		}

		/// <inheritdoc />
		public Task<ReadOnlyCollection<Photo>> SaveMarketAlbumPhotoAsync(long groupId, string response, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => SaveMarketAlbumPhoto(groupId, response), token);
		}
	}
}