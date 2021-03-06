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
        private IWebElement _logOutLink => _driver.FindElement(By.XPath("/html/body/header/nav/div/div/ul[2]/li[2]/form/button"));
        private IWebElement _usernameField => _driver.FindElement(By.XPath("/html/body/div/main/div/div[1]/section/form/div[2]/input"));
        private IWebElement _passwordField => _driver.FindElement(By.XPath("/html/body/div/main/div/div[1]/section/form/div[3]/input"));
        private IWebElement _usernameAlert => _driver.FindElement(By.XPath("/html/body/div/main/div/div[1]/section/form/div[1]/ul/li"));
        private IWebElement _invalidLoginAlert => _driver.FindElement(By.XPath("/html/body/div/main/div/div[1]/section/form/div[1]/ul/li"));
        private IWebElement _registerLinkWhenLoggedOut => _driver.FindElement(By.XPath("/html/body/header/nav/div/div/ul[2]/li[1]/a"));

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

        public void ClickLogOutLink()
        {
            _logOutLink.Click();
        }

        public void EnterUsername(string username)
        {
            _usernameField.SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            _passwordField.SendKeys(password);
        }
        public string GetUsernameAlert()
        {
            return _usernameAlert.Text;
        }

        public string GetInvalidLoginAlert()
        {
            return _invalidLoginAlert.Text;
        }

        public string GetRegisterLinkWhenLoggedOut()
        {
            return _registerLinkWhenLoggedOut.Text;
        }

        public string GetPageTitle()
        {
            return _driver.Title;
        }

    }
}

