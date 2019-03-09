using System;
using System.Text;
using System.Threading.Tasks;
using Flurl;
using Moq;
using Moq.AutoMock;
using NUnit.Framework;
using VkNet.Abstractions.Core;
using VkNet.Enums;
using VkNet.Enums.Filters;
using VkNet.Enums.SafetyEnums;
using VkNet.Exception;
using VkNet.Infrastructure.Authorization;
using VkNet.Infrastructure.Authorization.ImplicitFlow;
using VkNet.Model;
using VkNet.Utils;

namespace VkNet.Tests.Infrastructure
{
	[TestFixture]
	public class ImplicitFlowTests
	{
		[Test]
		public void CreateAuthorizeUrl()
		{
			const int clientId = 4268118;
			var scope = Settings.All|Settings.Offline;
			const string state = "123";
			var display = Display.Mobile;
			var builder = new StringBuilder("https://oauth.vk.com/authorize?");

			builder.Append($"client_id={clientId}&");
			builder.Append("redirect_uri=https://oauth.vk.com/blank.html&");

			builder.Append($"display={display}&");
			builder.Append($"scope={scope.ToUInt64()}&");
			builder.Append("response_type=token&");
			builder.Append("v=5.92&");

			builder.Append($"state={state}&");
			builder.Append("revoke=1");

			var expected = builder.ToString();
			var mocker = new AutoMocker();
			mocker.Setup<IVkApiVersionManager, string>(x => x.Version).Returns("5.92");

			var implicitFlow = mocker.CreateInstance<ImplicitFlow>();

			var authorizeUrl = implicitFlow.CreateAuthorizeUrl(clientId, scope.ToUInt64(), display, state);

			Assert.AreEqual(new Url(expected), authorizeUrl);
		}

		[Test]
		public async Task Authorize()
		{
			var mocker = new AutoMocker();

			mocker.Setup<IApiAuthParams, string>(x => x.Login).Returns("login");
			mocker.Setup<IApiAuthParams, string>(x => x.Password).Returns("pass");
			mocker.Setup<IApiAuthParams, ulong>(x => x.ApplicationId).Returns(4268118);
			mocker.Setup<IApiAuthParams, Settings>(x => x.Settings).Returns(Settings.All);

			mocker.Setup<IVkApiVersionManager, string>(x => x.Version).Returns("5.92");

			mocker.Setup<IAuthorizationForm, Task<AuthorizationFormResult>>(x => x.ExecuteAsync(It.IsAny<Url>()))
				.ReturnsAsync(new AuthorizationFormResult
				{
					ResponseUrl = "https://m.vk.com/login?act=authcheck&m=442",
					RequestUrl = "https://m.vk.com/login?act=authcheck&m=442",
					Cookies = new Cookies()
				});

			mocker.Setup<IAuthorizationFormFactory, IAuthorizationForm>(x => x.Create(It.IsAny<ImplicitFlowPageType>()))
				.Returns(mocker.Get<IAuthorizationForm>());

			mocker.GetMock<IVkAuthorization<ImplicitFlowPageType>>()
				.SetupSequence(x => x.GetPageType(It.IsAny<Uri>()))
				.Returns(ImplicitFlowPageType.LoginPassword)
				.Returns(ImplicitFlowPageType.TwoFactor)
				.Returns(ImplicitFlowPageType.Consent)
				.Returns(ImplicitFlowPageType.Result);

			mocker.GetMock<IVkAuthorization<ImplicitFlowPageType>>()
				.Setup(x => x.GetAuthorizationResult(It.IsAny<Uri>()))
				.Returns(new AuthorizationResult
				{
					AccessToken = "access_token",
					UserId = 123,
					ExpiresIn = 0,
					State = "123"
				});

			var implicitFlow = mocker.CreateInstance<ImplicitFlow>();
			var result = await implicitFlow.AuthorizeAsync().ConfigureAwait(false);

			Assert.NotNull(result);
		}

		[Test]
		public async Task Authorize_ValidateError()
		{
			var mocker = new AutoMocker();

			mocker.Setup<IApiAuthParams, string>(x => x.Login).Returns("login");

			mocker.Setup<IVkApiVersionManager, string>(x => x.Version).Returns("5.92");

			var implicitFlow = mocker.CreateInstance<ImplicitFlow>();
			Assert.ThrowsAsync<VkAuthorizationException>(() => implicitFlow.AuthorizeAsync());
		}
	}
}