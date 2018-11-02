using System;
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
            Application.Run(new MainForm());
        }
    }
}
