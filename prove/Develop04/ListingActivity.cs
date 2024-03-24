using System;
using System.Threading;

class ListingActivity : Activity
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public override void Run()
    {
        base.Run();
        DisplayStartingMessage();

        Console.WriteLine("Prompt: " + GetRandomPrompt());
        Thread.Sleep(2000);

        Console.WriteLine("You have " + _duration + " seconds to list as many items as you can.");
        Console.WriteLine("Press any key to start listing...");
        Console.ReadKey();
        Console.WriteLine();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        int count = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("Enter an item: ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine();
        Console.WriteLine("Number of items listed: " + count);
        Console.WriteLine();
        Console.WriteLine("Listing Activity completed!");
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        return prompts[random.Next(prompts.Length)];
    }
}
