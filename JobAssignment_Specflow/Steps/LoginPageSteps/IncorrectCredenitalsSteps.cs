using JobAssignment_Specflow.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace JobAssignment_Specflow.Steps
{
    [Binding]
    public class IncorrectCredenitalsUsernameSteps
    {
        DriverHelper _driverHelper;
        public LoginPageScript loginPage;

        public IncorrectCredenitalsUsernameSteps(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            loginPage = new LoginPageScript(_driverHelper.Driver);
        }

        [Given(@"Input wrong credentials")]
        public void GivenInputWrongCredentials()
        {
            loginPage.Login("username", "password"); //Incorrect credentials
        }
        
        [When(@"I press login button")]
        public void WhenIPressLoginButton()
        {
            loginPage.SubmitLogin();
        }
        
        [Then(@"Error message should now be displayed")]
        public void ThenErrorMessageShouldNowBeDisplayed()
        {
            Assert.That(loginPage.isLoginErrorMessageDisplayed);
        }
    }
}
