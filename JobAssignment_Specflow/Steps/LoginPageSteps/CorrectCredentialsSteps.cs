using JobAssignment_Specflow.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace JobAssignment_Specflow.Steps
{
    [Binding]
    public class CorrectCredentialsSteps
    {
        DriverHelper _driverHelper;
        public LoginPageScript loginPage;

        public CorrectCredentialsSteps(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            loginPage = new LoginPageScript(_driverHelper.Driver);
        }

        [Given(@"I pass correct credentials")]
        public void GivenIPassCorrectCredentials()
        {
            loginPage.Login("standard_user", "secret_sauce");
        }
        
        [Then(@"Homepage should be loaded")]
        public void ThenHomepageShouldBeLoaded()
        {
            Assert.IsTrue(loginPage.homePageLoadedSecurity.Displayed, "Homepage loaded");
        }
    }
}
