using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace LicenseGuide
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            LoadConfig();
            base.OnStartup(e);
        }

        private void LoadConfig()
        {
            try
            {
                var config = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();
                SetCulture(config);
                SetStyle(config);
            }
            catch (System.IO.FileNotFoundException)
            {
                // It's OK.
            }
            return;
        }

        private static void SetCulture(IConfigurationRoot config)
        {
            if (HasSetting(config, "Language", out string cultureString))
            {
                var culture = CultureInfo.CreateSpecificCulture(cultureString);
                if (culture != null)
                {
                    Thread.CurrentThread.CurrentCulture = culture;
                    Thread.CurrentThread.CurrentUICulture = culture;
                    CultureInfo.DefaultThreadCurrentCulture = culture;
                    CultureInfo.DefaultThreadCurrentUICulture = culture;
                }
            }
        }

        private static void SetStyle(IConfigurationRoot config)
        {
            if (HasSetting(config, "Style", out string styleString))
            {
                if (styleString == "dark-mode")
                {
                    var darkMode = new ResourceDictionary()
                    {
                        Source = new Uri("DarkMode.xaml", UriKind.Relative)
                    };
                    foreach (var key in Application.Current.Resources.Keys)
                    {
                        // Insert, don't replace.
                        if (darkMode.Contains(key))
                        {
                            continue;
                        }
                        var item = Application.Current.Resources[key];
                        darkMode.Add(key, item);
                    }
                    Application.Current.Resources = darkMode;
                }
            }
        }

        private static bool HasSetting(IConfiguration config, string settingName, out string settingValue)
        {
            settingValue = String.Empty;
            var result = false;

            string? value = config[settingName];
            if (value != null)
            {
                settingValue = value;
                result = true;
            }

            return result;
        }
    }
}
