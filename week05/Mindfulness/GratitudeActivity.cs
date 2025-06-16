using System;
using System.Collections.Generic;

public class GratitudeActivity : MindfulnessActivity
{
    private List<string> _prompts = new List<string>
    {
        "List people you are grateful to have in your life.",
        "List experiences that made you happy recently.",
        "List things you often take for granted but are thankful for.",
        "List personal qualities you appreciate about yourself.",
        "List simple pleasures that bring you joy."
    };

    public GratitudeActivity() : base(
        "Gratitude Activity",
        "This activity encourages you to reflect on things you are grateful for by listing as many as you can in the given time.")
    {
    }

    protected override void RunActivity()
    {
        Random rand = new Random();
        int duration = GetDuration();
        List<string> gratitudeItems = new List<string>();

        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine($"\nFocus on the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("\nStart listing your items in:");
        ShowCountdown(5);
        Console.WriteLine();

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                gratitudeItems.Add(input);
            }
        }

        Console.WriteLine($"\nGreat job! You listed {gratitudeItems.Count} things you are grateful for.");
    }
}
