using CustomControlCollection.Settings;
using System;
using System.IO;
using System.Windows.Forms;

namespace YoutubeAudioDownloader.Main.Settings
{
    public class SettingsService : SettingsManager<SettingsService>
    {
        #region GLOBAL_VARIABLES
        public static string DefaultSettingsPath
        {
            get
            {
                return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                    Path.Combine(Application.ProductName, (nameof(SettingsService) + ".xml")));
            }
        }

        public static int MinimumSearchResults { get { return 1; } }
        public static int MaximumSearchResults { get { return 20; } }

        public static int DefaultSearchResults { get { return 5; } }
        public static string DefaultDownloadDirectoryPath { get { return Environment.GetFolderPath(Environment.SpecialFolder.MyMusic); } }
        public static bool DefaultAutoDownload { get { return false; } }

        public int SearchResults { get; set; }
        public string DownloadDirectoryPath { get; set; }
        public bool AutoDownload { get; set; }
        #endregion

        #region CONSTRUCTOR
        public SettingsService()
        {
            Reset();
        }
        #endregion

        #region CREATELOAD
        public static SettingsService CreateOrLoad()
        {
            return CreateOrLoad(DefaultSettingsPath);
        }
        #endregion

        #region SAVE
        public void Save()
        {
            Save(DefaultSettingsPath);
        }
        #endregion

        #region RESET
        public void Reset()
        {
            SearchResults = DefaultSearchResults;
            DownloadDirectoryPath = DefaultDownloadDirectoryPath;
            AutoDownload = DefaultAutoDownload;
        }
        #endregion
    }
}

