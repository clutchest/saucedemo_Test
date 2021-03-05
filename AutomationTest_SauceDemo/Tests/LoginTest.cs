using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationTest_SauceDemo
{
    public class LoginTest
    {
        IWebDriver Driver = new ChromeDriver(@"C:\seleniumChrome");

        [SetUp]
        public void Setup()
        {
            //Navigates the driver to our test page
            Driver.Navigate().GoToUrl("https://www.saucedemo.com/");

        }

        [Test]
        public void Login()
        {
            //References login page
            LoginPage loginPage = new LoginPage(Driver);

            //Check if username textbox is displayed and if its empty
            Assert.IsTrue(loginPage.usernameTxt.Displayed, "The username textbox is not displayed");
            Assert.IsTrue(loginPage.usernameTxt.Text.Length == 0, "The username textbox is not empty");

            //Check if password textbox is displayed and if its empty
            Assert.IsTrue(loginPage.passwordTxt.Displayed, "The password textbox is not displayed");
            Assert.IsTrue(loginPage.passwordTxt.Text.Length == 0, "The password textbox is not empty");

            //Check if login button is displayed and interactable
            Assert.IsTrue(loginPage.loginBtn.Displayed, "Login button is not displayed");
            Assert.IsTrue(loginPage.loginBtn.Enabled, "Login button is enabled and interactable");

            //Passing username and password parameters to Login()
            loginPage.Login("standard_user", "secret_sauce");



        }

        //[TearDown]
        //public void closeBrowser()
        //{
        //    Driver.Close();
        //}

    }
}