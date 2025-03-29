// This file contains the YouTube class that manages a list of videos.
// It allows adding videos and displaying all videos with their respective comments.
using System;

public class YouTube
{
    private List<Video> _Videos; // List of videos

    public YouTube() // YouTube constructor
    {
        _Videos = new List<Video>();
    }

    public void AddVideo(Video video) // AddVideo method
    {
        _Videos.Add(video);
    }
    public void DisplayAllVideos() // DisplayAllVideos method
    {
        foreach (var video in _Videos)
        {
            video.DisplayInfo();
        }
    }
}