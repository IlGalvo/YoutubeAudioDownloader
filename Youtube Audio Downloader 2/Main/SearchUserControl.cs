using System;
using System.Windows.Forms;

namespace YoutubeAudioDownloader2.Main
{
    public partial class SearchUserControl : UserControl
    {
        private static SearchUserControl instance;
        public static SearchUserControl Instance { get { if (instance == null) { instance = new SearchUserControl(); } return instance; } }

        private SearchUserControl()
        {
            InitializeComponent();

            Dock = DockStyle.Fill;
        }

        private void optimizedTextBoxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSearch.PerformClick();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Ricerca in corso...");
        }
    }
}
