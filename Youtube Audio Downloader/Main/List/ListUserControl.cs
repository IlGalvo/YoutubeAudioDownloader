using System;
using System.Windows.Forms;
using YoutubeAudioDownloader.Main.List.Item;
using YoutubeClientManager.Video;

namespace YoutubeAudioDownloader.Main.List
{
    public partial class ListUserControl : UserControl
    {
        #region GLOBAL_VARIABLES
        private static ListUserControl instance;
        public static ListUserControl Instance { get { instance = (instance ?? new ListUserControl()); return instance; } }

        private VideoInfo[] videoInfos;
        #endregion

        #region CONSTRUCTOR
        private ListUserControl()
        {
            InitializeComponent();

            Dock = DockStyle.Fill;
        }
        #endregion

        #region VIDEO_MANAGERS
        public void AddVideo(VideoInfo videoInfo)
        {
            panelContent.Controls.Add(new ItemListUserControl(videoInfo));
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
        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            foreach (VideoInfo videoInfo in videoInfos)
            {
                panelContent.Controls.Add(new ItemListUserControl(videoInfo));

                panelContent.Controls[(panelContent.Controls.Count - 1)].BringToFront();
            }

            buttonShowAll.Enabled = false;
        }
        #endregion
    }
}
