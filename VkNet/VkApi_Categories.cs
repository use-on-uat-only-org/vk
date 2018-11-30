using VkNet.Abstractions;
using VkNet.Abstractions.Category;
using VkNet.Categories;

namespace VkNet
{
	public partial class VkApi
	{
		/// <inheritdoc />
		public IUsersCategory Users { get; private set; }

		/// <inheritdoc />
		public IFriendsCategory Friends { get; private set; }

		/// <inheritdoc />
		public IStatusCategory Status { get; private set; }

		/// <inheritdoc />
		public IMessagesCategory Messages { get; private set; }

		/// <inheritdoc />
		public IGroupsCategory Groups { get; private set; }

		/// <inheritdoc />
		public IAudioCategory Audio { get; private set; }

		/// <inheritdoc />
		public IDatabaseCategory Database { get; private set; }

		/// <inheritdoc />
		public IUtilsCategory Utils { get; private set; }

		/// <inheritdoc />
		public IWallCategory Wall { get; private set; }

		/// <inheritdoc />
		public IBoardCategory Board { get; private set; }

		/// <inheritdoc />
		public IFaveCategory Fave { get; private set; }

		/// <inheritdoc />
		public IVideoCategory Video { get; private set; }

		/// <inheritdoc />
		public IAccountCategory Account { get; private set; }

		/// <inheritdoc />
		public IPhotoCategory Photo { get; private set; }

		/// <inheritdoc />
		public IDocsCategory Docs { get; private set; }

		/// <inheritdoc />
		public ILikesCategory Likes { get; private set; }

		/// <inheritdoc />
		public IPagesCategory Pages { get; private set; }

		/// <inheritdoc />
		public IAppsCategory Apps { get; private set; }

		/// <inheritdoc />
		public INewsFeedCategory NewsFeed { get; private set; }

		/// <inheritdoc />
		public IStatsCategory Stats { get; private set; }

		/// <inheritdoc />
		public IGiftsCategory Gifts { get; private set; }

		/// <inheritdoc />
		public IMarketsCategory Markets { get; private set; }

		/// <inheritdoc />
		public IAuthCategory Auth { get; private set; }

		/// <inheritdoc />
		public IExecuteCategory Execute { get; private set; }

		/// <inheritdoc />
		public IPollsCategory PollsCategory { get; private set; }

		/// <inheritdoc />
		public ISearchCategory Search { get; private set; }

		/// <inheritdoc />
		public IStorageCategory Storage { get; set; }

		/// <inheritdoc />
		public IAdsCategory Ads { get; private set; }

		/// <inheritdoc />
		public INotificationsCategory Notifications { get; set; }

		/// <inheritdoc />
		public IWidgetsCategory Widgets { get; set; }

		/// <inheritdoc />
		public ILeadsCategory Leads { get; set; }

		/// <inheritdoc />
		public IStreamingCategory Streaming { get; set; }

		/// <inheritdoc />
		public IPlacesCategory Places { get; set; }

		///<inheritdoc />
		public INotesCategory Notes { get; set; }

		/// <inheritdoc />
		public IAppWidgetsCategory AppWidgets { get; set; }

		/// <inheritdoc />
		public IOrdersCategory Orders { get; set; }

		/// <inheritdoc />
		public ISecureCategory Secure { get; set; }

		/// <inheritdoc />
		public IStoriesCategory Stories { get; set; }

		/// <inheritdoc />
		public ILeadFormsCategory LeadForms { get; set; }

		private void SetCategories()
		{
			Users = new UsersCategory(this);
			Friends = new FriendsCategory(this);
			Status = new StatusCategory(this);
			Messages = new MessagesCategory(this);
			Groups = new GroupsCategory(this);
			Audio = new AudioCategory(this);
			Wall = new WallCategory(this);
			Board = new BoardCategory(this);
			Database = new DatabaseCategory(this);
			Utils = new UtilsCategory(this);
			Fave = new FaveCategory(this);
			Video = new VideoCategory(this);
			Account = new AccountCategory(this);
			Photo = new PhotoCategory(this);
			Docs = new DocsCategory(this);
			Likes = new LikesCategory(this);
			Pages = new PagesCategory(this);
			Gifts = new GiftsCategory(this);
			Apps = new AppsCategory(this);
			NewsFeed = new NewsFeedCategory(this);
			Stats = new StatsCategory(this);
			Auth = new AuthCategory(this);
			Markets = new MarketsCategory(this);
			Execute = new ExecuteCategory(this);
			PollsCategory = new PollsCategory(this);
			Search = new SearchCategory(this);
			Ads = new AdsCategory(this);
			Storage = new StorageCategory(this);
			Notifications = new NotificationsCategory(this);
			Widgets = new WidgetsCategory(this);
			Leads = new LeadsCategory(this);
			Streaming = new StreamingCategory(this);
			Places = new PlacesCategory(this);
			Notes = new NotesCategory(this);
			AppWidgets = new AppWidgetsCategory(this);
			Orders = new OrdersCategory(this);
			Secure = new SecureCategory(this);
			Stories = new StoriesCategory(this);
			LeadForms = new LeadFormsCategory(this);
		}
	}
}
