using CustomControlCollection.Settings;
using System;
using System.IO;
using System.Windows.Forms;

namespace YoutubeAudioDownloader.Main.Settings
{
    public class SettingsService : SettingsManager<SettingsService>
    {
        #region GLOBAL_VARIABLES
        private static readonly string AppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private static readonly string DirectoryPath = Path.Combine(AppDataPath, Application.ProductName);
        public static string SettingsPath { get { return Path.Combine(DirectoryPath, (nameof(SettingsService) + ".xml")); } }

        public static int MinSearchResults { get { return 1; } }
        public static int DefaultSearchResults { get { return 5; } }
        public static int MaxSearchResults { get { return 20; } }

        private int searchResults;
        public int SearchResults
        {
            get
            {
                return searchResults;
            }
            set
            {
                if ((value < MinSearchResults) && (value > MaxSearchResults))
                {
                    string message = ("Value must be between " + MinSearchResults + " and " + MaxSearchResults + ".");

                    throw (new ArgumentOutOfRangeException(nameof(SearchResults), message));
                }

                searchResults = value;
            }
        }

        private string downloadDirectory;
        public string DownloadDirectory
        {
            get
            {
                return downloadDirectory;
            }
            set
            {
                if ((new Uri(value)).IsWellFormedOriginalString())
                {
                    throw (new ArgumentException(nameof(DownloadDirectory), "Invalid directory path."));
                }

                downloadDirectory = value;
            }
        }

        public bool AutoDownload { get; set; }
        #endregion

        #region CONSTRUCTOR
        public SettingsService()
        {
            Reset();
        }
        #endregion

        #region RESET
        public void Reset()
        {
            SearchResults = DefaultSearchResults;
            DownloadDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            AutoDownload = true;
        }
        #endregion
    }
}

