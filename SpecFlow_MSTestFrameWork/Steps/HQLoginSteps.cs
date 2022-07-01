using Microsoft.Extensions.Configuration;
using SpecFlow_MSTestFrameWork.PageObjects;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecFlow_MSTestFrameWork.StepDefinitions
{
    [Binding]
    public class HQLoginSteps
    {
        private readonly DriverHelper _driverHelper;
        HQLoginPage hQLoginPage;

        public HQLoginSteps(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            hQLoginPage = new HQLoginPage(_driverHelper.driver);
        }

        [Given(@"user navigates to HQ application")]
        public void GivenUserNavigatesToHQApplication()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsetting.json").Build();
            var initialurl = config["hqappUrl"];
            _driverHelper.driver.Navigate().GoToUrl(initialurl);
        }
        
        [When(@"enter valid '(.*)', '(.*)'")]
        public void WhenEnterValid(string username, string hqpassword)
        {
            hQLoginPage.EnterCredentials(username, hqpassword);
        }
        
        [When(@"Clicks on Log In button")]
        public void WhenClicksOnLogInButton()
        {
            hQLoginPage.ClickBtnSignIn();
            Thread.Sleep(8000);
        }
        
        [Then(@"HQ homepage should be displayed")]
        public void ThenHQHomepageShouldBeDisplayed()
        {
            hQLoginPage.UserVerification();
        }
    }
}
