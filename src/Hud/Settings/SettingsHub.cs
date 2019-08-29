using Newtonsoft.Json;
using PoeHUD.Hud.Health;
using PoeHUD.Hud.Icons;
using PoeHUD.Hud.Menu;
using PoeHUD.Hud.Preload;
using PoeHUD.Hud.Settings.Converters;
using PoeHUD.Hud.Trackers;
using System;
using System.IO;
using PoeHUD.Hud.Performance;

namespace PoeHUD.Hud.Settings
{
    public sealed class SettingsHub
    {
        private const string SETTINGS_FILE_NAME = "config/settings.json";

        public static readonly JsonSerializerSettings jsonSettings;

        static SettingsHub()
        {
            jsonSettings = new JsonSerializerSettings
            {
                ContractResolver = new SortContractResolver(),
                Converters = new JsonConverter[]
                {
                    new ColorNodeConverter(),
                    new ToggleNodeConverter(),
                    new FileNodeConverter()
                }
            };
        }

        public SettingsHub()
        {
            MenuSettings = new CoreSettings();
            MapIconsSettings = new MapIconsSettings();
            MonsterTrackerSettings = new MonsterTrackerSettings();
            PoiTrackerSettings = new PoiTrackerSettings();
            PreloadAlertSettings = new PreloadAlertSettings();
            HealthBarSettings = new HealthBarSettings();
            PerformanceSettings = new PerformanceSettings();
        }

        [JsonProperty("Menu")]
        public CoreSettings MenuSettings { get; private set; }

        [JsonProperty("Map icons")]
        public MapIconsSettings MapIconsSettings { get; private set; }

        [JsonProperty("Monster tracker")]
        public MonsterTrackerSettings MonsterTrackerSettings { get; private set; }

        [JsonProperty("Poi tracker")]
        public PoiTrackerSettings PoiTrackerSettings { get; private set; }

        [JsonProperty("Preload alert")]
        public PreloadAlertSettings PreloadAlertSettings { get; private set; }

        [JsonProperty("Health bar")]
        public HealthBarSettings HealthBarSettings { get; private set; }

        [JsonProperty("Flasker")]
        public FlaskerSettings FlaskerSettings { get; private set; }

        [JsonProperty("Performance")]
        public PerformanceSettings PerformanceSettings { get; private set; }

        public static SettingsHub Load()
        {
            try
            {
                string json = File.ReadAllText(SETTINGS_FILE_NAME);

                if (string.IsNullOrEmpty(json.Trim()))//Sometimes settings is empty
                    throw new Exception();
                if (json == "null")//Sometime it contains only null word
                    throw new Exception();
                return JsonConvert.DeserializeObject<SettingsHub>(json, jsonSettings);
            }
            catch
            {
                if (File.Exists(SETTINGS_FILE_NAME))
                {
                    string backupFileName = SETTINGS_FILE_NAME + DateTime.Now.Ticks;
                    File.Move(SETTINGS_FILE_NAME, backupFileName);
                }

                var settings = new SettingsHub();
                Save(settings);
                return settings;
            }
        }

        public static void Save(SettingsHub settings)
        {
            if (settings == null) return;
            using (var stream = new StreamWriter(File.Create(SETTINGS_FILE_NAME)))
            {
                string json = JsonConvert.SerializeObject(settings, Formatting.Indented, jsonSettings);
                stream.Write(json);
            }
        }
    }
}