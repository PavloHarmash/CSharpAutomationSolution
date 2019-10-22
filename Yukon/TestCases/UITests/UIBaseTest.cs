using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Runtime.InteropServices;
using Yukon.Configurations.DriversConfigs;
using Yukon.Configurations.TestEnvironment;
using Yukon.Configurations.Users;
using Yukon.Enums;
using Yukon.PageObjects;

namespace Yukon.TestCases.UITests
{
    public class UIBaseTest
    {
        private WebDrivers Driver { get; set; }
        private readonly BrowserTypes browserType;
        protected string Login { get; set; }
        protected string Password { get; set; }
        private readonly bool downloadFiles;
        private string downloadPath = null;

        public UIBaseTest() : this(BrowserTypes.Chrome,
                                   UsersConfigs.Customer.Login,
                                   UsersConfigs.Customer.Password,
                                   false)
        {
        }

        public UIBaseTest([Optional]BrowserTypes browserType,
                          [Optional]string login,
                          [Optional]string password,
                          [Optional]bool downloadFiles)
        {
            this.browserType = browserType;
            this.Login = login;
            this.Password = password;
            this.downloadFiles = downloadFiles;

            if (downloadFiles)
            {
                downloadPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"DownloadedFiles");
                CreateDownloadFilesDirectory(downloadPath);
            }
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

        private void CreateDownloadFilesDirectory(string pathToDirectory)
        {
            if (Directory.Exists(pathToDirectory))
            {
                Directory.Delete(pathToDirectory, true);
            }

            Directory.CreateDirectory(pathToDirectory);
        }

        private void LoadBrowser()
        {
            this.Driver = new WebDrivers(browserType, downloadPath);
            this.Driver.WebBrowser.Manage().Window.Maximize();
            this.Driver.WebBrowser.Navigate().GoToUrl(TestEnvConfigs.URL);
            new WebDriverWait(this.Driver.WebBrowser, TimeSpan.FromSeconds(10)).Until(d => d.Title.Contains("Yukon"));
        }

        protected T PageLoad<T>() where T : BasePage
            => Activator.CreateInstance(typeof(T), this.Driver.WebBrowser) as T;

        [OneTimeTearDown]
        public void CloseAllResourses()
        {
            foreach (var webDriverInstance in WebDrivers.WebBrowserInstanses)
            {
                webDriverInstance.Quit();
            }

            if (Directory.Exists(downloadPath))
            {
                Directory.Delete(downloadPath, true);
            }
        }
    }
}