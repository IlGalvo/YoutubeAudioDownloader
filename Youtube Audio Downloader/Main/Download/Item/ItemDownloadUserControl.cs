using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using YoutubeAudioDownloader.Main.Settings;
using YoutubeClientManager.Converter;
using YoutubeClientManager.Video;
using YoutubeClientManager.Video.Audio;

namespace YoutubeAudioDownloader.Main.Download.Item
{
    public partial class ItemDownloadUserControl : UserControl
    {
        #region GLOBAL_VARIABLES
        public bool IsRunning { get; private set; }

        private ConverterMp3 converterMp3;

        private VideoInfo videoInfo;
        private string downloadPath;
        private Action actionToPerform;

        private object lockObject;
        #endregion

        #region USERCONTROL_EVENTS
        public ItemDownloadUserControl(VideoInfo videoInfo, Action actionToPerform)
        {
            InitializeComponent();

            Dock = DockStyle.Top;

            converterMp3 = new ConverterMp3();

            this.videoInfo = videoInfo;
            this.actionToPerform = actionToPerform;

            lockObject = new object();

            downloadPath = (string.Join("-", videoInfo.Title.Split(Path.GetInvalidFileNameChars())) + videoInfo.AudioInfo.GetContainerFileExtension());
            downloadPath = Path.Combine(SettingsUserControl.Instance.Settings.DownloadDirectoryPath, downloadPath);

            IsRunning = false;

            Startup();
        }

        private void Startup()
        {
            converterMp3.ConvertionProgress += ConverterMp3_ConvertionProgress;
            converterMp3.ConvertionFinished += ConverterMp3_ConvertionFinished;

            videoInfo.AudioInfo.DownloadProgress += AudioInfo_DownloadProgress;
            videoInfo.AudioInfo.DownloadFinished += AudioInfo_DownloadFinished;

            pictureBoxImage.LoadAsync(videoInfo.Thumbnails.HighResolutionUrl);

            resizableLabelTitle.Text = videoInfo.Title;
            labelBitrateSize.Text = ("320 Kbps / " + (((videoInfo.AudioInfo.Size * 2.5) / 1024f) / 1024f).ToString("00.00") + " MB~");
            labelInformation.Text = "Pronto";

            buttonDownloadCancel.PerformClick();
        }
        #endregion

        #region BUTTONDOWNLOADCANCEL_EVENT
        private void buttonDownloadCancel_Click(object sender, EventArgs e)
        {
            if (buttonDownloadCancel.Text == "Scarica")
            {
                videoInfo.AudioInfo.DownloadAsync(downloadPath, Path.ChangeExtension(downloadPath, ".mp3"));

                SetLabelText("Download in corso...");
                SetButtonDownloadCancelText("Annulla");
                EnableButtonRemove(false);

                IsRunning = true;
            }
            else if (buttonDownloadCancel.Text == "Annulla")
            {
                videoInfo.AudioInfo.CancelAsync();
                converterMp3.CancelAsync();
            }
            else
            {
                Process.Start("explorer.exe", ("/select, \"" + Path.ChangeExtension(downloadPath, ".mp3") + "\""));
            }
        }
        #endregion

        #region BUTTONDOWNLOADCANCEL_STATUS
        private void SetButtonDownloadCancelText(string text)
        {
            if (buttonDownloadCancel.InvokeRequired)
            {
                buttonDownloadCancel.BeginInvoke((MethodInvoker)delegate ()
                {
                    SetButtonDownloadCancelText(text);
                });
            }
            else
            {
                buttonDownloadCancel.Text = text;
            }
        }
        #endregion

        #region DOWNLOAD_EVENTS
        private void AudioInfo_DownloadProgress(object sender, DownloadProgressEventArgs e)
        {
            SetProgressBarPercentage(e.ProgressPercentage);
        }

        private void AudioInfo_DownloadFinished(object sender, AsyncCompletedEventArgs e)
        {
            ManageAsyncCompleteEventArgs(e, true);
        }
        #endregion

        #region CONVERTER_EVENTS
        private void ConverterMp3_ConvertionProgress(object sender, ConversionProgressEventArgs e)
        {
            SetProgressBarPercentage(e.ProgressPercentage);
        }

        private void ConverterMp3_ConvertionFinished(object sender, AsyncCompletedEventArgs e)
        {
            ManageAsyncCompleteEventArgs(e, false);
        }
        #endregion

        #region ASYNC_MANAGERS
        private void ManageAsyncCompleteEventArgs(AsyncCompletedEventArgs asyncCompletedEventArgs, bool isDownload)
        {
            string fileName = (isDownload ? downloadPath : asyncCompletedEventArgs.UserState.ToString());

            if (asyncCompletedEventArgs.Cancelled)
            {
                ManageResultOperations(fileName, "Operazione annullata.", 0);
            }
            else if (asyncCompletedEventArgs.Error != null)
            {
                ManageResultOperations(fileName, ("Errore: " + asyncCompletedEventArgs.Error.Message + "."), 0);
            }
            else if (isDownload)
            {
                converterMp3.ConvertToMp3Async(fileName, asyncCompletedEventArgs.UserState.ToString(), asyncCompletedEventArgs.UserState);

                SetLabelText("Conversione in corso...");
            }
            else
            {
                ManageResultOperations(string.Empty, "Completato.", 100);
            }

            if (!isDownload)
            {
                File.Delete(downloadPath);
            }

            lock (lockObject)
            {
                Monitor.Pulse(lockObject);
            }
        }

        private void ManageResultOperations(string fileName, string message, int percentage)
        {
            if (fileName != string.Empty)
            {
                SetButtonDownloadCancelText("Scarica");

                File.Delete(fileName);
            }
            else
            {
                SetButtonDownloadCancelText("Apri");
            }

            SetLabelText(message);

            EnableButtonRemove(true);
            SetProgressBarPercentage(percentage);

            IsRunning = false;
        }
        #endregion

        #region PROGRESSBAR_STATUS
        private void SetProgressBarPercentage(int percentage)
        {
            if (coloredProgressBarDownload.InvokeRequired)
            {
                coloredProgressBarDownload.BeginInvoke((MethodInvoker)delegate ()
                {
                    SetProgressBarPercentage(percentage);
                });
            }
            else
            {
                coloredProgressBarDownload.Value = percentage;
            }
        }
        #endregion

        #region LABEL_STATUS
        private void SetLabelText(string text)
        {
            if (labelInformation.InvokeRequired)
            {
                labelInformation.BeginInvoke((MethodInvoker)delegate ()
                {
                    SetLabelText(text);
                });
            }
            else
            {
                labelInformation.Text = text;
            }
        }
        #endregion

        #region BUTTONREMOVE_EVENT
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            string fileName = Path.ChangeExtension(downloadPath, ".mp3");

            if (File.Exists(fileName))
            {
                string text = "Vuoi eliminare anche il file?";

                if (MessageBox.Show(text, "Domanda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    File.Delete(fileName);
                }
            }

            Parent.Controls.Remove(this);
        }
        #endregion

        #region BUTTONREMOVE_STATUS
        private void EnableButtonRemove(bool enable)
        {
            if (buttonRemove.InvokeRequired)
            {
                buttonRemove.BeginInvoke((MethodInvoker)delegate ()
                {
                    EnableButtonRemove(enable);
                });
            }
            else
            {
                buttonRemove.Enabled = enable;
            }
        }
        #endregion
    }
}
