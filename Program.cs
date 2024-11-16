using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 100; i++)
        {
            // Check if divisible by both 3 and 5
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            // Check if divisible by 3
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            // Check if divisible by 5
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            // Otherwise, just print the number
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}
