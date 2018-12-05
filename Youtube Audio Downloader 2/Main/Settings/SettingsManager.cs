using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace YoutubeAudioDownloader2.Main.Settings
{
    public sealed class SettingsManager
    {
        #region GLOBAL_VARIABLES
        private static SettingsManager instance;
        public static SettingsManager Instance { get { if (instance == null) { instance = new SettingsManager(); } return instance; } }

        public static readonly int MinSearchResults = 1;
        public static readonly int DefaultSearchResults = 5;
        public static readonly int MaxSearchResults = 20;

        #region WRAPPER
        public class Settings
        {
            #region GLOBAL_VARIABLES
            public bool AutoDownload { get; set; }

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
            #endregion

            #region CONSTRUCTOR
            public Settings()
            {
                AutoDownload = true;
                DownloadDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
                SearchResults = DefaultSearchResults;
            }
            #endregion
        }
        #endregion

        private static readonly string AppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private static readonly string Directorypath = Path.Combine(AppDataPath, Application.ProductName);
        private static readonly string SettingsPath = Path.Combine(Directorypath, "Settings.xml");

        public bool AutoDownload { get { return settings.AutoDownload; } set { settings.AutoDownload = value; } }
        public string DownloadDirectory { get { return settings.DownloadDirectory; } set { settings.DownloadDirectory = value; } }
        public int SearchResults { get { return settings.SearchResults; } set { settings.SearchResults = value; } }

        private Settings settings;
        #endregion

        #region CONSTRUCTOR
        private SettingsManager()
        {
            if (!Directory.Exists(Directorypath))
            {
                Directory.CreateDirectory(Directorypath);
            }

            if (!File.Exists(SettingsPath))
            {
                settings = new Settings();

                SaveSettings();
            }
            else
            {
                using (StreamReader streamReader = new StreamReader(SettingsPath))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Settings));

                    settings = ((Settings)xmlSerializer.Deserialize(streamReader));
                }
            }
        }
        #endregion

        #region SAVE
        public void SaveSettings()
        {
            using (StreamWriter streamWriter = new StreamWriter(SettingsPath))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Settings));

                xmlSerializer.Serialize(streamWriter, settings);
            }
        }
        #endregion

        public void ResetSettings()
        {
            settings = new Settings();
        }
    }
}
