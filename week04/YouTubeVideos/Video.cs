// This file contains the Video class that represents a video on YouTube.
// It includes properties for the title, author, duration, and a list of comments.

using System;
using System.Collections.Generic;

public class Video
{
    private string _Title;
    private string _Author;
    private int _Duration;
    private List<Comment> _Comments;

    // Constructor for the Video class
    public Video(string title, string author, int duration)
    {
        _Title = title;
        _Author = author;
        _Duration = duration;
        _Comments = new List<Comment>();
    }

   // Properties for the Video class
    public void AddComment(Comment comment)
    {
        _Comments.Add(comment);
    }

    // Method to get video title
    public int GetCommentCount()
    {
        return _Comments.Count;
    }

    // Method to display video information and comments
    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {_Title}");
        Console.WriteLine($"Author: {_Author}");
        Console.WriteLine($"Duration: {_Duration} seconds");
        Console.WriteLine($"Number of Comments: {GetCommentCount()}");

        //Show comments
        foreach (var comment in _Comments)
        {
            comment.Display();
        }

        Console.WriteLine(); // Blank line to separate videos
    }
}

