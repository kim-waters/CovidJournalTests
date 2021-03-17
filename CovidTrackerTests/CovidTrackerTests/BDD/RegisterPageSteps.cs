﻿using CovidTrackerTests.lib.pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace CovidTrackerTests.BDD
{
    [Binding]
    public class RegisterPageSteps
    {
        public CJ_Website CJ_Website { get; } = new CJ_Website("chrome");

        [Given(@"I am on the register page")]
        public void GivenIAmOnTheRegisterPage()
        {
            CJ_Website.CJ_RegisterPage.Navigate();
        }



        [When(@"I click register")]
        public void WhenIClickRegister()
        {
            CJ_Website.CJ_RegisterPage.ClickRegisterButton();
        }
        
        [Given(@"I have entered a valid first name")]
        public void GivenIHaveEnteredAValidFirstName()
        {
            CJ_Website.CJ_RegisterPage.EnterFirstName();
        }
        
        [Given(@"I have entered a valid last name")]
        public void GivenIHaveEnteredAValidLastName()
        {
            CJ_Website.CJ_RegisterPage.EnterLastName();
        }
        
        [Given(@"I have entered a valid email")]
        public void GivenIHaveEnteredAValidEmail()
        {
            CJ_Website.CJ_RegisterPage.EnterEmail();
        }
        
        [Given(@"I have entered the password ""(.*)""")]
        public void GivenIHaveEnteredThePassword(string p0)
        {
            CJ_Website.CJ_RegisterPage.EnterPassword(p0);
        }
        
        [Given(@"I have entered the password confirmation ""(.*)""")]
        public void GivenIHaveEnteredThePasswordConfirmation(string p0)
        {
            CJ_Website.CJ_RegisterPage.EnterPasswordConfirmation(p0);
        }
        
       
        [Then(@"I should be taken to the confirmation page")]
        public void ThenIShouldBeTakenToTheConfirmationPage()
        {
            Assert.That(CJ_Website.GetPageTitle(), Is.EqualTo("Register confirmation - CovidJournal"));
        }
        
        [Then(@"An error message should be displayed saying ""(.*)""")]
        public void ThenAnErrorMessageShouldBeDisplayedSaying(string p0)
        {
            Assert.That(CJ_Website.CJ_RegisterPage.GetErrorMessages(), Does.Contain(p0));
        }
    }
}
