using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidTrackerTests.lib.pages
{
    public class CJ_LoginPage
    {
        private IWebDriver _driver;
        private IWebElement _logInLink => _driver.FindElement(By.XPath("/html/body/div/main/div/div[1]/section/form/div[5]/button"));
        private IWebElement _usernameField => _driver.FindElement(By.XPath("/html/body/div/main/div/div[1]/section/form/div[2]/input"));
        private IWebElement _passwordField => _driver.FindElement(By.XPath("/html/body/div/main/div/div[1]/section/form/div[3]/input"));

        public CJ_LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void Navigate()
        {
            _driver.Navigate().GoToUrl("https://localhost:44340/Identity/Account/Login");
        }

        public void ClickLogInLink()
        {
            _logInLink.Click();
        }

        public void EnterUsername(string username)
        {
            _usernameField.SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            _usernameField.SendKeys(password);
        }

    }
}

