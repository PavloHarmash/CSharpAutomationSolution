using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using Yukon.Configurations.WebBrowsers;
using Yukon.Enums;

namespace Yukon.Driver
{
    public class WebDriverConfigs
    {
        protected IWebDriver WebDriver { get; set; }
        protected string downloadPath = null;

        public WebDriverConfigs(BrowserTypes browserType, bool downloadFiles)
        {
            if (downloadFiles)
            {
                this.downloadPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"DownloadedFiles");
                CreateDownloadFilesDirectory(this.downloadPath);
            }

            switch (browserType)
            {
                case BrowserTypes.Chrome:
                    this.WebDriver = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory,
                                                      ChromeBrowserConfigs.GetChromeOptions(downloadPath));
                    break;
                default:
                    break;
            }
        }

        //protected IWebElement GetElement(By locator) => this.WebDriver.FindElement(locator);

        //protected IList<IWebElement> GetElements(By locator) => this.WebDriver.FindElements(locator);

        private void CreateDownloadFilesDirectory(string pathToDirectory)
        {
            if (Directory.Exists(pathToDirectory))
            {
                Directory.Delete(pathToDirectory, true);
            }

            Directory.CreateDirectory(pathToDirectory);
        }
    }
}
