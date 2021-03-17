using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidTrackerTests.lib.pages
{
    public class CJ_CovidEntriesCreateNewPage
    {
        private IWebDriver _driver;
        private IWebElement _datePicker => _driver.FindElement(By.XPath("/html/body/div/main/div[1]/div/form/div[1]/input"));
        private IWebElement _temperatureField => _driver.FindElement(By.XPath("/html/body/div/main/div[1]/div/form/div[2]/input"));
        private IWebElement _noteField => _driver.FindElement(By.XPath("/html/body/div/main/div[1]/div/form/div[3]/input"));
        private IWebElement _moodyField => _driver.FindElement(By.XPath("/html/body/div/main/div[1]/div/form/div[4]/input"));
        private IWebElement _headacheBox => _driver.FindElement(By.XPath("/html/body/div/main/div[1]/div/form/div[5]/label/input"));
        private IWebElement _fatigueBox => _driver.FindElement(By.XPath("/html/body/div/main/div[1]/div/form/div[12]/label/input"));
        private IWebElement _createButton => _driver.FindElement(By.XPath("/html/body/div/main/div[1]/div/form/div[18]/input"));
        private IWebElement _backToListLink => _driver.FindElement(By.XPath("/html/body/div/main/div[2]/a"));
        public CJ_CovidEntriesCreateNewPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void Navigate()
        {
            _driver.Navigate().GoToUrl("https://localhost:44340/CovidEntries/Create");
        }
        public void EnterDate(string date)
        {
            _datePicker.SendKeys(date);
        }
        public void EnterTemperature(string temp)
        {
            _temperatureField.SendKeys(temp);
        }
        public void EnterNote(string note)
        {
            _noteField.SendKeys(note);
        }
        public void EnterMood(string mood)
        {
            _moodyField.SendKeys(mood);
        }
        public void TickHeadacheBox()
        {
            _headacheBox.Click();
        }
        public void TickFatigueBox()
        {
            _fatigueBox.Click();
        }
        public void ClickCreateEntryButton()
        {
            _createButton.Click();
        }

        public string GetDateValidation()
        {
            return "";
        }
    }
}


