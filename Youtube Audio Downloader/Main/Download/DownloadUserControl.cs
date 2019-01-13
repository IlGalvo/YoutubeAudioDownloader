﻿using System;
using System.Windows.Forms;
using YoutubeAudioDownloader.Main.Download.Item;
using YoutubeAudioDownloader.Main.Settings;
using YoutubeAudioDownloader.Properties;
using YoutubeClientManager.Audio;
using YoutubeClientManager.Video;

namespace YoutubeAudioDownloader.Main.Download
{
    public partial class DownloadUserControl : UserControl
    {
        #region GLOBAL_VARIABLES
        private static DownloadUserControl instance;
        public static DownloadUserControl Instance { get { instance = (instance ?? new DownloadUserControl()); return instance; } }
        #endregion

        #region CONSTRUCTOR
        private DownloadUserControl()
        {
            InitializeComponent();

            Dock = DockStyle.Fill;
        }
        #endregion

        #region DOWNLOAD
        public void AddToDownload(VideoInfo videoInfo, AudioInfo audioInfo, Action actionToPerform)
        {
            panelContent.Controls.Add(new ItemDownloadUserControl(videoInfo, audioInfo, actionToPerform));
            panelContent.Controls[(panelContent.Controls.Count - 1)].BringToFront();

            if (panelContent.Controls.Count == 1)
            {
                panelContent.BackgroundImage = null;

                buttonRemoveAll.Enabled = true;
            }

            if (!SettingsUserControl.Instance.Settings.AutoDownload)
            {
                ((MainForm)FindForm()).PerformButtonDownloadClick();
            }
        }
        #endregion

        #region BUTTON_EVENT
        private void buttonRemoveAll_Click(object sender, EventArgs e)
        {
            if (ManageCancel("Alcuni download/conversioni sono ancora in corso.\n\nVuoi ripristinare comunque la lista?"))
            {
                panelContent.Controls.Clear();

                panelContent.BackgroundImage = Resources.PerformResearch;
            }
        }
        #endregion

        #region CANCEL
        public bool ManageCancel(string text)
        {
            bool cancelRequired = true;

            foreach (ItemDownloadUserControl entryDownloadUserControl in panelContent.Controls)
            {
                if (entryDownloadUserControl.IsRunning)
                {
                    if (MessageBox.Show(text, "Domanda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        cancelRequired = false;
                    }

                    break;
                }
            }

            return cancelRequired;
        }
        #endregion

        #region PANEL_EVENT
        private void panelContent_ControlRemoved(object sender, ControlEventArgs e)
        {
            e.Control.Dispose();

            if (panelContent.Controls.Count == 0)
            {
                buttonRemoveAll.Enabled = false;
            }
        }
        #endregion
    }
}
