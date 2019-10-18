using AutomationTests.Enums;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationTests.TestCases.UITests
{
    class UIBaseTest
    {
        public IWebDriver WebDriver { get; set; }

        public UIBaseTest(BrowserTypes type = BrowserTypes.Chrome)
        {            
        }

        [OneTimeSetUp]
        public void LogIn()
        {
            WebDriver = new ChromeDriver();
        }

        [OneTimeTearDown]
        public void LogOut()
        {

        }

        private void LoadBrowser()
        {
            switch (BrowserTypes.Chrome)
            {
                case BrowserTypes.Chrome:
                    break;
                default:
            }
        }
    }
}
