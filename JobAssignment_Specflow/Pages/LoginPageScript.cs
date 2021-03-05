using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobAssignment_Specflow.Pages
{
    public class LoginPageScript
    {
        public LoginPageScript(IWebDriver webDriver)
        {
            Driver = webDriver;
        }
        public IWebDriver Driver { get; }


        public IWebElement usernameTxt => Driver.FindElement(By.Id("user-name"));
        public IWebElement passwordTxt => Driver.FindElement(By.Id("password"));
        public IWebElement loginBtn => Driver.FindElement(By.Id("login-button"));
        public IWebElement loginErrorMessage => Driver.FindElement(By.CssSelector("#login_button_container > div > form > h3"));
        public IWebElement loginFullPage => Driver.FindElement(By.Id("root"));
        public IWebElement homePageLoadedSecurity => Driver.FindElement(By.ClassName("product_label"));


        public bool usernameTxt_IsEmpty;
        public bool passwordTxt_IsEmpty;


        public void Login(string username, string password)
        {
            usernameTxt.SendKeys(username);
            passwordTxt.SendKeys(password);
        }

        public void SubmitLogin()
        {
            loginBtn.Submit();
        }

        public bool loginDisplayed() => loginFullPage.Displayed;

        public bool IsUsernameDisplayed() => usernameTxt.Displayed;
        public bool isUsernameEmpty() => usernameTxt.Text.Length == 0;
        public bool isPasswordDisplayed() => passwordTxt.Displayed;
        public bool isPasswordEmpty() => passwordTxt.Text.Length == 0;
        public bool isLoginButtonDisplayed() => loginBtn.Displayed;
        public bool isLoginButtonEnabled() => loginBtn.Enabled;
        public bool isLoginErrorMessageDisplayed() => loginErrorMessage.Displayed;
    }
}
