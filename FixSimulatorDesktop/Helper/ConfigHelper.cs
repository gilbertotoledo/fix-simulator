using System.Configuration;

namespace FixSimulatorDesktop.Helper
{
    public static class ConfigHelper
    {
        public static string GetString(string key) =>
            ConfigurationManager.AppSettings[key];

        public static bool GetBool(string key) =>
            ConfigurationManager.AppSettings[key] == "true";

        public static int GetInt(string key) =>
            int.Parse(ConfigurationManager.AppSettings[key]);

        public static void Persist(string key, int value) =>
            Persist(key, value.ToString());

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
