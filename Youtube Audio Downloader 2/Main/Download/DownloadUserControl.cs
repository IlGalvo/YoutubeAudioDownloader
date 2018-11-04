using System.Windows.Forms;
using YoutubeAudioDownloader2.Main.Download.Item;

namespace YoutubeAudioDownloader2.Main.Download
{
    public partial class DownloadUserControl : UserControl
    {
        private static DownloadUserControl instance;
        public static DownloadUserControl Instance { get { if (instance == null) { instance = new DownloadUserControl(); } return instance; } }

        public DownloadUserControl()
        {
            InitializeComponent();

            Dock = DockStyle.Fill;
        }

        private void buttonRemoveAll_Click(object sender, System.EventArgs e)
        {
            panelContent.Controls.Add(new ItemDownloadUserControl());
            panelContent.Controls.Add(new ItemDownloadUserControl());
            panelContent.Controls.Add(new ItemDownloadUserControl());
        }
    }
}
