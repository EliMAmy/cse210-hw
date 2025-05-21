using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();

        int userNumber = -1;
        int sum = 0;
        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            string number = Console.ReadLine();
            int enterNumber = int.Parse(number);
            if (enterNumber != 0)
            {
                numbers.Add(enterNumber);
            }
            else
            {
                userNumber = 0;
            }
        }
        //Compute the sum of the numbers
        foreach (int number in numbers)
        {
            sum = sum + number;

        }
        Console.WriteLine($"The sum is: {sum}");

        //Compute the average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Compute the largest number

        int max = numbers.Max();
        Console.WriteLine($"The largest number is: {max}");

        //Calculate The smallest positive number

        int minPositive = numbers.Where(n => n > 0).Min();
        Console.WriteLine($"The smallest positive number is: {minPositive}");

        // Calculate a sorted list
        Console.WriteLine("The sorted list is:");
        numbers.Sort();
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

    }



}
