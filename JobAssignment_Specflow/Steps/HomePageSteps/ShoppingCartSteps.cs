using JobAssignment_Specflow.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace JobAssignment_Specflow.Steps.HomePageSteps
{
    [Binding]
    public class ShoppingCartSteps
    {
        DriverHelper _driverHelper;
        public HomePageScript homePage;

        public ShoppingCartSteps(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            homePage = new HomePageScript(_driverHelper.Driver);
        }

        [Then(@"Shopping cart should be displayed and enabled")]
        public void ThenShoppingCartShouldBeDisplayedAndEnabled()
        {
            Assert.IsTrue(homePage.cartButton.Displayed, "Shopping cart is not displayed");
            Assert.IsTrue(homePage.cartButton.Enabled, "Shopping cart is not enabled");
        }
    }
}
