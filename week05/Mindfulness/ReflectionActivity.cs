using System;
using System.Collections.Generic;

public class ReflectionActivity : MindfulnessActivity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private Queue<string> _availablePrompts = new Queue<string>();
    private Queue<string> _availableQuestions = new Queue<string>();

    public ReflectionActivity() : base(
        "Reflection Activity",
        "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }

    protected override void RunActivity()
    {
        int duration = GetDuration();
        int elapsed = 0;

        if (_availablePrompts.Count == 0)
            ShufflePrompts();

        string prompt = _availablePrompts.Dequeue();
        Console.WriteLine($"\nConsider the following prompt:\n--- {prompt} ---");
        Console.WriteLine("\nWhen you have something in mind, press Enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions:");
        ShowSpinner(3);

        while (elapsed < duration)
        {
            if (_availableQuestions.Count == 0)
                ShuffleQuestions();

            string question = _availableQuestions.Dequeue();
            Console.WriteLine($"\n> {question}");
            ShowSpinner(5);
            elapsed += 5;
        }
    }

    private void ShufflePrompts()
    {
        var shuffled = new List<string>(_prompts);
        var rand = new Random();
        for (int i = shuffled.Count - 1; i > 0; i--)
        {
            int j = rand.Next(i + 1);
            (shuffled[i], shuffled[j]) = (shuffled[j], shuffled[i]);
        }
        _availablePrompts = new Queue<string>(shuffled);
    }

    private void ShuffleQuestions()
    {
        var shuffled = new List<string>(_questions);
        var rand = new Random();
        for (int i = shuffled.Count - 1; i > 0; i--)
        {
            int j = rand.Next(i + 1);
            (shuffled[i], shuffled[j]) = (shuffled[j], shuffled[i]);
        }
        _availableQuestions = new Queue<string>(shuffled);
    }
}
