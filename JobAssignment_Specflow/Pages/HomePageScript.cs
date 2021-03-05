using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobAssignment_Specflow.Pages
{
    public class HomePageScript
    {
        public HomePageScript(IWebDriver webDriver)
        {
            Driver = webDriver;
        }
        public IWebDriver Driver { get; }

        //BUTTONS
        public IWebElement twitterBtn => Driver.FindElement(By.ClassName("social_twitter"));
        public IWebElement facebookBtn => Driver.FindElement(By.ClassName("social_facebook"));
        public IWebElement linkedinBtn => Driver.FindElement(By.ClassName("social_linkedin"));
        public IWebElement sortContainer => Driver.FindElement(By.ClassName("product_sort_container"));
        public IWebElement cartButton => Driver.FindElement(By.XPath("/html/body/div/div/div/div[1]/div[3]"));
        public IWebElement optionsDropdown => Driver.FindElement(By.CssSelector("#react-burger-menu-btn"));
        public IWebElement options_AboutButton => Driver.FindElement(By.Id("about_sidebar_link"));
        public IWebElement options_LogOutButton => Driver.FindElement(By.Id("logout_sidebar_link"));

        //METHODS
        public void ClickShoppingCart() => cartButton.Click();
        public void ClickOptionsDropdown() => optionsDropdown.Click();
        public void ClickOptionsAbout() => options_AboutButton.Click();
        public void ClickOptionsLogOut() => options_LogOutButton.Click();
        public void ClickTwitter() => twitterBtn.Click();
        public void ClickFacebook() => facebookBtn.Click();
        public void ClickLinkedin() => linkedinBtn.Click();
    }
}

