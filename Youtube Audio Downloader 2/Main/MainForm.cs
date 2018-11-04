using System;
using System.Windows.Forms;
using YoutubeAudioDownloader2.Main.Download;
using YoutubeAudioDownloader2.Main.List;

namespace YoutubeAudioDownloader2.Main
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            panelContent.Controls.Add(SearchUserControl.Instance);
            panelContent.Controls.Add(ListUserControl.Instance);
            panelContent.Controls.Add(DownloadUserControl.Instance);
            panelContent.Controls.Add(SettingsUserControl.Instance);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SearchUserControl.Instance.BringToFront();
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            ListUserControl.Instance.BringToFront();
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            DownloadUserControl.Instance.BringToFront();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            SettingsUserControl.Instance.BringToFront();
        }
    }
}
