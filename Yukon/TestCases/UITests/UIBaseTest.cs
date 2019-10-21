using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Runtime.InteropServices;
using Yukon.Configurations.TestEnvironment;
using Yukon.Driver;
using Yukon.Enums;
using Yukon.PageObjects;

namespace Yukon.TestCases.UITests
{
    public class UIBaseTest : WebDriverConfigs
    {
        protected string Login { get; set; }
        protected string Password { get; set; }

        public UIBaseTest() : this(BrowserTypes.Chrome,
                                   null,
                                   null,
                                   false)
        {
        }

        public UIBaseTest([Optional]BrowserTypes browserType,
                          [Optional]string login,
                          [Optional]string password,
                          [Optional]bool downloadFiles) : base(browserType, downloadFiles)
        {
            this.Login = login;
            this.Password = password;
        }

        [OneTimeSetUp]
        public void LounchBrowser()
        {
            LoadBrowser();
        }

        [SetUp]
        public virtual void LogIn()
        {
        }

        private void LoadBrowser()
        {
            base.WebDriver.Manage().Window.Maximize();
            base.WebDriver.Navigate().GoToUrl(TestEnvConfigs.URL);
            new WebDriverWait(base.WebDriver, TimeSpan.FromSeconds(10));
        }

        protected T GetPage<T>(string driver) where T : BasePage => (T)Activator.CreateInstance(typeof(T), driver);

        [OneTimeTearDown]
        public void CloseAllActivities()
        {
            base.WebDriver.Quit();

            if (Directory.Exists(base.downloadPath))
            {
                Directory.Delete(base.downloadPath, true);
            }
        }
    }
}