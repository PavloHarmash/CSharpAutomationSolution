using CSharpAutomationSolution.Driver;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Runtime.InteropServices;
using Yukon.Configurations.TestEnvironment;
using Yukon.Configurations.WebBrowsers;
using Yukon.Enums;

namespace Yukon.TestCases.UITests
{
    public class UIBaseTest : WebDriver
    {
        private BrowserTypes browserType;
        private string userName;
        private string password;
        private bool downloadFiles;
        private string downloadPath;

        public UIBaseTest() : this(BrowserTypes.Chrome,
                                   null,
                                   null,
                                   false)
        {
            this.downloadPath = null;
        }

        public UIBaseTest([Optional]BrowserTypes browserType,
                          [Optional]string userName,
                          [Optional]string password,
                          [Optional]bool downloadFiles)
        {
            this.browserType = browserType;
            this.userName = userName;
            this.password = password;
            this.downloadFiles = downloadFiles;

            if (this.downloadFiles)
            {
                this.downloadPath = CreateDownloadFilesDirectory(
                     Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"DownloadedFiles"));
            }
        }

        [OneTimeSetUp]
        public virtual void LounchBrowser()
        {
            LoadBrowser();
        }

        [SetUp]
        public virtual void LogIn()
        {
        }

        [OneTimeTearDown]
        public void CloseAllActivities()
        {
            base.webDriver.Quit();

            if (this.downloadFiles)
            {
                if (Directory.Exists(downloadPath))
                    Directory.Delete(downloadPath, true);
            }
        }

        private string CreateDownloadFilesDirectory(string pathToDownloadedFilesDirectory)
        {
            if (Directory.Exists(pathToDownloadedFilesDirectory))
            {
                Directory.Delete(pathToDownloadedFilesDirectory, true);
            }

            Directory.CreateDirectory(pathToDownloadedFilesDirectory);

            return Directory.Exists(pathToDownloadedFilesDirectory) ? pathToDownloadedFilesDirectory : string.Empty;
        }

        private void LoadBrowser()
        {
            switch (browserType)
            {
                case BrowserTypes.Chrome:
                    base.webDriver = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory,
                                                      ChromeBrowserConfigs.GetChromeOptions(downloadPath));
                    break;
                default:
                    break;
            }

            base.webDriver.Manage().Window.Maximize();
            base.webDriver.Navigate().GoToUrl(TestEnvConfigs.URL);
            new WebDriverWait(base.webDriver, TimeSpan.FromSeconds(10));
        }
    }
}