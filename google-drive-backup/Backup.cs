using google_drive_backup_core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace google_drive_backup
{
    class Backup
    {
        public Backup(List<FolderSetting> folderSettings, log4net.ILog log)
        {
            _folderSettings = folderSettings;
            _log = log;
        }

        private readonly List<FolderSetting> _folderSettings;
        private readonly log4net.ILog _log;

        public void Start()
        {
            var taskArray = new Task[_folderSettings.Count];
            for (int i = 0; i < taskArray.Length; i++)
            {
                FolderSetting folderSetting = _folderSettings[i];
                taskArray[i] = Task.Run(() => DoTask(folderSetting));
            }
            _log.Info("Waiting for tasks to finish.");
            Task.WaitAll(taskArray);
            _log.Info("Tasks have finished.");
        }

        private void DoTask(FolderSetting folderSetting)
        {
            Thread.Sleep(500);
            _log.Info("Task finished.");
        }
    }
}
