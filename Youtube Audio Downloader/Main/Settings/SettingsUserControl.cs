using System;
using System.Windows.Forms;

namespace YoutubeAudioDownloader.Main.Settings
{
    public partial class SettingsUserControl : UserControl
    {
        #region INSTANCE
        private static SettingsUserControl instance;
        public static SettingsUserControl Instance { get { instance = (instance ?? new SettingsUserControl()); return instance; } }

        public SettingsService Settings { get; private set; }
        #endregion

        #region CONSTRUCTOR
        private SettingsUserControl()
        {
            InitializeComponent();

            Dock = DockStyle.Fill;

            Settings = SettingsService.CreateOrLoad();

            Startup();
        }
        #endregion

        #region STARTUP
        private void Startup()
        {
            numericUpDownSearchResults.Value = Settings.SearchResults;
            richTextBoxDownloadPath.Text = Settings.DownloadDirectoryPath;
            toggleButtonSilentDownload.ToggleState = Settings.AutoDownload;

            folderBrowserDialogPath.SelectedPath = richTextBoxDownloadPath.Text;
        }
        #endregion

        #region NUMERICUPDOWN_EVENT
        private void numericUpDownSearchResults_ValueChanged(object sender, EventArgs e)
        {
            Settings.SearchResults = ((int)numericUpDownSearchResults.Value);
        }
        #endregion

        #region BUTTONDOWNLOADPATH_EVENT
        private void buttonDownloadPath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogPath.ShowDialog() == DialogResult.OK)
            {
                richTextBoxDownloadPath.Text = folderBrowserDialogPath.SelectedPath;
            }

            Settings.DownloadDirectoryPath = richTextBoxDownloadPath.Text;
        }
        #endregion

        #region TOGGLEBUTTON_EVENT
        private void toggleButtonSilentDownload_ToggleChanged(object sender, EventArgs e)
        {
            Settings.AutoDownload = toggleButtonSilentDownload.ToggleState;
        }
        #endregion

        #region BUTTONRESTORE_EVENT
        private void buttonRestore_Click(object sender, EventArgs e)
        {
            Settings.Reset();

            Startup();
        }
        #endregion
    }
}
