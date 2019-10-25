using System;
using System.ComponentModel;

namespace Yukon.Utility.Helpers
{
    public static class EnumExtensions
    {
        public static string Description(this Enum value)
        {
            var field = value.GetType().GetField(value.ToString());

            var attributes = field.GetCustomAttributes(typeof(DescriptionAttribute), false);

            return attributes.Length == 0 ? value.ToString() : (attributes[0] as DescriptionAttribute).Description;
        }
    }
}
