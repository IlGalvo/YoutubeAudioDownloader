using System.Windows.Forms;

namespace YoutubeAudioDownloader2.Main.Download.Item
{
    public partial class ItemDownloadUserControl : UserControl
    {
        private static ItemDownloadUserControl instance;
        public static ItemDownloadUserControl Instance { get { if (instance == null) { instance = new ItemDownloadUserControl(); } return instance; } }

        public ItemDownloadUserControl()
        {
            InitializeComponent();

            Dock = DockStyle.Top;
        }
    }
}
