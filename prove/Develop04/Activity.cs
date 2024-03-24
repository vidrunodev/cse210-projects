using System;
using System.Threading;

class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
        _name = "";
        _description = "";
        _duration = 0;
    }

    public virtual void Run()
    {
        Console.WriteLine("Starting " + _name + " Activity:");
    }

    protected void DisplayStartingMessage()
    {
        Console.WriteLine("Starting " + _name + " activity...");
        Console.WriteLine("Description: " + _description);
        Console.WriteLine("Enter the duration of the activity in seconds:");
        _duration = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(3000);
    }

    protected void DisplayEndingMessage()
    {
        Console.WriteLine("Duration: " + _duration + " seconds");
        Console.WriteLine("Well done!");
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b");
        }
    }

    protected void ShowCountDown(int seconds)
    {
        for (int i = seconds; i >= 0; i--)
        {
            Console.WriteLine("Time remaining: " + i + " seconds");
            Thread.Sleep(1000);
        }
    }
}
