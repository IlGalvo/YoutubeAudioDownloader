using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using YoutubeAudioDownloader2.Main.Download;
using YoutubeAudioDownloader2.Main.List;
using YoutubeAudioDownloader2.Main.Search;
using YoutubeAudioDownloader2.Main.Settings;

namespace YoutubeAudioDownloader2.Main
{
    public partial class MainForm : Form
    {
        #region GLOBAL_VARIABLE
        private static readonly Dictionary<Button, UserControl> controlsDictionary = new Dictionary<Button, UserControl>();
        #endregion

        #region FORM_EVENTS
        public MainForm()
        {
            InitializeComponent();

            controlsDictionary.Add(buttonResearch, SearchUserControl.Instance);
            controlsDictionary.Add(buttonList, ListUserControl.Instance);
            controlsDictionary.Add(buttonDownload, DownloadUserControl.Instance);
            controlsDictionary.Add(buttonSettings, SettingsUserControl.Instance);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            buttonResearch.PerformClick();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string text = "Alcuni download/conversioni sono ancora in corso.\n\nVuoi chiudere comunque l'applicazione?";

            e.Cancel = (!DownloadUserControl.Instance.ManageCancel(text));
        }
        #endregion

        #region BUTTONS_EVENT
        private void menuButtons_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<Button, UserControl> keyValuePair in controlsDictionary)
            {
                bool clickedButton = (keyValuePair.Key == ((Button)sender));

                keyValuePair.Key.BackColor = (clickedButton ? Color.LightGreen : Color.Honeydew);
                keyValuePair.Value.Visible = clickedButton;
            }
        }
        #endregion

        #region PERFORMCLICK_MANAGERS
        public void PerformButtonListClick()
        {
            buttonList.PerformClick();
        }

        public void PerformButtonDownloadClick()
        {
            buttonDownload.PerformClick();
        }
        #endregion
    }
}
