using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public override void Execute()
    {
        StartMessage("Listing Activity: This activity will help you reflect on the good things in your life by having you list as many things as you can.");

        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Length)];
        Console.WriteLine(prompt);
        Pause(5);

        List<string> items = new List<string>();
        Console.WriteLine("Start listing items (type 'done' to finish):");

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            if (item.ToLower() == "done")
                break;
            items.Add(item);
        }

        Console.WriteLine($"You listed {items.Count} items.");
        EndMessage("Listing Activity");
    }
}