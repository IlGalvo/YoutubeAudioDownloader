using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using YoutubeAudioDownloader2.Main.Download;
using YoutubeClientManager.Audio;
using YoutubeClientManager.Video;

namespace YoutubeAudioDownloader2.Main.List.Item
{
    public partial class EntryListUserControl : UserControl
    {
        #region GLOBAL_VARIABLES
        private VideoInfo videoInfo;

        private AudioInfo audioInfo;
        #endregion

        #region CONSTRUCTOR
        public EntryListUserControl(VideoInfo videoInfo)
        {
            InitializeComponent();

            Dock = DockStyle.Top;

            this.videoInfo = videoInfo;
            audioInfo = null;

            StartupAsync();
        }
        #endregion

        #region STARTUP
        private async void StartupAsync()
        {
            webBrowserVideo.Navigate(videoInfo.GetEmbedUrl());

            labelAuthor.Text = videoInfo.Author;
            resizableLabelTitle.Text = videoInfo.Title;
            labelDuration.Text = videoInfo.Duration.ToString();
            labelDate.Text = videoInfo.UploadDate.ToString("dd/MM/yyyy");
            labelRating.Text = (videoInfo.Statistics.AverageRating + "/5");

            labelEncoding.Text = "Attendere...";
            labelBitrate.Text = "Attendere...";
            labelSize.Text = "Attendere...";

            try
            {
                audioInfo = await videoInfo.GetAudioInfoAsync();

                labelEncoding.Text = (audioInfo.Container + "/" + audioInfo.Encoding);
                labelBitrate.Text = (Math.Round((audioInfo.Bitrate / 1000f), MidpointRounding.ToEven) + " Kbps");
                labelSize.Text = ((((audioInfo.Size * 2.5) / 1024f) / 1024f).ToString("00.00") + " MB");

                buttonDownload.Enabled = true;
            }
            catch (Exception)
            {
                labelEncoding.Text = "Errore ricezione informazioni.";
                labelBitrate.Text = "Errore ricezione informazioni.";
                labelSize.Text = "Errore ricezione informazioni.";
            }
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
            DownloadUserControl.Instance.AddToDownload(videoInfo, audioInfo, EnableDownloadButton);

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
