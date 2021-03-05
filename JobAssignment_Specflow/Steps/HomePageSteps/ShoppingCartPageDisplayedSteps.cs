using JobAssignment_Specflow.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace JobAssignment_Specflow.Steps.HomePageSteps
{
    [Binding]
    public class ShoppingCartPageDisplayedSteps
    {
        DriverHelper _driverHelper;
        public HomePageScript homePage;

        public ShoppingCartPageDisplayedSteps(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            homePage = new HomePageScript(_driverHelper.Driver);
        }

        [Given(@"I click on shopping cart")]
        public void GivenIClickOnShoppingCart()
        {
            homePage.ClickShoppingCart();
        }
        
        [Then(@"User should be redirected to shopping cart page")]
        public void ThenUserShouldBeRedirectedToShoppingCartPage()
        {
            if (_driverHelper.Driver.Url.Contains("cart.html"))
                Assert.Pass();
            else
                Assert.Fail("Shopping cart page doesnt display");
        }
    }
}
