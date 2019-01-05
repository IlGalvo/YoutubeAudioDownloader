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
        #region INSTANCE
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
                        string[] videoIds = await youtubeClient.SearchVideoIdAsync(placeholderRichTextBoxSearch.Text,
                            SettingsUserControl.Instance.Settings.SearchResults);

                        if (videoIds.Length > 0)
                        {
                            ListUserControl.Instance.AddVideo(await youtubeClient.GetVideoInfoAsync(videoIds[0]));

                            ((MainForm)FindForm()).PerformButtonListClick();

                            Task<VideoInfo>[] tasks = new Task<VideoInfo>[videoIds.Length - 1];

                            for (int i = 0; i != tasks.Length; i++)
                            {
                                tasks[i] = youtubeClient.GetVideoInfoAsync(videoIds[i + 1]);
                            }

                            ListUserControl.Instance.AddRangeVideo(await Task.WhenAll(tasks));
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
