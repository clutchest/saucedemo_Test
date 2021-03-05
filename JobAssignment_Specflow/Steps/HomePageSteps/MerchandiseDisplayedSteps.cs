using JobAssignment_Specflow.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace JobAssignment_Specflow.Steps.HomePageSteps
{
    [Binding]
    public class MerchandiseDisplayedSteps
    {
        DriverHelper _driverHelper;
        public HomePageScript homePage;

        public MerchandiseDisplayedSteps(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            homePage = new HomePageScript(_driverHelper.Driver);
        }

        [Then(@"Merchandise should now be displayed")]
        public void ThenMerchandiseShouldNowBeDisplayed()
        {
            var addToCart = _driverHelper.Driver.FindElements(By.ClassName("btn_primary"));
            foreach (var button in addToCart)
            {
                Assert.IsTrue(button.Displayed, "Buttons not displayed as expected");
            }
        }
    }
}
