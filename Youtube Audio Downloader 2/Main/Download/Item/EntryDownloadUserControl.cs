using System;
using System.Windows.Forms;

namespace YoutubeAudioDownloader2.Main.Download.Item
{
    public partial class EntryDownloadUserControl : UserControl
    {
        public EntryDownloadUserControl()
        {
            InitializeComponent();

            Dock = DockStyle.Top;

            labelInformation.Text = "Errore: Si è verificato un errore durante la conversione.";
            coloredProgressBarDownload.Value = new Random().Next(0, 100);
        }
    }
}
