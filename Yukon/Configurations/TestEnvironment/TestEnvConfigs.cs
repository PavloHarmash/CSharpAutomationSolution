using Yukon.Models.Configs;
using Yukon.Utility.Helpers;

namespace Yukon.Configurations.TestEnvironment
{
    public class TestEnvConfigs
    {
        private static readonly TestEnvConfigModel Configs
            = JsonHelper.DeserializeJson<TestEnvConfigModel>(@"Configurations\TestEnvironment\TestEnvConfig.json");

        public static string URL { get; } = Configs.URL;
        public static string ApiPort { get; } = Configs.ApiPort;
    }
}