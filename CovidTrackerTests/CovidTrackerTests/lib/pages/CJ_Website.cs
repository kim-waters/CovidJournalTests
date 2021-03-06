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

        public CJ_RegisterPage CJ_RegisterPage { get; internal set; }

        public CJ_LoginPage CJ_LoginPage { get; internal set; }

        public CJ_CovidEntriesIndexPage CJ_CovidEntriesIndexPage { get; internal set; }
        public CJ_CovidEntriesCreateNewPage CJ_CovidEntriesCreateNewPage { get; internal set; }


        public CJ_Website(string driver, int pageLoadInSecs = 10, int implicitWaitInSecs = 10)
        {
            Driver = new SeleniumDriverConfig(driver, pageLoadInSecs, implicitWaitInSecs).Driver;
            CJ_HomePage = new CJ_HomePage(Driver);

            CJ_RegisterPage = new CJ_RegisterPage(Driver);

            CJ_LoginPage = new CJ_LoginPage(Driver);

            CJ_CovidEntriesIndexPage = new CJ_CovidEntriesIndexPage(Driver);

            CJ_CovidEntriesCreateNewPage = new CJ_CovidEntriesCreateNewPage(Driver);
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
