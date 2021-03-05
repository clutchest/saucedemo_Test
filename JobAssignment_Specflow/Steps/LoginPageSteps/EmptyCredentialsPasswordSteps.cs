using JobAssignment_Specflow.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace JobAssignment_Specflow.Steps
{
    [Binding]
    public class EmptyCredentialsPasswordSteps
    {
        DriverHelper _driverHelper;
        public LoginPageScript loginPage;

        public EmptyCredentialsPasswordSteps(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            loginPage = new LoginPageScript(_driverHelper.Driver);
        }

        [Given(@"I pass empty password")]
        public void GivenIPassEmptyPassword()
        {
            loginPage.Login("username", ""); //Empty password
        }
        
        [Then(@"Correct error message should be displayed")]
        public void ThenCorrectErrorMessageShouldBeDisplayed()
        {
            String passwordErrorText = "Epic sadface: Password is required";
            Assert.AreEqual(passwordErrorText, loginPage.loginErrorMessage.Text, "Correct error message is displayed");
        }
    }
}
