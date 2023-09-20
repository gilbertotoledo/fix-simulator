using System.Configuration;
using System.Globalization;

namespace Business.Helper
{
    public static class ConfigHelper
    {
        public static char GetChar(string key) =>
            ConfigurationManager.AppSettings[key][0];

        public static string GetString(string key) =>
            ConfigurationManager.AppSettings[key];

        public static bool GetBool(string key) =>
            ConfigurationManager.AppSettings[key] == "true";

        public static int GetInt(string key) =>
            int.Parse(ConfigurationManager.AppSettings[key]);

        public static decimal GetDecimal(string key) =>
            decimal.Parse(ConfigurationManager.AppSettings[key], new CultureInfo("en-US"));

        public static void Persist(string key, char value) =>
            Persist(key, value.ToString());

        public static void Persist(string key, int value) =>
            Persist(key, value.ToString());

        public static void Persist(string key, decimal value) =>
            Persist(key, value.ToString(new CultureInfo("en-US")));

        public static void Persist(string key, bool value) =>
            Persist(key, value ? "true" : "false");

        public static void Persist(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
            }
        }
    }
}
