using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Exit");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    RunActivity(new BreathingActivity());
                    break;
                case "2":
                    RunActivity(new ListingActivity());
                    break;
                case "3":
                    RunActivity(new ReflectingActivity());
                    break;
                case "4":
                    Console.WriteLine("Exiting program...");
                    return;
                default:
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
                    break;
            }
        }
    }

    static void RunActivity(Activity activity)
    {
        Console.WriteLine();
        Console.WriteLine("===========================");
        activity.Run();
        Console.WriteLine("===========================");
        Console.WriteLine();
    }
}
