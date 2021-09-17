using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Web.Configuration;
using ProviderPatternLogTest.LogProvider.Providers;

namespace ProviderPatternLogTest.LogProvider
{
    public class LogProviderManager
    {
        static LogProviderManager()
        {
            Initialize();
        }

        private static LogProviderBase _default;
        /// <summary>
        /// Returns the default configured data provider
        /// </summary>
        public static LogProviderBase Default
        {
            get { return _default; }
        }

        private static LogProviderCollection _providerCollection;
        /// <summary>
        /// .Returns the provider collection
        /// </summary>
        public static LogProviderCollection Providers
        {
            get { return _providerCollection; }
        }

        private static ProviderSettingsCollection _providerSettings;
        public static ProviderSettingsCollection ProviderSettings
        {
            get { return _providerSettings; }
        }

        /// <summary>
        /// Reads the configuration related to the set of configured 
        /// providers and sets the default and collection of providers and settings.
        /// </summary>
        private static void Initialize()
        {
            LogProviderConfiguration configSection = (LogProviderConfiguration)ConfigurationManager.GetSection("LogProviders");
            if (configSection == null)
                throw new ConfigurationException("Data provider section is not set.");

            _providerCollection = new LogProviderCollection();
            ProvidersHelper.InstantiateProviders(configSection.Providers, _providerCollection, typeof(LogProviderBase));

            _providerSettings = configSection.Providers;

            if (_providerCollection[configSection.DefaultProviderName] == null)
                throw new ConfigurationException("Default data provider is not set.");
            _default = _providerCollection[configSection.DefaultProviderName];
            var defaultSettings = _providerSettings[configSection.DefaultProviderName];

            _default.SetParameters(defaultSettings.Parameters);
        }
    }
}
