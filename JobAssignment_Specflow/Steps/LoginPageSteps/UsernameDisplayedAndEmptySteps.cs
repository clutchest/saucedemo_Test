using JobAssignment_Specflow.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace JobAssignment_Specflow.Steps
{
    [Binding]
    class UsernameDisplayedAndEmptySteps
    {
        DriverHelper _driverHelper;
        public LoginPageScript loginPage;

        public UsernameDisplayedAndEmptySteps(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            loginPage = new LoginPageScript(_driverHelper.Driver);
        }

        [Then(@"Username field should be empty and displayed")]
        public void ThenUsernameFieldShouldBeEmptyAndDisplayed()
        {
            Assert.That(loginPage.IsUsernameDisplayed, Is.True);
            Assert.That(loginPage.isUsernameEmpty, Is.True);
        }
    }
}
