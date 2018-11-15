using System.Windows.Forms;

namespace YoutubeAudioDownloader2.Main
{
    public partial class SettingsUserControl : UserControl
    {
        private static SettingsUserControl instance;
        public static SettingsUserControl Instance { get { if (instance == null) { instance = new SettingsUserControl(); } return instance; } }

        public SettingsUserControl()
        {
            InitializeComponent();

            Dock = DockStyle.Fill;
        }

        private void buttonRestore_Click(object sender, System.EventArgs e)
        {

        }
    }
}
