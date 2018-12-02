using System.ComponentModel;

namespace YoutubeClientManager.Converter
{
    public delegate void ConvertionProgressEventHandler(object sender, ConversionProgressEventArgs e);

    public delegate void ConvertionFinishedEventHandler(object sender, AsyncCompletedEventArgs e);
}
