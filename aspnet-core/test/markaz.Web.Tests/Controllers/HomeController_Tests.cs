using System.Threading.Tasks;
using markaz.Models.TokenAuth;
using markaz.Web.Controllers;
using Shouldly;
using Xunit;

namespace markaz.Web.Tests.Controllers
{
    public class HomeController_Tests: markazWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}