using System.Drawing;
using System.Windows.Forms;

namespace YoutubeAudioDownloader2.Main
{
    internal static class MainUtilities
    {
        public static string WidthTrim(string text, Font font, int maxWidth)
        {
            Graphics graphics = (new Label()).CreateGraphics();

            int currentWidth = ((int)graphics.MeasureString(text, font).Width);
            double widthRatio = ((double)maxWidth / currentWidth);

            while (widthRatio < 1.0)
            {
                text = (text.Substring(0, (int)(text.Length * widthRatio) - 3) + "...");

                currentWidth = ((int)graphics.MeasureString(text, font).Width);
                widthRatio = ((double)maxWidth / currentWidth);
            }

            return text;
        }
    }
}
