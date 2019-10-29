using NUnit.Framework;
using System;
using System.IO;
using System.Runtime.InteropServices;
using Yukon.Configurations.DriversConfigs;
using Yukon.Enums;
using Yukon.Libraries.TranslationLibrary;
using Yukon.Models.Configs;
using Yukon.PageObjects;
using Yukon.PageObjects.Headers;
using Yukon.Utility;
using Yukon.Utility.Helpers;
using static Yukon.Configurations.TestEnvironment.TestEnvironmentConfigs;
using static Yukon.Configurations.Users.UsersConfigurations;

namespace Yukon.TestCases.UITests
{
    public class UIBaseTest
    {
        private WebDrivers Driver { get; set; }
        private readonly BrowserTypes browserType;
        
        protected Users Client { get; set; } = User.Customer;
        private readonly bool downloadFiles;
        private string downloadPath = null;

        public UIBaseTest() : this(BrowserTypes.Chrome,
                                   AppLanguage.Russian,
                                   false)
        {
        }

        public UIBaseTest([Optional]BrowserTypes browserType,
                          [Optional]AppLanguage appLanguage,
                          [Optional]bool downloadFiles)
        {
            this.browserType = browserType;
            BasePage.Text = new TranslationLibrary(appLanguage).Library;

            this.downloadFiles = downloadFiles;

            if (this.downloadFiles)
            {
                this.downloadPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"DownloadedFiles");
                this.CreateDownloadFilesDirectory(this.downloadPath);
            }
        }

        [OneTimeSetUp]
        public void LounchBrowser()
        {
            this.LoadBrowser();
        }

        [SetUp]
        public virtual void LogIn()
        {
            new RegistrationHeader(this.Driver.WebBrowser).LogInAs(this.Client);
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
            this.Driver = new WebDrivers(this.browserType, this.downloadPath);
            this.Driver.WebBrowser.Manage().Window.Maximize();
            this.Driver.WebBrowser.Navigate()
                .GoToUrl(string.Concat(TestEnvConfigs.URL, TranslationLibrary.AppLanguage.Description(), "/"));
            new Waiters(this.Driver.WebBrowser).UntilPageLoaderDisappear();
        }

        protected T LoadPage<T>() where T : BasePage
        {
            return new PageCreator(this.Driver.WebBrowser).CreatePage<T>();
        }

        [OneTimeTearDown]
        public void CloseAllResourses()
        {
            foreach (var webDriverInstance in WebDrivers.WebBrowserInstanses)
            {
                webDriverInstance.Quit();
                webDriverInstance.Dispose();
            }

            WebDrivers.WebBrowserInstanses.Clear();

            if (Directory.Exists(this.downloadPath))
            {
                Directory.Delete(this.downloadPath, true);
            }
        }
    }
}