using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to my GENERIC LIST PROGRAM");

        Random random = new Random();
        List<int> numbers = new List<int>();

        for (int i = 0; i < 20; i++)
        {
            numbers.Add(random.Next(1, 10));
        }

        Console.WriteLine("The 20 random numbers are:");
        Console.WriteLine(string.Join(" ", numbers));
        Console.WriteLine();

        Console.WriteLine("Histogram:");

        for (int digit = 1; digit <= 9; digit++)
        {
            int count = 0;
            foreach (int num in numbers)
            {
                if (num == digit)
                {
                    count++;
                }
            }

            string stars = new string('*', count);
            Console.WriteLine($"{digit} {stars}");
        }
    }
}