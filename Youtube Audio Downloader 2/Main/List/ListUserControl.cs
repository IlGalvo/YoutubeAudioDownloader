using System.Windows.Forms;
using YoutubeAudioDownloader2.Main.List.Item;
using YoutubeClientManager.Video;

namespace YoutubeAudioDownloader2.Main.List
{
    public partial class ListUserControl : UserControl
    {
        #region GLOBAL_VARIABLES
        private static ListUserControl instance;
        public static ListUserControl Instance { get { if (instance == null) { instance = new ListUserControl(); } return instance; } }

        private VideoInfo[] videoInfos;
        #endregion

        #region CONSTRUCTOR
        public ListUserControl()
        {
            InitializeComponent();

            Dock = DockStyle.Fill;
        }
        #endregion

        #region VIDEO_MANAGER
        public void AddVideo(VideoInfo videoInfo)
        {
            panelContent.Controls.Add(new EntryListUserControl(videoInfo));

            panelContent.Controls[(panelContent.Controls.Count - 1)].BringToFront();
        }

        public void AddRangeVideo(VideoInfo[] videoInfos)
        {
            this.videoInfos = videoInfos;

            buttonShowAll.Enabled = true;
        }

        public void ClearAllVideo()
        {
            panelContent.Controls.Clear();
        }
        #endregion

        #region BUTTON_EVENT
        private void buttonShowAll_Click(object sender, System.EventArgs e)
        {
            foreach (VideoInfo videoInfo in videoInfos)
            {
                panelContent.Controls.Add(new EntryListUserControl(videoInfo));
            }

            buttonShowAll.Enabled = false;
        }
        #endregion
    }
}
