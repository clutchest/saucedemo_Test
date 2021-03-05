using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationTest_SauceDemo
{
    class LoginPage
    {

        public LoginPage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        public IWebDriver Driver { get; }


        //Best practice is locating elements by ID
        public IWebElement usernameTxt => Driver.FindElement(By.Id("user-name"));
        public IWebElement passwordTxt => Driver.FindElement(By.Id("password"));
        public IWebElement loginBtn => Driver.FindElement(By.Id("login-button"));

        public void Login(string username, string password)
        {
            usernameTxt.SendKeys(username);
            passwordTxt.SendKeys(password);
            loginBtn.Submit();
        }


    }
}
