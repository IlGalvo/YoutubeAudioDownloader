using System;
using System.Threading;

namespace YoutubeClientManager.Audio
{
    internal sealed class AudioInfoStatus
    {
        public CancellationToken Token { get; set; }
        public Exception Error { get; set; }

        public AudioInfoStatus()
        {
            Token = new CancellationToken();
            Error = null;
        }
    }
}
