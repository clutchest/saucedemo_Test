using JobAssignment_Specflow.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace JobAssignment_Specflow.Steps.HomePageSteps
{
    [Binding]
    public class LinkedInSteps
    {
        DriverHelper _driverHelper;
        public HomePageScript homePage;

        public LinkedInSteps(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            homePage = new HomePageScript(_driverHelper.Driver);
        }

        [Given(@"I click linkedin button")]
        public void GivenIClickLinkedinButton()
        {
            homePage.ClickLinkedin();
        }
        
        [Then(@"LinkedIn should be loaded")]
        public void ThenLinkedInShouldBeLoaded()
        {
            if (_driverHelper.Driver.Url.Contains("https://www.linkedin.com/authwall?")) //
                Assert.Pass();
            else
                Assert.Fail("LinkedIn link doesnt work as expected");
        }
    }
}
