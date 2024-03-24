using System;

class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public override void Run()
    {
        base.Run();
        DisplayStartingMessage();

        Console.WriteLine("Breathe in...");
        ShowCountDown(_duration);

        Console.WriteLine("Breathe out...");
        ShowCountDown(_duration);

        Console.WriteLine();
        Console.WriteLine("Breathing Activity completed!");
        DisplayEndingMessage();
    }
}
