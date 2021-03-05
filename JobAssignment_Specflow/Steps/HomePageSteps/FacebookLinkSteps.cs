using JobAssignment_Specflow.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace JobAssignment_Specflow.Steps.HomePage
{
    [Binding]
    public class FacebookLinkSteps
    {
        DriverHelper _driverHelper;
        public HomePageScript homePage;

        public FacebookLinkSteps(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            homePage = new HomePageScript(_driverHelper.Driver);
        }

        [Given(@"I click facebook button")]
        public void GivenIClickFacebookButton()
        {
            homePage.ClickFacebook();
        }
        
        [Then(@"Facebook should be loaded")]
        public void ThenFacebookShouldBeLoaded()
        {
            Assert.AreEqual("https://www.facebook.com/saucelabs", _driverHelper.Driver.Url, "Facebook not loaded properly");
        }
    }
}
