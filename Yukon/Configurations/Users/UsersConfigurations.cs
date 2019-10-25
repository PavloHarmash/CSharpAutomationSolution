using Yukon.Models.Configs;
using Yukon.Utility.Helpers;

namespace Yukon.Configurations.Users
{
    public static class UsersConfigurations
    {
        public static readonly UsersConfigsModel User
            = JsonHelper.DeserializeJson<UsersConfigsModel>(@"Configurations\Users\UsersConfigs.json");
    }
}