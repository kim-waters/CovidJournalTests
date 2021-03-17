using System;
using TechTalk.SpecFlow;
using CovidTrackerTests.lib.pages;
using NUnit.Framework;

namespace CovidTrackerTests.BDD
{
    [Binding]
    public class LoginPageSteps
    {
        public CJ_Website CJ_Website { get; } = new CJ_Website("chrome");

        [Given(@"I am on the log in page")]
        public void GivenIAmOnTheLogInPage()
        {
            CJ_Website.CJ_LoginPage.Navigate();
        }

        [Given(@"I enter a blank username")]
        public void GivenIEnterABlankUsername()
        {
            CJ_Website.CJ_LoginPage.EnterUsername("");
        }

        [Given(@"I enter a registered username")]
        public void GivenIEnterARegisteredUsername()
        {
            CJ_Website.CJ_LoginPage.EnterUsername("jorisbohnson");
        }

        [Given(@"I enter a username that is not registered")]
        public void GivenIEnterAUsernameThatIsNotRegistered()
        {
            CJ_Website.CJ_LoginPage.EnterUsername("harrypotter");
        }

        [Given(@"I enter a valid password")]
        public void GivenIEnterAValidPassword()
        {
            CJ_Website.CJ_LoginPage.EnterPassword("Covid?Password!123");
        }

        [Given(@"I sign in using a registered name and password")]
        public void GivenISignInUsingARegisteredNameAndPassword()
        {
            CJ_Website.CJ_LoginPage.EnterUsername("jorisbohnson");
            CJ_Website.CJ_LoginPage.EnterPassword("Covid?Password!123");
            CJ_Website.CJ_LoginPage.ClickLogInLink();
        }

        [When(@"the login button is pressed")]
        public void WhenTheLoginButtonIsPressed()
        {
            CJ_Website.CJ_LoginPage.ClickLogInLink();
        }

        [When(@"I click on the Logout button")]
        public void WhenIClickOnTheLogoutButton()
        {
            CJ_Website.CJ_LoginPage.ClickLogOutLink();
        }

        [Then(@"an error message is displayed")]
        public void ThenAnErrorMessageIsDisplayed()
        {
            Assert.That(CJ_Website.CJ_LoginPage.GetUsernameAlert().Contains("field is required"));
        }

        [Then(@"an invalid login attempt message is displayed")]
        public void ThenAnInvalidLoginAttemptMessageIsDisplayed()
        {
            Assert.That(CJ_Website.CJ_LoginPage.GetInvalidLoginAlert().Contains("Invalid login"));
        }


        [Then(@"I am taken to the home page")]
        public void ThenIAmTakenToTheHomePage()
        {
            Assert.That(CJ_Website.CJ_LoginPage.GetPageTitle(), Is.EqualTo("Home Page - CovidJournal"));
        }

        [Then(@"I am taken to the home page and signed out")]
        public void ThenIAmTakenToTheHomePageAndSignedOut()
        {
            Assert.That(CJ_Website.CJ_LoginPage.GetRegisterLinkWhenLoggedOut().Contains("Register"));
        }
        [Given(@"I enter an invalid password")]
        public void GivenIEnterAnInvalidPassword()
        {
            CJ_Website.CJ_LoginPage.EnterPassword("ErrorPassword");
        }

        [AfterScenario]
        public void DisposeWebDriver()
        {
            CJ_Website.Driver.Quit();
            CJ_Website.Driver.Dispose();
        }
    }
        
}
