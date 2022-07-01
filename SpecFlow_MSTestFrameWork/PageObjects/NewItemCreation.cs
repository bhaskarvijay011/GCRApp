using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace SpecFlow_MSTestFrameWork.PageObjects
{
    public class NewItemCreation
    {

        private IWebDriver Driver;
        public NewItemCreation(IWebDriver driver)
        {
            Driver = driver;
        }

        IWebElement SideMenu => Driver.FindElement(By.XPath("//div[@class='SideMenuWrapper SideMenuWrapperSmall']"));
        IWebElement Searchbar => Driver.FindElement(By.XPath("//input[@id='search-text']"));
        IWebElement ElementClick => Driver.FindElement(By.XPath("//span/strong[text()='Item Maintenance in HQ mode']"));
        IWebElement NewItembutton => Driver.FindElement(By.XPath("(//span[text()='New'])[1]"));
        IWebElement EnterBarcode => Driver.FindElement(By.XPath("//input[@name='barcode']"));
        IWebElement EnterItemDescription => Driver.FindElement(By.XPath("//input[@name='itemDescription']"));
        IWebElement EnterDropDown => Driver.FindElement(By.XPath("(//div[@class='selectize-input items not-full ng-valid ng-pristine has-options'])[1]"));
        IWebElement EnterDropDown1 => Driver.FindElement(By.XPath("(//div[@class='selectize-input items not-full ng-valid ng-pristine'])[3]"));

        public By TexBoxLocator { get; private set; }

        // private string jsonFile = @"C:\Source\Specflow_MSTest FrameWork\SpecFlow_MSTestFrameWork\bin\Debug\netcoreapp3.1\TestData.json";

        public void SearchForKeyword()
        {
            SideMenu.Click();
            /*var json = File.ReadAllText("TestData.json");
            var jObject = JObject.Parse(json);
            var searchItem = jObject["item"];*/
            Searchbar.SendKeys("Item Maintenance in HQ mode");
            ElementClick.Click();
        }

        public void CreateNewItem()
        {
            Thread.Sleep(5000);
            NewItembutton.Click();
            Random rand = new Random();
            int number = rand.Next(0, 9999);
            EnterBarcode.SendKeys("1" + number);
            EnterItemDescription.SendKeys("Test" + number);
            EnterDropDown.Click();
            Actions keyDown = new Actions(Driver);
            keyDown.SendKeys(Keys.Enter).SendKeys(Keys.End).Build().Perform();
            keyDown.SendKeys(Keys.Escape).Build().Perform();
                     

        }

      
    }
}
