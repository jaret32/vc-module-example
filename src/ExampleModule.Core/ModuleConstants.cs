using System.Collections.Generic;
using VirtoCommerce.Platform.Core.Settings;

namespace ExampleModule.Core
{
    public static class ModuleConstants
    {
        public static class Security
        {
            public static class Permissions
            {
                public const string Access = "example:access";
                public const string Create = "example:create";
                public const string Read = "example:read";
                public const string Update = "example:update";
                public const string Delete = "example:delete";

                public static string[] AllPermissions { get; } = { Read, Create, Access, Update, Delete };
            }
        }

        public static class Settings
        {
            public static class General
            {
                public static SettingDescriptor ExampleEnabled { get; } = new SettingDescriptor
                {
                    Name = "Example.ExampleEnabled",
                    GroupName = "Example|General",
                    ValueType = SettingValueType.Boolean,
                    DefaultValue = false
                };

                public static SettingDescriptor ExamplePassword { get; } = new SettingDescriptor
                {
                    Name = "Example.ExamplePassword",
                    GroupName = "Example|Advanced",
                    ValueType = SettingValueType.SecureString,
                    DefaultValue = "qwerty"
                };

                public static IEnumerable<SettingDescriptor> AllSettings
                {
                    get
                    {
                        yield return ExampleEnabled;
                        yield return ExamplePassword;
                    }
                }
            }

            public static IEnumerable<SettingDescriptor> AllSettings
            {
                get
                {
                    return General.AllSettings;
                }
            }
        }
    }
}
