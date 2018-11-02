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

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Controls.Add(SearchUserControl.Instance);
            panel1.Controls.Add(ListUserControl.Instance);
            panel1.Controls.Add(DownloadUserControl.Instance);
            panel1.Controls.Add(SettingsUserControl.Instance);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchUserControl.Instance.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListUserControl.Instance.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DownloadUserControl.Instance.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SettingsUserControl.Instance.BringToFront();
        }
    }
}
