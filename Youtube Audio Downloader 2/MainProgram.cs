using System;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using YoutubeAudioDownloader2.Main;

namespace YoutubeAudioDownloader2
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

            using (Mutex mutex = new Mutex(false, (Application.ProductName + "_" + Assembly.GetExecutingAssembly().GetType().GUID.ToString())))
            {
                if (mutex.WaitOne(0, false))
                {
                    //if (UpdateForm.CheckForUpdates(new Version(Application.ProductVersion), false) == DialogResult.OK)
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
