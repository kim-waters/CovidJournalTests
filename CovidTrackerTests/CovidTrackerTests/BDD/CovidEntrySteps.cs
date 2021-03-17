using System;
using TechTalk.SpecFlow;
using CovidTrackerTests.lib.pages;

namespace CovidTrackerTests.BDD
{
    [Binding]
    public class CovidEntrySteps
    {
        public CJ_Website CJ_Website { get; } = new CJ_Website("chrome");

        [Given(@"the user is signed in")]
        public void GivenTheUserIsSignedIn()
        {
            CJ_Website.CJ_HomePage.Navigate();
            CJ_Website.CJ_HomePage.ClickSignInLink();
        }
        
        [Given(@"the user is on the homepage")]
        public void GivenTheUserIsOnTheHomepage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the covid entry link is clicked")]
        public void WhenTheCovidEntryLinkIsClicked()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the user is directed to the covid entry page")]
        public void ThenTheUserIsDirectedToTheCovidEntryPage()
        {
            ScenarioContext.Current.Pending();
        }

        [AfterScenario]
        public void DisposeWebDriver()
        {
            CJ_Website.Driver.Quit();
            CJ_Website.Driver.Dispose();
        }
    }
}
