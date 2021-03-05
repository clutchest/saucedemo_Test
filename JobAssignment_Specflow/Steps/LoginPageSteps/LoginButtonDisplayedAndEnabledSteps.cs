using JobAssignment_Specflow.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace JobAssignment_Specflow.Steps
{
    [Binding]
    public class LoginButtonDisplayedAndEnabledSteps
    {
        DriverHelper _driverHelper;
        public LoginPageScript loginPage;

        public LoginButtonDisplayedAndEnabledSteps(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            loginPage = new LoginPageScript(_driverHelper.Driver);
        }

        [Then(@"Login button should now be displayed and enabled")]
        public void ThenLoginButtonShouldNowBeDisplayedAndEnabled()
        {
            Assert.That(loginPage.isLoginButtonDisplayed, Is.True);
            Assert.That(loginPage.isLoginButtonEnabled, Is.True);
        }
    }
}
