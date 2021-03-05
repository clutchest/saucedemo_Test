using JobAssignment_Specflow.Pages;
using NUnit.Framework;
using System;
using System.Linq;
using System.Threading;
using TechTalk.SpecFlow;

namespace JobAssignment_Specflow.Steps
{
    [Binding]
    public class TwitterLinkSteps
    {
        DriverHelper _driverHelper;
        public HomePageScript homePage;
        public LoginPageScript loginPage;

        public TwitterLinkSteps(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            loginPage = new LoginPageScript(_driverHelper.Driver);
            homePage = new HomePageScript(_driverHelper.Driver);
        }

        [Given(@"I launch the driver and navigate to test site and login with correct credentials")]
        public void GivenILaunchTheDriverAndNavigateToTestSiteAndLoginWithCorrectCredentials()
        {
            _driverHelper.Driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            loginPage.Login("standard_user", "secret_sauce");
            loginPage.SubmitLogin();
            Thread.Sleep(5000);
        }
        
        [Given(@"I click twitter button")]
        public void GivenIClickTwitterButton()
        {
            homePage.ClickTwitter();
        }
        
        [Given(@"I switch to popup tab in browser")]
        public void GivenISwitchToPopupTabInBrowser()
        {
            _driverHelper.Driver.SwitchTo().Window(_driverHelper.Driver.WindowHandles.Last());

        }

        [Then(@"Twitter should be loaded")]
        public void ThenTwitterShouldBeLoaded()
        {
            Assert.AreEqual("https://twitter.com/saucelabs", _driverHelper.Driver.Url, "Twitter not loaded properly");
        }
    }
}
