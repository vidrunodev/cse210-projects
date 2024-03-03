using System;

class Program
{
    static void Main()
    {
        int magicNumber;
        int userGuess;

        Console.Write("What is the magic number? ");
        magicNumber = int.Parse(Console.ReadLine());

        int guesses = 0;

        do
        {
            Console.Write("What is your guess? ");
            userGuess = int.Parse(Console.ReadLine());

            if (userGuess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (userGuess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

            guesses++;

        } while (magicNumber != userGuess); 

        Console.WriteLine($"It took you {guesses} guesses to find the magic number.");

        Random randomGenerator = new Random();
        magicNumber = randomGenerator.Next(1, 101);

        Console.Write("Do you want to play again? (yes/no): ");
        string playAgainResponse = Console.ReadLine().ToLower();

        while (playAgainResponse == "yes")
        {
            guesses = 0;

            do
            {
                Console.Write("What is your guess? ");
                userGuess = int.Parse(Console.ReadLine());

                if (userGuess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (userGuess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }

                guesses++;

            } while (magicNumber != userGuess);

            Console.WriteLine($"It took you {guesses} guesses to find the magic number.");

            Console.Write("Do you want to play again? (yes/no): ");
            playAgainResponse = Console.ReadLine().ToLower();
        }
    }
}
