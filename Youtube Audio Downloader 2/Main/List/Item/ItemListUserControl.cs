using System.Windows.Forms;

namespace YoutubeAudioDownloader2.Main.List.Item
{
    public partial class ItemListUserControl : UserControl
    {
        public ItemListUserControl()
        {
            InitializeComponent();

            Dock = DockStyle.Top;

            webBrowserVideo.Navigate("https://www.google.it/");
            optimizedLabelTitle.Text = "aaaaaaaaaAbbbbbbbbbBcccccccccCdddddddddDeeeeeeeeeE";
        }
    }
}
