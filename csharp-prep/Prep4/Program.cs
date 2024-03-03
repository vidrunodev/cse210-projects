using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int input;
        do
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());

            if (input != 0)
                numbers.Add(input);

        } while (input != 0);

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        double average = (double)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int maxNumber = int.MinValue;
        foreach (int number in numbers)
        {
            if (number > maxNumber)
                maxNumber = number;
        }
        Console.WriteLine($"The largest number is: {maxNumber}");

        int smallestPositive = int.MaxValue;
        foreach (int number in numbers)
        {
            if (number > 0 && number < smallestPositive)
                smallestPositive = number;
        }
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
