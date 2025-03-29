// This file contains the Comment class, which represents a comment on a video.
// It includes properties for the author and text of the comment, as well as methods to get these properties and display the comment.

using System;

public class Comment
{
    private string _Author; 
    private string _Text;
    
public Comment(string author, string text) // Comment constructor
    {
        _Author = author;
        _Text = text;
    }

    public string GetAuthor() // GetName method
    {
        return _Author;
    }

    public string GetText() // GetText method
    {
        return _Text;
    }
    public void Display()
    {
        Console.WriteLine($"Comment by {_Author}: {_Text}");
    }
}
