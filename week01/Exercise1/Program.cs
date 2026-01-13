using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        String first_name = Console.ReadLine();

        Console.Write("What is your second name? ");
        String second_name = Console.ReadLine();

        Console.WriteLine($"Your name is {second_name}, {first_name} {second_name}.");

    }
}

