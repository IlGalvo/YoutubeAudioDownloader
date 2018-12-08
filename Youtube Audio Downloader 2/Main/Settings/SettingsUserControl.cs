using System;
using System.Windows.Forms;

namespace YoutubeAudioDownloader2.Main.Settings
{
    public partial class SettingsUserControl : UserControl
    {
        #region GLOBAL_VARIABLES
        private static SettingsUserControl instance;
        public static SettingsUserControl Instance { get { if (instance == null) { instance = new SettingsUserControl(); } return instance; } }
        #endregion

        private SettingsUserControl()
        {
            InitializeComponent();

            Dock = DockStyle.Fill;

            numericUpDownSearchResults.Value = SettingsManager.Instance.SearchResults;
            richTextBoxDownloadPath.Text = SettingsManager.Instance.DownloadDirectory;
            toggleButtonSilentDownload.ToggleState = SettingsManager.Instance.AutoDownload;

            folderBrowserDialogPath.SelectedPath = richTextBoxDownloadPath.Text;
        }

        private void numericUpDownSearchResults_ValueChanged(object sender, EventArgs e)
        {
            SettingsManager.Instance.SearchResults = ((int)numericUpDownSearchResults.Value);
        }

        private void buttonDownloadPath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogPath.ShowDialog() == DialogResult.OK)
            {
                richTextBoxDownloadPath.Text = folderBrowserDialogPath.SelectedPath;
            }

            SettingsManager.Instance.DownloadDirectory = richTextBoxDownloadPath.Text;
        }

        private void toggleButtonSilentDownload_ToggleChanged(object sender, EventArgs e)
        {
            SettingsManager.Instance.AutoDownload = toggleButtonSilentDownload.ToggleState;
        }

        private void buttonRestore_Click(object sender, EventArgs e)
        {
            SettingsManager.Instance.ResetSettings();

            numericUpDownSearchResults.Value = SettingsManager.Instance.SearchResults;
            richTextBoxDownloadPath.Text = SettingsManager.Instance.DownloadDirectory;
            toggleButtonSilentDownload.ToggleState = SettingsManager.Instance.AutoDownload;
        }
    }
}
