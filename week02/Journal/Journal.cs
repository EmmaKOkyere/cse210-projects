using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> entries;
    private static readonly string[] prompts = {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is one thing I learned today?"
    };

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void WriteEntry()
    {
        Random random = new Random();
        int promptIndex = random.Next(prompts.Length);
        string prompt = prompts[promptIndex];

        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        Entry entry = new Entry(prompt, response, DateTime.Now);
        entries.Add(entry);
        Console.WriteLine("Entry saved!");
    }

    public void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries found.");
            return;
        }

        Console.WriteLine("Journal Entries:");
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile()
    {
        Console.Write("Enter filename to save journal: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine(entry.ToFileString());
            }
        }

        Console.WriteLine("Journal saved to file.");
    }

    public void LoadFromFile()
    {
        Console.Write("Enter filename to load journal: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            entries.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Entry entry = Entry.FromFileString(line);
                    entries.Add(entry);
                }
            }
            Console.WriteLine("Journal loaded from file.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}