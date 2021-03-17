using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidTrackerTests.lib.pages
{
    public class CJ_HomePage
    {
        private IWebDriver _driver;
        private IWebElement _signInLink => _driver.FindElement(By.XPath("/html/body/header/nav/div/div/ul[2]/li[2]/a"));
        private IWebElement _registerLink => _driver.FindElement(By.XPath("/html/body/header/nav/div/div/ul[2]/li[1]/a"));
        private IWebElement _entryLink => _driver.FindElement(By.XPath("/html/body/header/nav/div/div/ul[1]/li/a"));

        public CJ_HomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void Navigate()
        {
            _driver.Navigate().GoToUrl("https://localhost:44340/");
        }

        public void ClickSignInLink()
        {
            _signInLink.Click();
        }

        public void ClickRegisterLink()
        {
            _registerLink.Click();
        }

        public void ClickEntryLink()
        {
            _entryLink.Click();
        }

    }
}
