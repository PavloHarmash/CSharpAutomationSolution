using OpenQA.Selenium.Chrome;

namespace Yukon.Configurations.WebBrowsers
{
    public class ChromeBrowserConfigs
    {
        public static ChromeOptions GetChromeOptions(string downloadPath = null)
        {
            ChromeOptions options = new ChromeOptions();

            options.AddArgument("--start-maximized");
            options.AddArgument("--disable-infobars");
            options.AddArgument("--disable-extensions");
            options.AddArgument("--no-sandbox");
            //options.AddArgument("--headless");

            //To disable the popup for Password save
            options.AddUserProfilePreference("credentials_enable_service", false);
            options.AddUserProfilePreference("profile.password_manager_enabled", false);
            options.AddUserProfilePreference("profile.default_content_setting_values.automatic_downloads", 1);

            if (!string.IsNullOrEmpty(downloadPath))
            {
                options.AddUserProfilePreference("download.default_directory", downloadPath);
            }

            return options;
        }
    }
}
