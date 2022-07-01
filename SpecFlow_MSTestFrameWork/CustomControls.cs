using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlow_MSTestFrameWork
{
    public class CustomControls : DriverHelper
    {

        public void EnterText(IWebElement webElement, string value) => webElement.SendKeys(value);

        public void Click(IWebElement webElement) => webElement.Click();

        public void SelectByValue(IWebElement webElement, string value)
        {
            SelectElement selectElement = new SelectElement(webElement);
            selectElement.SelectByValue(value);
        }

        public void SelectByText(IWebElement webElement, string text)
        {
            SelectElement selectElement = new SelectElement(webElement);
            selectElement.SelectByText(text);
        }

        public void FindByXpath(IWebElement webElement, string element)
        {

        }

        public void SelectByOption(IWebElement webElement, string text)
        {
            SelectElement selectElement = new SelectElement(webElement);
            //  selectElement.SelectByOption(text);
        }



    }
}

