using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeAudioDownloader2.Main.List;
using YoutubeClientManager;
using YoutubeClientManager.Video;

namespace YoutubeAudioDownloader2.Main.Search
{
    public partial class SearchUserControl : UserControl
    {
        #region INSTANCE
        private static SearchUserControl instance;
        public static SearchUserControl Instance { get { if (instance == null) { instance = new SearchUserControl(); } return instance; } }
        #endregion

        #region CONSTRUCTOR
        private SearchUserControl()
        {
            InitializeComponent();

            Dock = DockStyle.Fill;
        }
        #endregion

        #region OPTIMIZEDTEXTBOX_EVENT
        private void optimizedTextBoxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSearch.PerformClick();
            }
        }
        #endregion

        #region BUTTON_EVENT
        private async void buttonSearch_ClickAsync(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(optimizedTextBoxSearch.Text))
            {
                ListUserControl.Instance.ClearAllVideo();

                panelLoading.Visible = true;
                buttonSearch.Enabled = false;

                try
                {
                    using (YoutubeClient youtubeClient = new YoutubeClient())
                    {
                        string[] videoIds = await youtubeClient.SearchVideoIdAsync(optimizedTextBoxSearch.Text, 5);

                        if (videoIds.Length > 0)
                        {
                            ListUserControl.Instance.AddVideo(await youtubeClient.GetVideoInfoAsync(videoIds[0]));

                            ((MainForm)FindForm()).buttonList_Click(sender, e);

                            Task<VideoInfo>[] tasks = new Task<VideoInfo>[videoIds.Length - 1];

                            for (int i = 0; i != tasks.Length; i++)
                            {
                                tasks[i] = youtubeClient.GetVideoInfoAsync(videoIds[i + 1]);
                            }

                            ListUserControl.Instance.AddRangeVideo(await Task.WhenAll(tasks));

                            panelLoading.Visible = false;
                            buttonSearch.Enabled = true;
                        }
                        else
                        {
                            //labelInformation.Text = "Nessun risultato.";
                        }
                    }
                }
                catch (Exception)
                {
                    //labelInformation.Text = ("Errore: " + exception.Message);
                }
            }
            else
            {
                //labelInformation.Text = "Cerca qualcosa!";
            }
        }
        #endregion
    }
}
