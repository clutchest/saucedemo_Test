using JobAssignment_Specflow.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace JobAssignment_Specflow.Steps
{
    [Binding]
    public class PasswordDisplayedAndEmptySteps
    {
        DriverHelper _driverHelper;

        public LoginPageScript loginPage;

        public PasswordDisplayedAndEmptySteps(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            loginPage = new LoginPageScript(_driverHelper.Driver);
        }

        [Then(@"Password field should now be empty and displayed")]
        public void ThenPasswordFieldShouldNowBeEmptyAndDisplayed()
        {
            Assert.That(loginPage.isPasswordDisplayed, Is.True);
            Assert.That(loginPage.isPasswordEmpty, Is.True);
        }
    }
}
