using System;
using System.Windows.Forms;

namespace YoutubeAudioDownloader2.Main
{
    internal sealed class MyLabel : Label
    {
        private static readonly int Offset = 110;

        private string text;
        public override string Text { get { return base.Text; } set { text = value; } }

        public MyLabel()
        {
            text = "mylabel1";
            base.Text = "mylabel1";
        }

        protected override void OnTextChanged(EventArgs e)
        {
            WidthTrim();

            base.OnTextChanged(e);
        }

        protected override void OnParentChanged(EventArgs e)
        {
            Parent.SizeChanged += Parent_SizeChanged;

            base.OnParentChanged(e);
        }

        private void Parent_SizeChanged(object sender, EventArgs e)
        {
            WidthTrim();
        }

        private void WidthTrim()
        {
            string tmpText = text;

            if (!string.IsNullOrEmpty(tmpText))
            {
                int currentWidth = TextRenderer.MeasureText(tmpText, Font).Width;
                double widthRatio = (((double)(Parent.Width - Offset)) / currentWidth);

                while (widthRatio < 1.0)
                {
                    tmpText = (tmpText.Substring(0, (int)(tmpText.Length * widthRatio) - 3) + "...");

                    currentWidth = TextRenderer.MeasureText(tmpText, Font).Width;
                    widthRatio = (((double)(Parent.Width - Offset)) / currentWidth);
                }
            }

            base.Text = tmpText;
        }
    }
}
