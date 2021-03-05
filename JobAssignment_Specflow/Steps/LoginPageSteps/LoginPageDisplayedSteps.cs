using JobAssignment_Specflow.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace JobAssignment_Specflow.Steps
{
    [Binding]
    public class LoginPageDisplayedSteps
    {
        DriverHelper _driverHelper;
        public LoginPageScript loginPage;

        public LoginPageDisplayedSteps(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            loginPage = new LoginPageScript(_driverHelper.Driver);
        }

        [Given(@"I launch the driver and navigate to test site")]
        public void GivenILaunchTheDriverAndNavigateToTestSite()
        {
            _driverHelper.Driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [Then(@"The login page should be displayed")]
        public void ThenTheLoginPageShouldBeDisplayed()
        {
            Assert.That(loginPage.loginDisplayed, Is.True);

        }

    }
}
