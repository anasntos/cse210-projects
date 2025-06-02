namespace YouTubeVideos
{
    // Represents a comment made on a video
    public class Comment
    {
        public string CommenterName { get; set; }
        public string Text { get; set; }

        // Constructor
        public Comment(string commenterName, string text)
        {
            CommenterName = commenterName;
            Text = text;
        }

        // Displays the comment on the console
        public void DisplayComment()
        {
            Console.WriteLine($"{CommenterName}: {Text}");
        }
    }
}

