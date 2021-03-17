using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CovidTrackerTests.lib.driver_config;
using OpenQA.Selenium;

namespace CovidTrackerTests.lib.pages
{
    public class CJ_Website
    {

        public IWebDriver Driver { get; set; }
        public CJ_HomePage CJ_HomePage { get; internal set; }

        public CJ_Website(string driver, int pageLoadInSecs = 10, int implicitWaitInSecs = 10)
        {
            Driver = new SeleniumDriverConfig(driver, pageLoadInSecs, implicitWaitInSecs).Driver;
            CJ_HomePage = new CJ_HomePage(Driver);
        }

        public void DeleteCookies()
        {
            Driver.Manage().Cookies.DeleteAllCookies();
        }

        public string GetPageTitle()
        {
            return Driver.Title;
        }

        public string GetPageUrl()
        {
            return Driver.Url;
        }
    }
}
