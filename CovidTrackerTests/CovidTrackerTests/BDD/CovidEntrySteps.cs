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
        
        [Then(@"the user is directed to the covid entry index page")]
        public void ThenTheUserIsDirectedToTheCovidEntryPage()
        {
            Assert.That(CJ_Website.GetPageTitle().Contains("Index - CovidJournal"));
        }
        [Given(@"the user is on the covid entry index page")]
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
        [Given(@"the user is on the covid entry create page")]
        public void GivenTheUserIsOnTheCovidEntryCreatePage()
        {
            CJ_Website.CJ_CovidEntriesCreateNewPage.Navigate();
        }

        [Given(@"the user enters valid journal details")]
        public void GivenTheUserEntersValidJournalDetails()
        {
            CJ_Website.CJ_CovidEntriesCreateNewPage.EnterDate("10032021");
            CJ_Website.CJ_CovidEntriesCreateNewPage.EnterTemperature("37.5");
            CJ_Website.CJ_CovidEntriesCreateNewPage.EnterNote("Feelin fine");
            CJ_Website.CJ_CovidEntriesCreateNewPage.EnterMood("10");
            CJ_Website.CJ_CovidEntriesCreateNewPage.TickFatigueBox();
        }
        [Given(@"the user enters a date in the future in the journal details")]
        public void GivenTheUserEntersADateInTheFutureInTheJournalDetails()
        {
            CJ_Website.CJ_CovidEntriesCreateNewPage.EnterDate("10032022");
            CJ_Website.CJ_CovidEntriesCreateNewPage.EnterTemperature("37.0");
            CJ_Website.CJ_CovidEntriesCreateNewPage.EnterMood("1");

        }


        [When(@"the user clicks the create button")]
        public void WhenTheUserClicksTheCreateButton()
        {
            CJ_Website.CJ_CovidEntriesCreateNewPage.ClickCreateEntryButton();
        }

        [Then(@"the entry from the same day is present")]
        public void ThenTheEntryFromTheSameDayIsPresent()
        {
            Assert.That(CJ_Website.CJ_CovidEntriesIndexPage.GetTableContents().Contains("10/03/2021"));
        }
        [Then(@"an error message about the date is displayed on the create page")]
        public void ThenAnErrorMessageIsDisplayedOnTheCreatePage()
        {
            Assert.That(CJ_Website.CJ_CovidEntriesCreateNewPage.GetDateValidation().Contains("Invalid date"));
        }

        [Given(@"the user enters journal details with (.*) symptoms")]
        public void GivenTheUserEntersJournalDetailsWithSymptoms(int num)
        {
            CJ_Website.CJ_CovidEntriesCreateNewPage.EnterTemperature("37.5");
            CJ_Website.CJ_CovidEntriesCreateNewPage.EnterMood("10");
            if (num == 0)
            {
                CJ_Website.CJ_CovidEntriesCreateNewPage.EnterDate("01032021");
            }
            else if (num == 1)
            {
                CJ_Website.CJ_CovidEntriesCreateNewPage.EnterDate("02032021");
                CJ_Website.CJ_CovidEntriesCreateNewPage.TickFatigueBox();
            }
            else if (num == 2)
            {
                CJ_Website.CJ_CovidEntriesCreateNewPage.EnterDate("03032021");
                CJ_Website.CJ_CovidEntriesCreateNewPage.TickFatigueBox();
                CJ_Website.CJ_CovidEntriesCreateNewPage.TickHeadacheBox();
            }
        }

        [Then(@"the correct (.*) of symptoms are listed")]
        public void ThenTheCorrectSymptomsAreListed(int num)
        {
            if (num == 0)
            {
                Assert.That(CJ_Website.CJ_CovidEntriesIndexPage.GetTableContents().Contains("01/03/2021 37.5 10 No symptoms"));
            }
            else if (num == 1)
            {
                Assert.That(CJ_Website.CJ_CovidEntriesIndexPage.GetTableContents().Contains("02/03/2021 37.5 10 Fatigue"));
            }
            else if (num == 2)
            {
                Assert.That(CJ_Website.CJ_CovidEntriesIndexPage.GetTableContents().Contains("03/03/2021 37.5 10 Headache, Fatigue"));
            }
        }

        [When(@"the user repeats this proccess with the same date for a new entry")]
        public void WhenTheUserRepeatsThisProccessWithTheSameDateForANewEntry()
        {
            CJ_Website.CJ_CovidEntriesCreateNewPage.Navigate();
            GivenTheUserEntersValidJournalDetails();
            CJ_Website.CJ_CovidEntriesCreateNewPage.ClickCreateEntryButton();
        }



        [AfterScenario]
        public void DisposeWebDriver()
        {
            CJ_Website.Driver.Quit();
            CJ_Website.Driver.Dispose();
        }
    }
}
