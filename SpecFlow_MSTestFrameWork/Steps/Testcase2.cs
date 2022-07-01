using Microsoft.Extensions.Configuration;
using SpecFlow_MSTestFrameWork.PageObjects;
using TechTalk.SpecFlow;

namespace SpecFlow_MSTestFrameWork.StepDefinitions
{
    [Binding]
    public class Testcase2
    {
        private readonly DriverHelper _driverHelper;
        HomePage homePage;

        public Testcase2(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            homePage = new HomePage(_driverHelper.driver);
        }

        [Given(@"that I have gone to the Home page of application")]
        public void GivenThatIHaveGoneToTheHomePageOfApplication()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsetting.json").Build();
            var initialurl = config["appurl"];
            _driverHelper.driver.Navigate().GoToUrl(initialurl);
        }
        
        [When(@"I add ""(.*)"" to the search box")]
        public void WhenIAddToTheSearchBox(string p0)
        {
            homePage.Search();
        }
        
        [When(@"click the Search Button")]
        public void WhenClickTheSearchButton()
        {
            homePage.ClickSearchbutton();
        }
        
        [Then(@"""(.*)"" should be mentioned in the results")]
        public void ThenShouldBeMentionedInTheResults(string p0)
        {
           
        }
    }
}
