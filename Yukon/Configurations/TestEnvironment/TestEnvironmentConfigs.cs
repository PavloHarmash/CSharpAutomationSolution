using Yukon.Models.Configs;
using Yukon.Utility.Helpers;

namespace Yukon.Configurations.TestEnvironment
{
    public static class TestEnvironmentConfigs
    {
        public static readonly TestEnvConfigModel TestEnvConfigs
            = JsonHelper.DeserializeJson<TestEnvConfigModel>(@"Configurations\TestEnvironment\TestEnvConfig.json");
    }
}