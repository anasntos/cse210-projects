using System;
using System.Collections.Generic;

namespace YouTubeVideos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of videos
            List<Video> videos = new List<Video>();

            // Video 1
            Video video1 = new Video("How to Make Homemade Bread", "Ana Souza", 320);
            video1.AddComment(new Comment("Lucas", "I made it at home and it turned out great!"));
            video1.AddComment(new Comment("Maria", "Loved the recipe!"));
            video1.AddComment(new Comment("John", "Very well explained."));

            // Video 2
            Video video2 = new Video("C# for Beginners", "Carlos Dev", 580);
            video2.AddComment(new Comment("Fernanda", "Now I understand classes!"));
            video2.AddComment(new Comment("Richard", "Very clear and helpful."));
            video2.AddComment(new Comment("Aline", "Could you do one about lists next?"));

            // Video 3
            Video video3 = new Video("Tour of the Curitiba Temple", "Church Brazil", 410);
            video3.AddComment(new Comment("Edward", "So beautiful!"));
            video3.AddComment(new Comment("Paula", "I want to visit someday."));
            video3.AddComment(new Comment("Livia", "Thank you for sharing!"));

            // Video 4
            Video video4 = new Video("How to Study English on Your Own", "Study With Me", 360);
            video4.AddComment(new Comment("Rafael", "Great tips!"));
            video4.AddComment(new Comment("Tatiane", "Loved the schedule part."));
            video4.AddComment(new Comment("Gustavo", "I'm already applying the ideas!"));

            // Add videos to the list
            videos.Add(video1);
            videos.Add(video2);
            videos.Add(video3);
            videos.Add(video4);

            // Display each video
            foreach (Video video in videos)
            {
                video.DisplayVideoInfo();
            }
        }
    }
}
