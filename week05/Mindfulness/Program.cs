using System;

class Program
{
    static void Main(string[] args)
    {
        Activity activity = null;

        Console.WriteLine("Welcome to the Mindfulness App!");
        Console.WriteLine("Select an activity:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");

        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                activity = new BreathingActivity();
                break;
            case "2":
                activity = new ReflectionActivity();
                break;
            case "3":
                activity = new ListingActivity();
                break;
            default:
                Console.WriteLine("Invalid choice.");
                return;
        }

        activity.Execute();
    }
}