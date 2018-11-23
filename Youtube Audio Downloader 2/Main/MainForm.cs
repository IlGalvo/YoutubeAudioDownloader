using System;
using System.Drawing;
using System.Windows.Forms;
using YoutubeAudioDownloader2.Main.Download;
using YoutubeAudioDownloader2.Main.List;
using YoutubeAudioDownloader2.Main.Search;
using YoutubeAudioDownloader2.Main.Settings;

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

        private void buttonResearch_Click(object sender, EventArgs e)
        {
            ManageButtonMenuColor(sender);

            SearchUserControl.Instance.BringToFront();
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            ManageButtonMenuColor(sender);

            ListUserControl.Instance.BringToFront();
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            ManageButtonMenuColor(sender);

            DownloadUserControl.Instance.BringToFront();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            ManageButtonMenuColor(sender);

            SettingsUserControl.Instance.BringToFront();
        }

        private void ManageButtonMenuColor(object sender)
        {
            foreach (Button button in tableLayoutPanelMenu.Controls)
            {
                button.BackColor = ((button == ((Button)sender)) ? Color.LightGreen : Color.Honeydew);
            }
        }
    }
}
