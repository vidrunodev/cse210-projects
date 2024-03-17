using System;

class Program
{
    static void Main(string[] args)
    {
        // Define the scripture reference
        Reference reference = new Reference("John", 3, 16);

        // Define the scripture text
        string scriptureText = "For God so loved the world, that he gave his only Son, that whoever believes in him should not perish but have eternal life.";

        // Create the scripture object
        Scripture scripture = new Scripture(reference, scriptureText);

        // Display the complete scripture
        Console.WriteLine(scripture.GetDisplayText());

        // Prompt the user to press Enter or type quit
        Console.WriteLine("Press Enter to hide some words or type 'quit' to exit.");
        string userInput = Console.ReadLine();

        // Hide random words and display the scripture until completely hidden
        while (!scripture.IsCompletelyHidden() && userInput != "quit")
        {
            // Hide 3 random words
            scripture.HideRandomWords(3);
            // Clear the console
            Console.Clear();
            // Display the scripture with hidden words
            Console.WriteLine(scripture.GetDisplayText());
            // Prompt the user to enter replacement words for each hidden word
            while (!scripture.IsCompletelyHidden() && userInput != "quit")
            {
                Console.WriteLine("Enter the word to replace the underscores or type 'next' to replace next word or type 'quit' to exit:");
                userInput = Console.ReadLine();
                if (userInput.ToLower() == "next")
                {
                    // Break out of the loop to hide more words
                    break;
                }
                else if (!string.IsNullOrWhiteSpace(userInput))
                {
                    // Replace the next hidden word with user input
                    scripture.ReplaceHiddenWords(userInput);
                    // Clear the console
                    Console.Clear();
                    // Display the updated scripture
                    Console.WriteLine(scripture.GetDisplayText());
                }
            }

            // If all words are replaced or user quits, exit the loop
            if (scripture.IsCompletelyHidden() || userInput == "quit")
            {
                break;
            }
        }

        Console.WriteLine("Program ended.");
    }
}
