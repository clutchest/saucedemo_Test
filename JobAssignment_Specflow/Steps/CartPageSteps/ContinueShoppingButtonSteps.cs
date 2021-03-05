using JobAssignment_Specflow.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace JobAssignment_Specflow.Steps.CartPageSteps
{
    [Binding]
    public class ContinueShoppingButtonSteps
    {
        DriverHelper _driverHelper;
        public HomePageScript homePage;
        public CartPageScript cartPage;

        public ContinueShoppingButtonSteps(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            homePage = new HomePageScript(_driverHelper.Driver);
            cartPage = new CartPageScript(_driverHelper.Driver);
        }

        [Given(@"I click on shopping cart button")]
        public void GivenIClickOnShoppingCartButton()
        {
            homePage.ClickShoppingCart();
        }
        
        [Given(@"I click continue shopping button")]
        public void GivenIClickContinueShoppingButton()
        {
            cartPage.ClickContinueShoppingButton();
        }
        
        [Then(@"Homepage should be displayed")]
        public void ThenHomepageShouldBeDisplayed()
        {
            if (_driverHelper.Driver.Url.Equals("https://www.saucedemo.com/inventory.html"))
                Assert.Pass();
            else
                Assert.Fail("Continue shopping button from Cart page isnt working as expected");        }
        }
    }
