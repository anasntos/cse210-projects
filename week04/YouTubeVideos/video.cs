using System;
using System.Collections.Generic;

namespace YouTubeVideos
{
    // Represents a video with title, author, duration, and comments
    public class Video
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Length { get; set; } // in seconds

        private List<Comment> comments = new List<Comment>();

        // Constructor
        public Video(string title, string author, int length)
        {
            Title = title;
            Author = author;
            Length = length;
        }

        // Adds a comment to the video
        public void AddComment(Comment comment)
        {
            comments.Add(comment);
        }

        // Returns the number of comments
        public int GetNumberOfComments()
        {
            return comments.Count;
        }

        // Displays video information and its comments
        public void DisplayVideoInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Length: {Length} seconds");
            Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in comments)
            {
                comment.DisplayComment();
            }
            Console.WriteLine(); // Blank line between videos
        }
    }
}


