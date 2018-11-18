using System.Windows.Forms;

namespace YoutubeAudioDownloader2.Main.Settings
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
    }
}
