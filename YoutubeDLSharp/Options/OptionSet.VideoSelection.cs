﻿// <auto-generated>
// This code was partially generated by a tool.
// </auto-generated>

using System;

namespace YoutubeDLSharp.Options
{
    public partial class OptionSet
    {
        private Option<int?> playlistStart = new Option<int?>("--playlist-start");
        private Option<int?> playlistEnd = new Option<int?>("--playlist-end");
        private Option<string> playlistItems = new Option<string>("--playlist-items");
        private Option<string> matchTitle = new Option<string>("--match-title");
        private Option<string> rejectTitle = new Option<string>("--reject-title");
        private Option<int?> maxDownloads = new Option<int?>("--max-downloads");
        private Option<string> minFilesize = new Option<string>("--min-filesize");
        private Option<string> maxFilesize = new Option<string>("--max-filesize");
        private Option<DateTime> date = new Option<DateTime>("--date");
        private Option<DateTime> datebefore = new Option<DateTime>("--datebefore");
        private Option<DateTime> dateafter = new Option<DateTime>("--dateafter");
        private Option<long?> minViews = new Option<long?>("--min-views");
        private Option<long?> maxViews = new Option<long?>("--max-views");
        private Option<string> matchFilter = new Option<string>("--match-filter");
        private Option<bool> noPlaylist = new Option<bool>("--no-playlist");
        private Option<bool> yesPlaylist = new Option<bool>("--yes-playlist");
        private Option<byte?> ageLimit = new Option<byte?>("--age-limit");
        private Option<string> downloadArchive = new Option<string>("--download-archive");
        private Option<bool> includeAds = new Option<bool>("--include-ads");

        /// <summary>
        /// Playlist video to start at (default is 1)
        /// </summary>
        public int? PlaylistStart { get => playlistStart.Value; set => playlistStart.Value = value; }
        /// <summary>
        /// Playlist video to end at (default is last)
        /// </summary>
        public int? PlaylistEnd { get => playlistEnd.Value; set => playlistEnd.Value = value; }
        /// <summary>
        /// Playlist video items to download. Specify
        /// indices of the videos in the playlist
        /// separated by commas like: &quot;--playlist-items
        /// 1,2,5,8&quot; if you want to download videos
        /// indexed 1, 2, 5, 8 in the playlist. You can
        /// specify range: &quot;--playlist-items
        /// 1-3,7,10-13&quot;, it will download the videos
        /// at index 1, 2, 3, 7, 10, 11, 12 and 13.
        /// </summary>
        public string PlaylistItems { get => playlistItems.Value; set => playlistItems.Value = value; }
        /// <summary>
        /// Download only matching titles (regex or
        /// caseless sub-string)
        /// </summary>
        public string MatchTitle { get => matchTitle.Value; set => matchTitle.Value = value; }
        /// <summary>
        /// Skip download for matching titles (regex or
        /// caseless sub-string)
        /// </summary>
        public string RejectTitle { get => rejectTitle.Value; set => rejectTitle.Value = value; }
        /// <summary>
        /// Abort after downloading NUMBER files
        /// </summary>
        public int? MaxDownloads { get => maxDownloads.Value; set => maxDownloads.Value = value; }
        /// <summary>
        /// Do not download any videos smaller than
        /// SIZE (e.g. 50k or 44.6m)
        /// </summary>
        public string MinFilesize { get => minFilesize.Value; set => minFilesize.Value = value; }
        /// <summary>
        /// Do not download any videos larger than SIZE
        /// (e.g. 50k or 44.6m)
        /// </summary>
        public string MaxFilesize { get => maxFilesize.Value; set => maxFilesize.Value = value; }
        /// <summary>
        /// Download only videos uploaded in this date
        /// </summary>
        public DateTime Date { get => date.Value; set => date.Value = value; }
        /// <summary>
        /// Download only videos uploaded on or before
        /// this date (i.e. inclusive)
        /// </summary>
        public DateTime DateBefore { get => datebefore.Value; set => datebefore.Value = value; }
        /// <summary>
        /// Download only videos uploaded on or after
        /// this date (i.e. inclusive)
        /// </summary>
        public DateTime DateAfter { get => dateafter.Value; set => dateafter.Value = value; }
        /// <summary>
        /// Do not download any videos with less than
        /// COUNT views
        /// </summary>
        public long? MinViews { get => minViews.Value; set => minViews.Value = value; }
        /// <summary>
        /// Do not download any videos with more than
        /// COUNT views
        /// </summary>
        public long? MaxViews { get => maxViews.Value; set => maxViews.Value = value; }
        /// <summary>
        /// Generic video filter. Specify any key (see
        /// the &quot;OUTPUT TEMPLATE&quot; for a list of
        /// available keys) to match if the key is
        /// present, !key to check if the key is not
        /// present, key &gt; NUMBER (like &quot;comment_count
        /// &gt; 12&quot;, also works with &gt;=, &lt;, &lt;=, !=, =) to
        /// compare against a number, key = &#x27;LITERAL&#x27;
        /// (like &quot;uploader = &#x27;Mike Smith&#x27;&quot;, also works
        /// with !=) to match against a string literal
        /// and &amp; to require multiple matches. Values
        /// which are not known are excluded unless you
        /// put a question mark (?) after the operator.
        /// For example, to only match videos that have
        /// been liked more than 100 times and disliked
        /// less than 50 times (or the dislike
        /// functionality is not available at the given
        /// service), but who also have a description,
        /// use --match-filter &quot;like_count &gt; 100 &amp;
        /// dislike_count &lt;? 50 &amp; description&quot; .
        /// </summary>
        public string MatchFilter { get => matchFilter.Value; set => matchFilter.Value = value; }
        /// <summary>
        /// Download only the video, if the URL refers
        /// to a video and a playlist.
        /// </summary>
        public bool NoPlaylist { get => noPlaylist.Value; set => noPlaylist.Value = value; }
        /// <summary>
        /// Download the playlist, if the URL refers to
        /// a video and a playlist.
        /// </summary>
        public bool YesPlaylist { get => yesPlaylist.Value; set => yesPlaylist.Value = value; }
        /// <summary>
        /// Download only videos suitable for the given
        /// age
        /// </summary>
        public byte? AgeLimit { get => ageLimit.Value; set => ageLimit.Value = value; }
        /// <summary>
        /// Download only videos not listed in the
        /// archive file. Record the IDs of all
        /// downloaded videos in it.
        /// </summary>
        public string DownloadArchive { get => downloadArchive.Value; set => downloadArchive.Value = value; }
        /// <summary>
        /// Download advertisements as well
        /// (experimental)
        /// </summary>
        public bool IncludeAds { get => includeAds.Value; set => includeAds.Value = value; }
    }
}
