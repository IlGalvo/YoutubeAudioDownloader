using System.Windows.Forms;
using YoutubeAudioDownloader2.Main.List.Item;

namespace YoutubeAudioDownloader2.Main.List
{
    public partial class ListUserControl : UserControl
    {
        private static ListUserControl instance;
        public static ListUserControl Instance { get { if (instance == null) { instance = new ListUserControl(); } return instance; } }

        public ListUserControl()
        {
            InitializeComponent();

            Dock = DockStyle.Fill;
        }

        private void buttonShowAll_Click(object sender, System.EventArgs e)
        {
            panelContent.Controls.Add(new EntryListUserControl());
            /*panelContent.Controls.Add(new ItemListUserControl());
            panelContent.Controls.Add(new ItemListUserControl());*/
        }
    }
}
