﻿using google_drive_backup_core;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace google_drive_backup
{
    class Program
    {
        private static readonly log4net.ILog _log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            string settingsFileName = ConfigurationManager.AppSettings["SettingsFileName"];
            var settingsLoader = new FolderSettingLoader(settingsFileName);
            var folderSettings = settingsLoader.Load();
            if (folderSettings == null)
            {
                _log.Error(string.Format("Failed to load folder settings. The following file path may not exist: {0}", settingsFileName));
                return;
            }

            
        }
    }
}
