using System;
using System.Windows.Forms;
using YoutubeAudioDownloader2.Main.Download.Item;
using YoutubeAudioDownloader2.Main.Settings;
using YoutubeClientManager.Audio;
using YoutubeClientManager.Video;

namespace YoutubeAudioDownloader2.Main.Download
{
    public partial class DownloadUserControl : UserControl
    {
        #region INSTANCE
        private static DownloadUserControl instance;
        public static DownloadUserControl Instance { get { if (instance == null) { instance = new DownloadUserControl(); } return instance; } }
        #endregion

        #region CONSTRUCTOR
        public DownloadUserControl()
        {
            InitializeComponent();

            Dock = DockStyle.Fill;
        }
        #endregion

        #region DOWNLOAD
        public void AddToDownload(VideoInfo videoInfo, AudioInfo audioInfo, Action actionToPerform)
        {
            panelContent.Controls.Add(new EntryDownloadUserControl(videoInfo, audioInfo, actionToPerform));
            panelContent.Controls[(panelContent.Controls.Count - 1)].BringToFront();

            buttonRemoveAll.Enabled = true;

            if (!SettingsManager.Instance.AutoDownload)
            {
                ((MainForm)FindForm()).PerformButtonListClick();
            }
        }
        #endregion

        #region BUTTON_EVENT
        private void buttonRemoveAll_Click(object sender, EventArgs e)
        {
            if (ManageCancel("Alcuni download/conversioni sono ancora in corso.\n\nVuoi ripristinare comunque la lista?"))
            {
                panelContent.Controls.Clear();
            }
        }
        #endregion

        #region CANCEL
        public bool ManageCancel(string text)
        {
            bool cancelRequired = true;

            foreach (EntryDownloadUserControl entryDownloadUserControl in panelContent.Controls)
            {
                if (entryDownloadUserControl.IsRunning)
                {
                    if (MessageBox.Show(text, "Domanda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        cancelRequired = false;
                    }

                    break;
                }
            }

            return cancelRequired;
        }
        #endregion

        #region PANEL_EVENT
        private void panelContent_ControlRemoved(object sender, ControlEventArgs e)
        {
            e.Control.Dispose();

            if (panelContent.Controls.Count == 0)
            {
                buttonRemoveAll.Enabled = false;
            }
        }
        #endregion
    }
}
