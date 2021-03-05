using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobAssignment_Specflow.Pages
{
    public class CartPageScript
    {
        public CartPageScript(IWebDriver webDriver)
        {
            Driver = webDriver;
        }
        public IWebDriver Driver { get; }

        //BUTTONS
        public IWebElement continueShoppingButton => Driver.FindElement(By.CssSelector("#cart_contents_container > div > div.cart_footer > a.btn_secondary"));
        public IWebElement checkoutButton => Driver.FindElement(By.CssSelector("#cart_contents_container > div > div.cart_footer > a.btn_action.checkout_button"));

        //METHODS
        public void ClickContinueShoppingButton()
        {
            continueShoppingButton.Click();
        }
        public void ClickCheckoutButton()
        {
            checkoutButton.Click();
        }
    }
}
