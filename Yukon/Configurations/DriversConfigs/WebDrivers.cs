using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using Yukon.Enums;
using static Yukon.Configurations.WebBrowsers.ChromeBrowserConfigs;

namespace Yukon.Configurations.DriversConfigs
{
    public sealed class WebDrivers
    {
        public IWebDriver WebBrowser { get; set; }
        public static List<IWebDriver> WebBrowserInstanses { get; set; } = new List<IWebDriver>();

        public WebDrivers(BrowserTypes browserType, string downloadPath)
        {
            switch (browserType)
            {
                case BrowserTypes.Chrome:
                    this.WebBrowser = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory,
                                                       GetChromeOptions(downloadPath));
                    break;
                default:
                    break;
            }

            WebBrowserInstanses.Add(WebBrowser);
        }
    }
}
