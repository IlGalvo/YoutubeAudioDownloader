using System.ComponentModel;

namespace YoutubeClientManager.Video.Audio
{
    public delegate void DownloadProgressEventHandler(object sender, DownloadProgressEventArgs e);

    public delegate void DownloadFinishedEventHandler(object sender, AsyncCompletedEventArgs e);
}
