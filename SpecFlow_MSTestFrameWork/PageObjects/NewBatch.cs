using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SpecFlow_MSTestFrameWork.PageObjects
{
    public class NewBatch
    {

        private IWebDriver Driver;
        public NewBatch(IWebDriver driver)
        {
            Driver = driver;
        }

        IWebElement BatchLink => Driver.FindElement(By.XPath("//div [@class='app-l-item-batch__right']"));
        IWebElement NewBatchButton => Driver.FindElement(By.XPath("/html/body/div[1]/div/span/div[2]/batch-details/form/div/div[2]/div[1]/div[3]/div/button"));
        IWebElement NewBatchName => Driver.FindElement(By.XPath("//input [@name='batch']"));
        IWebElement NewBatchSave => Driver.FindElement(By.XPath("//button [@class='button-save']"));



        public void CreateBatch()
        {
            BatchLink.Click();
            Thread.Sleep(3000);
            NewBatchButton.Click();
            NewBatchName.SendKeys("TestBatch_1");
            NewBatchSave.Click();
        }
        

    }
}
