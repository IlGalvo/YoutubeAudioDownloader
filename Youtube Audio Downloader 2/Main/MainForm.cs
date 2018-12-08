using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using YoutubeAudioDownloader2.Main.Download;

namespace YoutubeAudioDownloader2.Main
{
    public partial class MainForm : Form
    {
        #region GLOBAL_VARIABLE
        private static readonly Dictionary<Button, UserControl> dictionary = new Dictionary<Button, UserControl>();
        #endregion

        #region FORM_EVENTS
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i != tableLayoutPanelMenu.RowCount; i++)
            {
                dictionary.Add(((Button)tableLayoutPanelMenu.Controls[i]), ((UserControl)panelContent.Controls[i]));
            }

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
            // Try use KeyValuePair and fix and optimize
            foreach (Button button in tableLayoutPanelMenu.Controls)
            {
                button.BackColor = ((button == ((Button)sender)) ? Color.LightGreen : Color.Honeydew);

                dictionary[button].Visible = (button == ((Button)sender));

                if (dictionary[button].Visible)
                {
                    dictionary[button].BringToFront();
                }
            }
        }
        #endregion

        public void PerformButtonListClick()
        {
            buttonList.PerformClick();
        }

        public void PerformButtonDownloadClick()
        {
            buttonDownload.PerformClick();
        }
    }
}
