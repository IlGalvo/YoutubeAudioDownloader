using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeAudioDownloader.Main.List;
using YoutubeAudioDownloader.Main.Settings;
using YoutubeClientManager;
using YoutubeClientManager.Video;

namespace YoutubeAudioDownloader.Main.Search
{
    public partial class SearchUserControl : UserControl
    {
        #region GLOBAL_VARIABLES
        private static SearchUserControl instance;
        public static SearchUserControl Instance { get { instance = (instance ?? new SearchUserControl()); return instance; } }
        #endregion

        #region CONSTRUCTOR
        private SearchUserControl()
        {
            InitializeComponent();

            Dock = DockStyle.Fill;

            labelInformation.Text = string.Empty;
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
            labelInformation.Text = string.Empty;

            if (!string.IsNullOrEmpty(placeholderRichTextBoxSearch.Text))
            {
                ListUserControl.Instance.ClearAllVideo();

                panelLoading.Visible = true;
                buttonSearch.Enabled = false;

                try
                {
                    using (YoutubeClient youtubeClient = new YoutubeClient())
                    {
                        string[] videosId = await youtubeClient.SearchVideoIdAsync(placeholderRichTextBoxSearch.Text,
                            SettingsUserControl.Instance.Settings.SearchResults);

                        if (videosId.Length > 0)
                        {
                            ListUserControl.Instance.AddVideo(await youtubeClient.GetVideoInfoAsync(videosId[0]));

                            ((MainForm)FindForm()).PerformButtonListClick();

                            Task<VideoInfo>[] videoInfoTasks = new Task<VideoInfo>[videosId.Length - 1];

                            for (int i = 0; i != videoInfoTasks.Length; i++)
                            {
                                videoInfoTasks[i] = youtubeClient.GetVideoInfoAsync(videosId[i + 1]);
                            }

                            ListUserControl.Instance.AddRangeVideo(await Task.WhenAll(videoInfoTasks));
                        }
                        else
                        {
                            labelInformation.Text = "Nessun risultato.";
                        }
                    }
                }
                catch (Exception exception)
                {
                    labelInformation.Text = ("Errore: " + exception.Message);
                }
                finally
                {
                    panelLoading.Visible = false;
                    buttonSearch.Enabled = true;
                }
            }
        }
        #endregion
    }
}
