using JobAssignment_Specflow.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace JobAssignment_Specflow.Steps
{
    [Binding]
    public class EmptyCredentialsUsernameSteps
    {
        DriverHelper _driverHelper;
        public LoginPageScript loginPage;

        public EmptyCredentialsUsernameSteps(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            loginPage = new LoginPageScript(_driverHelper.Driver);
        }

        [Given(@"I pass empty username")]
        public void GivenIPassEmptyUsername()
        {
            loginPage.Login("", "password"); //Empty username
        }
        
        [Then(@"Correct username empty error message should be displayed")]
        public void ThenCorrectUsernameEmptyErrorMessageShouldBeDisplayed()
        {
                String usernameErrorText = "Epic sadface: Username is required";
                Assert.AreEqual(usernameErrorText, loginPage.loginErrorMessage.Text, "Correct error message is displayed");
            }
        }
}

