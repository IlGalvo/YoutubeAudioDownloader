using System.Windows.Forms;

namespace YoutubeAudioDownloader2.Main.List.Item
{
    public partial class EntryListUserControl : UserControl
    {
        public EntryListUserControl()
        {
            InitializeComponent();

            Dock = DockStyle.Top;

            webBrowserVideo.Navigate("https://www.google.it/");
            optimizedLabelTitle.Text = "aaaaaaaaaAbbbbbbbbbBcccccccccCdddddddddDeeeeeeeeeE";
        }

        private void linkLabelShowExtra_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (InformationForm informationForm = new InformationForm())
            {
                informationForm.ShowDialog();
            }
        }
    }
}
