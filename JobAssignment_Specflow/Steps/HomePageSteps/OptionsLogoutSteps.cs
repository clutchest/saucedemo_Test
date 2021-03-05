using JobAssignment_Specflow.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace JobAssignment_Specflow.Steps.HomePageSteps
{
    [Binding]
    public class OptionsLogoutSteps
    {
        DriverHelper _driverHelper;
        public HomePageScript homePage;

        public OptionsLogoutSteps(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            homePage = new HomePageScript(_driverHelper.Driver);
        }

        [Given(@"I click on log out link on options dropdown")]
        public void GivenIClickOnLogOutLinkOnOptionsDropdown()
        {
            homePage.ClickOptionsLogOut();
        }
        
        [Then(@"User should be redirected to saucedemo\.com site")]
        public void ThenUserShouldBeRedirectedToSaucedemo_ComSite()
        {
            if (_driverHelper.Driver.Url.Equals("https://www.saucedemo.com/"))
                Assert.Pass();
            else
                Assert.Fail("LogOut button from Options dropdown isnt working as expected");
        }
    }
}
