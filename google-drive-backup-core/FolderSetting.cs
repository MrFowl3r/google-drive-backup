using System.Collections.Generic;

namespace google_drive_backup_core
{
    /// <summary>
    /// A class for what path to backup and file patterns in this path to ignore.
    /// </summary>
    public class FolderSetting
    {
        public string Path { get; set; }
        public List<string> IgnorePatterns { get; set; }
    }
}
