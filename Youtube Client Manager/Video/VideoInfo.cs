using System;
using YoutubeClientManager.Video.Audio;

namespace YoutubeClientManager.Video
{
    public sealed class VideoInfo
    {
        #region GLOBAL_VARIABLES
        public string Id { get; internal set; }
        public string Author { get; internal set; }
        public string Title { get; internal set; }
        public string Description { get; internal set; }
        public TimeSpan Duration { get; internal set; }
        public DateTime UploadDate { get; internal set; }
        public Statistics Statistics { get; internal set; }
        public ThumbnailSet Thumbnails { get; private set; }
        public string[] Keywords { get; internal set; }
        public bool IsOfficial { get; internal set; }
        public AudioInfo AudioInfo { get; internal set; }
        #endregion

        #region CONSTRUCTOR
        internal VideoInfo(string id)
        {
            Id = id;
            Author = string.Empty;
            Title = string.Empty;
            Description = string.Empty;
            Duration = TimeSpan.Zero;
            UploadDate = DateTime.MinValue;
            Statistics = new Statistics();
            Thumbnails = new ThumbnailSet(id);
            Keywords = new string[] { };
            IsOfficial = false;
            AudioInfo = new AudioInfo();
        }
        #endregion

        #region URLS
        public string GetRegularUrl()
        {
            return ($"https://www.youtube.com/watch?v={Id}");
        }

        public string GetShortUrl()
        {
            return ($"https://youtu.be/{Id}");
        }

        public string GetEmbedUrl()
        {
            return ($"https://www.youtube.com/embed/{Id}");
        }
        #endregion
    }
}