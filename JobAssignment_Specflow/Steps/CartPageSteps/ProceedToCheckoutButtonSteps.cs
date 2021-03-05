using JobAssignment_Specflow.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace JobAssignment_Specflow.Steps.CartPageSteps
{
    [Binding]
    public class ProceedToCheckoutButtonSteps
    {
        DriverHelper _driverHelper;
        public HomePageScript homePage;
        public CartPageScript cartPage;

        public ProceedToCheckoutButtonSteps(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            homePage = new HomePageScript(_driverHelper.Driver);
            cartPage = new CartPageScript(_driverHelper.Driver);
        }

        [Given(@"I click proceed to checkout button")]
        public void GivenIClickProceedToCheckoutButton()
        {
            cartPage.ClickCheckoutButton();
        }
        
        [Then(@"Checkout page should be displayed")]
        public void ThenCheckoutPageShouldBeDisplayed()
        {
            if (_driverHelper.Driver.Url.Equals("https://www.saucedemo.com/checkout-step-one.html"))
                Assert.Pass();
            else
                Assert.Fail("Proceed to checkout button from Cart page isnt working as expected");
        }
    }
}
