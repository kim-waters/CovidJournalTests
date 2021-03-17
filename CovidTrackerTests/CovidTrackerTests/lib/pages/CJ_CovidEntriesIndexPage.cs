using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidTrackerTests.lib.pages
{
    public class CJ_CovidEntriesIndexPage
    {
        private IWebDriver _driver;
        private IWebElement _createNewEntryLink => _driver.FindElement(By.XPath("/html/body/div/main/p/a"));
        public CJ_CovidEntriesIndexPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void Navigate()
        {
            _driver.Navigate().GoToUrl("https://localhost:44340/CovidEntries");
        }

        
        public string GetPageTitle()
        {
            return _driver.Title;
        }

        public void ClickNewEntryButton()
        {
            _createNewEntryLink.Click();
        }
    }
}


