using JobAssignment_Specflow.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace JobAssignment_Specflow.Steps.HomePageSteps
{
    [Binding]
    public class SortContainerSteps
    {
        DriverHelper _driverHelper;
        public HomePageScript homePage;

        public SortContainerSteps(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            homePage = new HomePageScript(_driverHelper.Driver);
        }

        [Then(@"Sort container should be displayed and enabled")]
        public void ThenSortContainerShouldBeDisplayedAndEnabled()
        {
            Assert.IsTrue(homePage.sortContainer.Displayed, "Sort container not displayed");
            Assert.IsTrue(homePage.sortContainer.Enabled, "Sort container not enabled");
        }
    }
}
