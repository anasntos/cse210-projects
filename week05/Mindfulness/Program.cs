using System;

class Program
{
    static void Main(string[] args)
    {
        bool quit = false;

        while (!quit)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Start Gratitude Activity");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    new BreathingActivity().Start();
                    PauseBeforeContinuing();
                    break;
                case "2":
                    new ReflectionActivity().Start();
                    PauseBeforeContinuing();
                    break;
                case "3":
                    new ListingActivity().Start();
                    PauseBeforeContinuing();
                    break;
                case "4":
                    new GratitudeActivity().Start();
                    PauseBeforeContinuing();
                    break;
                case "5":
                    quit = true;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Press Enter to try again.");
                    Console.ReadLine();
                    break;
            }
        }
    }

    static void PauseBeforeContinuing()
    {
        Console.WriteLine("\nPress Enter to return to the main menu.");
        Console.ReadLine();
    }
}

