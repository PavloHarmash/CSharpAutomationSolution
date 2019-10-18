using CSharpAutomationSolution.Models.Configs;
using Yukon.Utility.Helpers;

namespace Yukon.Configurations.Users
{
    public class UsersConfigs
    {
        private static readonly UsersConfigsModel Configs
            = JsonHelper.DeserializeJson<UsersConfigsModel>(@"Configurations\Users\UsersConfigs.json");

        public static Customer Customer { get; } = Configs.Customer;
        public static Implementer Implementer { get; } = Configs.Implementer;
    }
}