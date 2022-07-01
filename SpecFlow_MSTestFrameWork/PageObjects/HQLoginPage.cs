using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace SpecFlow_MSTestFrameWork.PageObjects
{
    class HQLoginPage
    {
        private IWebDriver Driver;
        public HQLoginPage(IWebDriver driver)
        {
            Driver = driver;
        }
        IWebElement Username => Driver.FindElement(By.XPath("//input[@id='userNameText']"));
        IWebElement Password => Driver.FindElement(By.XPath("//input[@name='password']"));
        IWebElement LogIn => Driver.FindElement(By.XPath("//span[text()='Log In']"));
        IWebElement ProfileIcon => Driver.FindElement(By.XPath("//button[@class='dropdown-toggle']"));
       // IWebElement ProfileName1 => Driver.FindElement(By.XPath("//span[text()='AutUser1 AutUser1']"));
        IWebElement ProfileName2 => Driver.FindElement(By.XPath("//span[text()='AutUser2 AutUser2']"));

        public void EnterURL()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsetting.json").Build();
            var initialurl = config["hqappUrl"];
            Driver.Navigate().GoToUrl(initialurl);
        }
        public void EnterCredentials(string username, string hqpassword)
        {
            var configBuilder = new ConfigurationBuilder().AddJsonFile("appsetting.json");
            IConfiguration config = configBuilder.Build();
            Username.Click();
            Username.SendKeys(config["username"]);
            Password.SendKeys(config["hqpassword"]);
        }

        public void ClickBtnSignIn() => LogIn.Click();

        public void UserVerification()
        {
            ProfileIcon.Click();
            ProfileName2.Click();
            //Debug.Assert(ProfileName2 = AutUser2 AutUser2, "Test Failed");
        }
    }


}
