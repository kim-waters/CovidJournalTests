using CovidTrackerTests.lib.pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace CovidTrackerTests.BDD
{
    [Binding]
    public class HomepageSteps
    {
        public CJ_Website CJ_Website { get; } = new CJ_Website("chrome");
        [Given(@"I am on the homepage")]
        public void GivenIAmOnTheHomepage()
        {
            CJ_Website.CJ_HomePage.Navigate();
        }
        
        [When(@"I click on the login nav link")]
        public void WhenIClickOnTheLoginNavLink()
        {
            CJ_Website.CJ_HomePage.ClickSignInLink();
        }
        
        [When(@"I click on the register nav link")]
        public void WhenIClickOnTheRegisterNavLink()
        {
            CJ_Website.CJ_HomePage.ClickRegisterLink();
        }
        
        [When(@"I click on the covid entry nav link")]
        public void WhenIClickOnTheCovidEntryNavLink()
        {
            CJ_Website.CJ_HomePage.ClickEntryLink();
        }
        
        [Then(@"I should be taken to the login page")]
        public void ThenIShouldBeTakenToTheLoginPage()
        {
            Assert.That(CJ_Website.GetPageTitle(), Is.EqualTo("Log in - CovidJournal"));
        }
        
        [Then(@"I should be taken to the register page")]
        public void ThenIShouldBeTakenToTheRegisterPage()
        {
            Assert.That(CJ_Website.GetPageTitle(), Is.EqualTo("Register - CovidJournal"));
        }
    }
}
