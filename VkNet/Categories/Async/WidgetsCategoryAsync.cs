using System.Threading;
using System.Threading.Tasks;
using VkNet.Model;
using VkNet.Model.RequestParams;
using VkNet.Model.RequestParams.Widgets;
using VkNet.Utils;

namespace VkNet.Categories
{
	/// <inheritdoc />
	public partial class WidgetsCategory
	{
		/// <inheritdoc />
		public Task<VkCollection<Comment>> GetCommentsAsync(GetCommentsParams getCommentsParams, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetComments(getCommentsParams: getCommentsParams), token);
		}

		/// <inheritdoc />
		public Task<VkCollection<WidgetPage>> GetPagesAsync(long? widgetApiId = null, string order = null, string period = null,
															ulong? offset = null, ulong? count = null, CancellationToken token = default)
		{
			return TypeHelper.TryInvokeMethodAsync(() => GetPages(widgetApiId, order, period, offset, count), token);
		}
	}
}