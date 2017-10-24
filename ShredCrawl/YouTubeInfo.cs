﻿using System;
using System.Collections.Generic;
using System.Text;

using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;

namespace ShredCrawl
{
    static class YouTubeInfo
    {
        static YouTubeService ytServ = Program.YoutTubeAuthorize();

        public static YouTubeVid RetrieveData(string vidUrl)
        {
            YouTubeVid ytVid = new YouTubeVid();
            string title = null;
            DateTime? releaseDate = null;
            string synopsis = null;
            string channelTitle = null;
            string channelID = null;

            var request = ytServ.Videos.List("snippet");

            request.Id = vidUrl;
            var response = request.Execute();
            if (response.Items.Count == 1)
            {
                Video video = response.Items[0];
                title = video.Snippet.Title;
                releaseDate = video.Snippet.PublishedAt;
                synopsis = video.Snippet.Description.Truncate(200);
                channelTitle = video.Snippet.ChannelTitle;
                channelID = video.Snippet.ChannelId; 
            }

            ytVid.ChannelTitle = channelTitle;
            ytVid.ChannelID = channelID;
            ytVid.Title = title;
            ytVid.ReleaseDate = releaseDate;
            ytVid.Synopsis = synopsis;
            return ytVid;
        }

        public static string Truncate(this string value, int maxChars)
        {
            return value.Length <= maxChars ? value : value.Substring(0, maxChars) + "...";
        }
    }
}