using Microsoft.Extensions.Configuration;
using SpecFlow_MSTestFrameWork.PageObjects;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecFlow_MSTestFrameWork.Steps
{
    [Binding]
    public class NewItemCreationSteps
    {
        private readonly DriverHelper _driverHelper;
        NewItemCreation newItemCreation;
        HQLoginPage hQLoginPage;
        NewBatch newBatch;

        public NewItemCreationSteps(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            newItemCreation = new NewItemCreation(_driverHelper.driver);
            hQLoginPage = new HQLoginPage(_driverHelper.driver);
            newBatch = new NewBatch(_driverHelper.driver);
        }

        [Given(@"user enters the credentials and navigate to landing page '(.*)', '(.*)'")]
        public void GivenUserEntersTheCredentialsAndNavigateToLandingPage(string username, string hqpassword)
        {
            hQLoginPage.EnterURL();
            hQLoginPage.EnterCredentials(username, hqpassword);
            hQLoginPage.ClickBtnSignIn();
            Thread.Sleep(8000);
        }

        [When(@"user click side menu and select the item\.")]
        public void WhenUserClickSideMenuAndSelectTheItem_()
        {
            newItemCreation.SearchForKeyword();
        }

        [When(@"user create a new batch")]
        public void WhenUserCreateANewBatch()
        {
            newBatch.CreateBatch();
        }
        
        [When(@"then creates a new item")]
        public void WhenThenCreatesANewItem()
        {
            newItemCreation.CreateNewItem();
        }
        
        [Then(@"confirm the item in thw batch file")]
        public void ThenConfirmTheItemInThwBatchFile()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"publish the batch")]
        public void ThenPublishTheBatch()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
