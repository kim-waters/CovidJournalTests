using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidTrackerTests.lib.pages
{
    public class CJ_RegisterPage
    {
        private IWebDriver _driver;
        private IWebElement _firstNameInput => _driver.FindElement(By.Id("Input_FirstName"));
        private IWebElement _lastNameInput => _driver.FindElement(By.Id("Input_LastName"));
        private IWebElement _emailInput => _driver.FindElement(By.Id("Input_Email"));

        private IWebElement _passwordInput => _driver.FindElement(By.Id("Input_Password"));
        private IWebElement _confirmPasswordInput => _driver.FindElement(By.Id("Input_ConfirmPassword"));

        private IWebElement _registerButton => _driver.FindElement(By.XPath("/html/body/div/main/div/div[1]/form/button"));
        private IWebElement _errorList => _driver.FindElement(By.XPath("/html/body/div/main/div/div[1]/form/div[1]/ul"));

        public CJ_RegisterPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void Navigate()
        {
            _driver.Navigate().GoToUrl("https://localhost:44340/Identity/Account/Register");
        }

        public void EnterFirstName()
        {
            _firstNameInput.SendKeys(RandomString(5));
        }

        public void EnterLastName()
        {
            _lastNameInput.SendKeys(RandomString(5));
        }

        public void EnterEmail()
        {
            _emailInput.SendKeys(RandomString(5)+"@mail.com");
        }

        public void EnterPassword(string password)
        {
            _passwordInput.SendKeys(password);
        }

        public void EnterPasswordConfirmation(string password)
        {

            _confirmPasswordInput.SendKeys(password);
        }

        public void ClickRegisterButton()
        {
            _registerButton.Click();
        }

        public string GetErrorMessages()
        {
            return _errorList.Text;
        }

        public static string RandomString(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

    }
}
