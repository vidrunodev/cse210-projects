using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        Console.Write("Enter your score: ");
        string valueFromUser = Console.ReadLine();

        int x = int.Parse(valueFromUser);
        string letter = "";
        string sign = "";

        if (x >= 90)
        {
            letter = "A";
        }
        else if (x >= 80)
        {
            letter = "B";
        }
        else if (x >= 70)
        {
            letter = "C";
        }
        else if (x >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        int lastDigit = x % 10;
        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }

        if (letter == "A" && sign == "+")
        {
            letter = "A";
            sign = "-";
        }
        else if (letter == "F" && (sign == "+" || sign == "-"))
        {
            sign = "";
        }

        Console.WriteLine("");
        Console.WriteLine($"Your score is {letter}{sign}");

        if (letter == "A" || letter == "B" || letter == "C")
        {
            Console.WriteLine("Congratulations, you passed the course!");
        }
        else
        {
            Console.WriteLine("Every setback is a setup for a comeback; use this experience as fuel to ignite your determination and excel in the next opportunity.");
        }
        Console.WriteLine("");
    }
}