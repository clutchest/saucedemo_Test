using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace JobAssignment_Specflow.Hooks
{
    [Binding]
    public sealed class Hooks1 : DriverHelper
    {
        DriverHelper _driverHelper;
        public Hooks1(DriverHelper driverHelper) => _driverHelper = driverHelper;

        [BeforeScenario]
        public void BeforeScenario()
        {
            _driverHelper.Driver = new ChromeDriver(@"C:\seleniumChrome");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driverHelper.Driver.Quit();
        }
    }
}
