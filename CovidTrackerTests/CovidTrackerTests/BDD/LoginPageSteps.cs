﻿using System;
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
        
        [Given(@"I enter a valid password")]
        public void GivenIEnterAValidPassword()
        {
            CJ_Website.CJ_LoginPage.EnterPassword("9fhy5Xp*WBs#9ka");
        }
        
        [When(@"the login button is pressed")]
        public void WhenTheLoginButtonIsPressed()
        {
            CJ_Website.CJ_LoginPage.ClickLogInLink();
        }
        
        [Then(@"an error message is displayed")]
        public void ThenAnErrorMessageIsDisplayed()
        {
            Assert.That(CJ_Website.CJ_LoginPage.GetUsernameAlert().Contains("field is required"));
        }

        [AfterScenario]
        public void DisposeWebDriver()
        {
            CJ_Website.Driver.Quit();
            CJ_Website.Driver.Dispose();
        }
    }
}