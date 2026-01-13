using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter magic number: ");
        int magic_number = int.Parse(Console.ReadLine());

        Console.Write("Enter your guess: ");
        int guess = int.Parse(Console.ReadLine());

        while (guess != magic_number)
        {
            if (guess < magic_number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magic_number)
            {
                Console.WriteLine("Lower");
            }
        }

        Console.WriteLine("Hello World! This is the Exercise3 Project.");
    }
}