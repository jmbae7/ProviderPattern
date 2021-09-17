using System.Configuration;

namespace ProviderPatternLogTest.LogProvider
{
    public class LogProviderConfiguration : ConfigurationSection
    {
        [ConfigurationProperty("providers")]
        public ProviderSettingsCollection Providers
        {
            get
            {
                return (ProviderSettingsCollection)base["providers"];
            }
        }

        [ConfigurationProperty("default", DefaultValue = "XmlProvider")]
        public string DefaultProviderName
        {
            get
            {
                return base["default"] as string;
            }
        }

    }
}
