using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string choice;

        do
        {
            Console.Clear();
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    journal.WriteEntry();
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    journal.SaveToFile();
                    break;
                case "4":
                    journal.LoadFromFile();
                    break;
                case "5":
                    Console.WriteLine("Exiting the journal. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

        } while (choice != "5");
    }
}