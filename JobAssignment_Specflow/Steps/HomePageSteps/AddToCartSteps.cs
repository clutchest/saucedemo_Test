using JobAssignment_Specflow.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace JobAssignment_Specflow.Steps.HomePageSteps
{
    [Binding]
    public class AddToCartSteps
    {
        DriverHelper _driverHelper;
        public HomePageScript homePage;
        string listed = "REMOVE";
        string unlisted = "ADD TO CART";


        public AddToCartSteps(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            homePage = new HomePageScript(_driverHelper.Driver);
        }

        [Given(@"I click every button")]
        public void GivenIClickEveryButton()
        {
            var addToCart = _driverHelper.Driver.FindElements(By.ClassName("btn_primary"));

            foreach (var button in addToCart)
            {
                button.Submit();
            }
        }

        [Then(@"Button text should now be REMOVE")]
        public void ThenButtonTextShouldNowBeREMOVE()
        {
            var addToCart = _driverHelper.Driver.FindElements(By.ClassName("btn_primary"));
            foreach (var button in addToCart)
            {
                Assert.AreEqual(button.Text, listed, "Add To Cart buttons problem");
            }
        }

            [Then(@"I click every button again")]
        public void ThenIClickEveryButtonAgain()
        {
            var addToCart = _driverHelper.Driver.FindElements(By.ClassName("btn_primary"));
            foreach (var button in addToCart)
            {
                button.Click();
            }
        }


            [Then(@"Button text should now be ADD TO CART")]
        public void ThenButtonTextShouldNowBeADDTOCART()
        {
            var addToCart = _driverHelper.Driver.FindElements(By.ClassName("btn_primary"));
            foreach (var button in addToCart)
            {
                Assert.AreEqual(button.Text, unlisted, "Remove from cart buttons problem");
            }

        }

    }
}
