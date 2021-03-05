using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationTest_SauceDemo.Pages
{
    class HomePage
    {

        public HomePage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        public IWebDriver Driver { get; }

    }
}
