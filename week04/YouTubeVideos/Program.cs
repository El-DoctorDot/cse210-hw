// This program simulates a YouTube-like application where users can create videos, add comments to them, and display all videos with their respective comments.
// It includes classes for Video, Comment, and YouTube, demonstrating object-oriented programming principles such as encapsulation and composition.
using System;

class Program
{
    static void Main(string[] args)
    {
          YouTube youtube = new YouTube();

        // Creating videos with title, author, and duration
        Video video1 = new Video("Learning C#", "Dev Channel", 600);
        video1.AddComment(new Comment("James", "Great video!"));
        video1.AddComment(new Comment("Maria", "I loved the explanation!"));
        video1.AddComment(new Comment("Carlos", "Very helpful, thanks!"));

        // Creating more videos with comments
        Video video2 = new Video("Introduction to Python", "Easy Programming", 720);
        video2.AddComment(new Comment("Ana", "Very good for beginners!"));
        video2.AddComment(new Comment("Lucas", "I finally understood functions, thanks!"));
        video2.AddComment(new Comment("Peter", "Clear and objective explanation!"));

        // Creating another video with comments
        Video video3 = new Video("HTML and CSS from scratch", "Front-end Master", 900);
        video3.AddComment(new Comment("Sofia", "Great teaching!"));
        video3.AddComment(new Comment("Ricardo", "It helped me a lot with my project."));
        video3.AddComment(new Comment("Fernando", "This content is essential for anyone who wants to learn about the web."));

        // Adding videos to YouTube
        youtube.AddVideo(video1);
        youtube.AddVideo(video2);
        youtube.AddVideo(video3);

        // Displaying all videos and their comments
        youtube.DisplayAllVideos();
    }
}