using System;
using System.Windows.Forms;
using YoutubeAudioDownloader2.Main.Download.Item;
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

        public DownloadUserControl()
        {
            InitializeComponent();

            Dock = DockStyle.Fill;
        }

        public void AddToDownload(VideoInfo videoInfo, AudioInfo audioInfo, Action actionToPerform)
        {
            panelContent.Controls.Add(new EntryDownloadUserControl(videoInfo, audioInfo, actionToPerform));
            panelContent.Controls[(panelContent.Controls.Count - 1)].BringToFront();

            buttonRemoveAll.Enabled = true;
        }

        private void buttonRemoveAll_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();

            buttonRemoveAll.Enabled = false;
        }

        private void panelContent_ControlRemoved(object sender, ControlEventArgs e)
        {
            e.Control.Dispose();

            if (panelContent.Controls.Count == 0)
            {
                buttonRemoveAll.Enabled = false;
            }
        }
    }
}
