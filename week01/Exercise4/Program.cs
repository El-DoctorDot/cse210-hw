using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {   
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a lits of numbers ( both positive and neagtive), type 0 when you are done");

        while (true)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            if (number == 0)
            {
                break;
                
            }
            else
            {
                numbers.Add(number);
            }


        }

        if (numbers.Count > 0)
        {
            int sum = numbers.Sum();
            double average = numbers.Average();
            int max = numbers.Max();

            var positiveNumbers = numbers.Where(n => n > 0);
            int minPositive = positiveNumbers.Any() ? positiveNumbers.Min() : 0;


            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The Average is: {average}");
            Console.WriteLine($"The largest number is: {max}");

            if (minPositive > 0)
            {
                Console.WriteLine($"The smaller positive number is: {minPositive}");
            }
            else
            {
                Console.WriteLine("There are no positive numbers");
            }
        }
        else
        {
            Console.WriteLine("No numbers were entered");
        }
    }
}