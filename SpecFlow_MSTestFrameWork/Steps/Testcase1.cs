using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using SpecFlow_MSTestFrameWork.PageObjects;
using TechTalk.SpecFlow;

namespace SpecFlow_MSTestFrameWork.StepDefinitions
{
    [Binding]
    public class Testcase1
    {
        private readonly DriverHelper _driverHelper;
        HomePage homePage;
        LoginPage loginPage;
        private IWebDriver driver;
        private string url;

        public Testcase1(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            homePage = new HomePage(_driverHelper.driver);
            loginPage = new LoginPage(_driverHelper.driver);
        }


        [Given(@"user navigates to Execute Automation Site")]
        public void GivenUserNavigatesToExecuteAutomationSite()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsetting.json").Build();
            var initialurl = config["appurl"];
             _driverHelper.driver.Navigate().GoToUrl(initialurl);
        }

        [Given(@"i see the application is opened")]
        public void GivenISeeTheApplicationIsOpened()
        {
            
        }

        [When(@"user clicks on link Sign")]
        public void WhenUserClicksOnLinkSign()
        {
            homePage.ClickSignIn();
        }

        [Then(@"SignIn page should be displayed")]
        public void ThenSignInPageShouldBeDisplayed()
        {
            
        }

        [When(@"user enters '([^']*)', '([^']*)'")]
        public void WhenUserEnters(string emailId, string Password)
        {


            homePage.EnterEmailId(emailId, Password);
        }

        [When(@"Clicks on button SignIn")]
        public void WhenClicksOnButtonSignIn()
        {
            homePage.ClickBtnSignIn();
            System.Threading.Thread.Sleep(5000);
        }

        [Then(@"Landing Page should be displayed")]
        public void ThenLandingPageShouldBeDisplayed()
        {
            
        }


    }
}
