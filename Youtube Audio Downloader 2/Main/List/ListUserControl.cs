using System.Windows.Forms;
using YoutubeAudioDownloader2.Main.List.Temp;

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

        private void button1_Click(object sender, System.EventArgs e)
        {
            panel2.Controls.Add(new TempUserControl());
            panel2.Controls.Add(new TempUserControl());
            panel2.Controls.Add(new TempUserControl());
        }
    }
}
