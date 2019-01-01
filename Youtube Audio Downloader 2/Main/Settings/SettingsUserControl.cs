using System;
using System.Windows.Forms;

namespace YoutubeAudioDownloader.Main.Settings
{
    public partial class SettingsUserControl : UserControl
    {
        #region INSTANCE
        private static SettingsUserControl instance;
        public static SettingsUserControl Instance { get { if (instance == null) { instance = new SettingsUserControl(); } return instance; } }
        #endregion

        #region CONSTRUCTOR
        private SettingsUserControl()
        {
            InitializeComponent();

            Dock = DockStyle.Fill;

            Startup();
        }
        #endregion

        #region STARTUP
        private void Startup()
        {
            numericUpDownSearchResults.Value = SettingsManager.Instance.SearchResults;
            richTextBoxDownloadPath.Text = SettingsManager.Instance.DownloadDirectory;
            toggleButtonSilentDownload.ToggleState = SettingsManager.Instance.AutoDownload;

            folderBrowserDialogPath.SelectedPath = richTextBoxDownloadPath.Text;
        }
        #endregion

        #region NUMERICUPDOWN_EVENT
        private void numericUpDownSearchResults_ValueChanged(object sender, EventArgs e)
        {
            SettingsManager.Instance.SearchResults = ((int)numericUpDownSearchResults.Value);
        }
        #endregion

        #region BUTTONDOWNLOADPATH_EVENT
        private void buttonDownloadPath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogPath.ShowDialog() == DialogResult.OK)
            {
                richTextBoxDownloadPath.Text = folderBrowserDialogPath.SelectedPath;
            }

            SettingsManager.Instance.DownloadDirectory = richTextBoxDownloadPath.Text;
        }
        #endregion

        #region TOGGLEBUTTON_EVENT
        private void toggleButtonSilentDownload_ToggleChanged(object sender, EventArgs e)
        {
            SettingsManager.Instance.AutoDownload = toggleButtonSilentDownload.ToggleState;
        }
        #endregion

        #region BUTTONRESTORE_EVENT
        private void buttonRestore_Click(object sender, EventArgs e)
        {
            SettingsManager.Instance.ResetSettings();

            Startup();
        }
        #endregion
    }
}
