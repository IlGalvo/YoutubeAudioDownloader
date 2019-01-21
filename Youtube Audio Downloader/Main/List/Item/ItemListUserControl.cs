using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using YoutubeAudioDownloader.Main.Download;
using YoutubeClientManager.Video;

namespace YoutubeAudioDownloader.Main.List.Item
{
    public partial class ItemListUserControl : UserControl
    {
        #region GLOBAL_VARIABLES
        private VideoInfo videoInfo;
        #endregion

        #region CONSTRUCTOR
        public ItemListUserControl(VideoInfo videoInfo)
        {
            InitializeComponent();

            Dock = DockStyle.Top;

            this.videoInfo = videoInfo;

            Startup();
        }
        #endregion

        #region STARTUP
        private void Startup()
        {
            webBrowserVideo.Navigate(videoInfo.GetEmbedUrl());

            labelAuthor.Text = videoInfo.Author;
            resizableLabelTitle.Text = videoInfo.Title;
            labelDuration.Text = videoInfo.Duration.ToString();
            labelDate.Text = videoInfo.UploadDate.ToString("dd/MM/yyyy");
            labelRating.Text = (videoInfo.Statistics.AverageRating + "/5");

            labelEncoding.Text = (videoInfo.AudioInfo.Container + "/" + videoInfo.AudioInfo.Encoding);
            labelBitrate.Text = (Math.Round((videoInfo.AudioInfo.Bitrate / 1000f), MidpointRounding.ToEven) + " Kbps");
            labelSize.Text = ((((videoInfo.AudioInfo.Size * 2.5) / 1024f) / 1024f).ToString("00.00") + " MB");

            buttonDownload.Enabled = true;
        }
        #endregion

        #region WEBBROWSER_EVENT
        private void webBrowserVideo_NewWindow(object sender, CancelEventArgs e)
        {
            e.Cancel = true;

            Process.Start(videoInfo.GetRegularUrl()).Dispose();
        }
        #endregion

        #region LINKLABEL_EVENT
        private void linkLabelShowExtra_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (InformationForm informationForm = new InformationForm(videoInfo))
            {
                informationForm.ShowDialog();
            }
        }
        #endregion

        #region BUTTON_EVENT
        private void buttonDownload_Click(object sender, EventArgs e)
        {
            DownloadUserControl.Instance.AddToDownload(videoInfo, EnableDownloadButton);

            buttonDownload.Enabled = false;
        }
        #endregion

        #region RESET
        private void EnableDownloadButton()
        {
            buttonDownload.Enabled = true;
        }
        #endregion
    }
}
