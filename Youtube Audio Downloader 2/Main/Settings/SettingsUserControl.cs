using System;
using System.Windows.Forms;

namespace YoutubeAudioDownloader2.Main.Settings
{
    public partial class SettingsUserControl : UserControl
    {
        #region GLOBAL_VARIABLES
        private static SettingsUserControl instance;
        public static SettingsUserControl Instance { get { if (instance == null) { instance = new SettingsUserControl(); } return instance; } }

        public SettingsManager Settings { get; private set; }
        #endregion

        public SettingsUserControl()
        {
            InitializeComponent();

            Dock = DockStyle.Fill;

            Settings = SettingsManager.CreateOrLoadSettings();

            numericUpDownSearchResults.Value = Settings.SearchResults;
            richTextBoxDownloadPath.Text = Settings.DownloadDirectory;
            toggleButtonSilentDownload.ToggleState = Settings.AutoDownload;

            folderBrowserDialogPath.SelectedPath = richTextBoxDownloadPath.Text;
        }

        private void numericUpDownSearchResults_ValueChanged(object sender, EventArgs e)
        {
            Settings.SearchResults = ((int)numericUpDownSearchResults.Value);
        }

        private void buttonDownloadPath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogPath.ShowDialog() == DialogResult.OK)
            {
                richTextBoxDownloadPath.Text = folderBrowserDialogPath.SelectedPath;
            }

            Settings.DownloadDirectory = richTextBoxDownloadPath.Text;
        }

        private void toggleButtonSilentDownload_ToggleChanged(object sender, EventArgs e)
        {
            Settings.AutoDownload = toggleButtonSilentDownload.ToggleState;
        }
    }
}
