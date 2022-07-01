using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace SpecFlow_MSTestFrameWork.PageObjects
{
    class HomePage
    {
        private IWebDriver Driver;
        public HomePage(IWebDriver driver)
        {
            Driver = driver;
        }

        IWebElement LinkSignIn => Driver.FindElement(By.XPath("//*[@class='ct-header-content']/ul/li[3]"));
        IWebElement EmailId => Driver.FindElement(By.XPath("//*[@id='email']"));

        IWebElement Txtpassword => Driver.FindElement(By.XPath("//*[@id='password']"));

        IWebElement BtnSignIn => Driver.FindElement(By.XPath("//div[@class='form-group text-center']//button"));
        IWebElement Searchbar => Driver.FindElement(By.XPath("//input[@placeholder='Search learning paths and courses']"));
        IWebElement Searchbutton => Driver.FindElement(By.XPath("Testing Failed Test Screenshots"));
      //  IWebElement Searchbutton => Driver.FindElement(By.XPath("(//span[@class='input-group-text'])[1]"));

        //Actions
        public void ClickSignIn() => LinkSignIn.Click();
        public void EnterEmailId(string emailId, string password)
        {
            var configBuilder = new ConfigurationBuilder().AddJsonFile("appsetting.json");
            IConfiguration config = configBuilder.Build();
            EmailId.SendKeys(config["email"]);
            Txtpassword.SendKeys(config["password"]);
        }

        public void ClickBtnSignIn() => BtnSignIn.Click();

        public void Search()
        {
            var configBuilder = new ConfigurationBuilder().AddJsonFile("TestData.json");
            IConfiguration config = configBuilder.Build();
            Searchbar.SendKeys(config["searchData"]);
        }
        public void ClickSearchbutton() => Searchbutton.Click();

        

    }
}
