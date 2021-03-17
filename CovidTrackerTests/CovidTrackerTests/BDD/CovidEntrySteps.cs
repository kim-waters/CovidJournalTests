using System;
using TechTalk.SpecFlow;
using CovidTrackerTests.lib.pages;
using NUnit.Framework;

namespace CovidTrackerTests.BDD
{
    [Binding]
    public class CovidEntrySteps
    {
        public CJ_Website CJ_Website { get; } = new CJ_Website("chrome");

        [Given(@"the user is signed in")]
        public void GivenTheUserIsSignedIn()
        {
            CJ_Website.CJ_LoginPage.Navigate();
            CJ_Website.CJ_LoginPage.EnterUsername("jorisbohnson");
            CJ_Website.CJ_LoginPage.EnterPassword("Covid?Password!123");
            CJ_Website.CJ_LoginPage.ClickLogInLink();
        }
        
        [Given(@"the user is on the homepage")]
        public void GivenTheUserIsOnTheHomepage()
        {
            CJ_Website.CJ_HomePage.Navigate();
        }
        
        [When(@"the covid entry link is clicked")]
        public void WhenTheCovidEntryLinkIsClicked()
        {
            CJ_Website.CJ_HomePage.ClickEntryLink();
        }
        
        [Then(@"the user is directed to the covid entry page")]
        public void ThenTheUserIsDirectedToTheCovidEntryPage()
        {
            Assert.That(CJ_Website.GetPageTitle().Contains("Index - CovidJournal"));
        }
        [Given(@"the user is on the covid entry page")]
        public void GivenTheUserIsOnTheCovidEntryPage()
        {
            CJ_Website.CJ_CovidEntriesIndexPage.Navigate();
        }

        [When(@"the create new link is clicked")]
        public void WhenTheCreateNewLinkIsClicked()
        {
            CJ_Website.CJ_CovidEntriesIndexPage.ClickNewEntryButton();
        }

        [Then(@"the user is directed to the Create covid entry page")]
        public void ThenTheUserIsDirectedToTheCreateCovidEntryPage()
        {
            Assert.That(CJ_Website.GetPageTitle().Contains("Create - CovidJournal"));
        }

        [AfterScenario]
        public void DisposeWebDriver()
        {
            CJ_Website.Driver.Quit();
            CJ_Website.Driver.Dispose();
        }
    }
}
