using JobAssignment_Specflow.Pages;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace JobAssignment_Specflow.Steps.HomePageSteps
{
    [Binding]
    public class OptionsAboutSteps
    {
        DriverHelper _driverHelper;
        public HomePageScript homePage;
        public LoginPageScript loginPage;

        public OptionsAboutSteps(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            loginPage = new LoginPageScript(_driverHelper.Driver);
            homePage = new HomePageScript(_driverHelper.Driver);
        }

        [Given(@"I click on options dropdown")]
        public void GivenIClickOnOptionsDropdown()
        {
            homePage.ClickOptionsDropdown();
        }

        [Given(@"I click on about link on options dropdown")]
        public void GivenIClickOnAboutLinkOnOptionsDropdown()
        {
            homePage.ClickOptionsAbout();
            Thread.Sleep(5000);
        }

        [Then(@"User should be redirected to saucelabs\.com site")]
        public void ThenUserShouldBeRedirectedToSaucelabs_ComSite()
        {
            if (_driverHelper.Driver.Url.Equals("https://saucelabs.com/"))
                Assert.Pass();
            else
                Assert.Fail("About button from Options dropdown isnt working as expected");
        }
    }
}