using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        if (int.TryParse(Console.ReadLine(), out int N))
        {
            if (IsDivisibleBy7(N))
            {
                Console.WriteLine($"{N} is divisible by 7.");
            }
            else
            {
                Console.WriteLine($"{N} is not divisible by 7.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }

    static bool IsDivisibleBy7(int N)
    {
        return N % 7 == 0;
    }
}

