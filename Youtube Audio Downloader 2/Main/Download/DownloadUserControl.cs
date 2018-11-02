using System.Windows.Forms;

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
    }
}
