using System;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using UpdaterManagerLibrary;
using YoutubeAudioDownloader.Main;

namespace YoutubeAudioDownloader
{
    static class MainProgram
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (Mutex mutex = new Mutex(false, (Application.ProductName + "_" + Assembly.GetExecutingAssembly().GetType().GUID)))
            {
                if (mutex.WaitOne(0, false))
                {
                    string updateCheckUrl = ("https://onedrive.live.com/download?resid=7D7FF9DFDA23C644!1341&authkey=!AAPfdJrVo5UeVkE");

                    if (!UpdaterManager.CheckForUpdates(updateCheckUrl))
                    {
                        WebBrowserPrepare.SetBrowserFeatureControl();

                        Application.Run(new MainForm());
                    }
                }
                else
                {
                    string text = "Non sono consentite istanze multiple, al momento.";

                    MessageBox.Show(text, "Avviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
