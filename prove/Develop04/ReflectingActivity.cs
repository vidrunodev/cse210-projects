using System;
using System.Threading;
using System.Collections.Generic;

class ReflectingActivity : Activity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity()
    {
        _name = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public override void Run()
    {
        base.Run();
        DisplayStartingMessage();

        Console.WriteLine("Prompt: " + GetRandomPrompt());
        Thread.Sleep(2000);

        foreach (string question in questions)
        {
            Console.WriteLine("Question: " + question);
            ShowSpinner(3);
            Console.WriteLine();
            Thread.Sleep(2000);
        }

        Console.WriteLine();
        Console.WriteLine("Reflecting Activity completed!");
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        return prompts[random.Next(prompts.Length)];
    }
}
