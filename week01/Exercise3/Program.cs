using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        
        int guess = -1;

        while (magicNumber != guess)
        {
            Console.Write("Enter your guess: ");
            guess = int.Parse(Console.ReadLine());
            
            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            if (magicNumber == guess)
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}

