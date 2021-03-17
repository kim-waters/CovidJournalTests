using System;
using TechTalk.SpecFlow;

namespace CovidTrackerTests.BDD
{
    [Binding]
    public class HomepageSteps
    {
        [Given(@"I am on the homepage")]
        public void GivenIAmOnTheHomepage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on the login nav link")]
        public void WhenIClickOnTheLoginNavLink()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on the register nav link")]
        public void WhenIClickOnTheRegisterNavLink()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on the covid entry nav link")]
        public void WhenIClickOnTheCovidEntryNavLink()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be taken to the login page")]
        public void ThenIShouldBeTakenToTheLoginPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be taken to the register page")]
        public void ThenIShouldBeTakenToTheRegisterPage()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
