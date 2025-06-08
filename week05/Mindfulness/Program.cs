using System;
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
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Start();
                    break;

                case "2":
                    ReflectionActivity reflection = new ReflectionActivity();
                    reflection.Start();
                    break;
                
                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.Start();
                    break;
                case "4":
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
}
