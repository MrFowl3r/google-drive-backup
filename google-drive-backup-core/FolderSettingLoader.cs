using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace google_drive_backup_core
{
    /// <summary>
    /// A class to load/save folder settings to a json formatted file.
    /// </summary>
    public class FolderSettingLoader
    {
        public FolderSettingLoader(string fullSettingsFileName)
        {
            _settingsFileName = fullSettingsFileName;
        }

        private string _settingsFileName;

        /// <summary>
        /// Load folder settings from json formatted file.
        /// </summary>
        /// <returns>A list of folder settings. If file doesn't exist null is returned.</returns>
        public List<FolderSetting> Load()
        {
            if (File.Exists(_settingsFileName))
            {
                string jsonContent = File.ReadAllText(_settingsFileName);
                return JsonConvert.DeserializeObject<List<FolderSetting>>(jsonContent);
            }
            return null;
        }

        /// <summary>
        /// Save folder settings in json formatted file.
        /// </summary>
        /// <param name="settings">A list of folder settings</param>
        public void Save(List<FolderSetting> settings)
        {
            string jsonContent = JsonConvert.SerializeObject(settings);            
            File.WriteAllText(_settingsFileName, jsonContent);  // Create/overwrite the file
        }
    }
}
