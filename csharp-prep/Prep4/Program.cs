using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int input = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());

            // Have to make sure that this is 0 because it will mess up the
            // list count and therefore the average
            if (input != 0) numbers.Add(input);
        } while (input != 0);

        // sort the list from lowest to greatest
        numbers.Sort();

        int sum = 0;
        int largest = numbers[numbers.Count - 1];
        int smallestPositive = largest;
        foreach (int number in numbers)
        {
            sum += number;
            if (number > 0 && number < smallestPositive) smallestPositive = number;
        }
        float average = (float)sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        // Stretch challenge
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}