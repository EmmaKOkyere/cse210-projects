public class Program
{
    public static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16); // Example reference
        Scripture scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son.");

        Console.WriteLine("Original Text: " + scripture.GetDisplayText());

        while (true)
        {
            Console.WriteLine("Type 'quit' to hide all text or enter the number of words to hide:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                scripture.HideAllWords();
                Console.WriteLine("All text is now hidden.");
                break; // Exit the loop
            }

            if (int.TryParse(input, out int numberToHide))
            {
                scripture.HideRandomWords(numberToHide);
                Console.WriteLine("After Hiding Words: " + scripture.GetDisplayText());
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number or 'quit'.");
            }
        }

        Console.WriteLine("Final Display: " + scripture.GetDisplayText());
        Console.WriteLine("Is Completely Hidden: " + scripture.IsCompletelyHidden());
    }
}