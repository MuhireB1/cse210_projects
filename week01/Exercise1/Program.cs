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

// A program that determines the letter grade
class Grade
{   
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage here: ");
        String grade1 = Console.ReadLine();
        int grade = int.Parse(grade1);

        if (grade >= 90)
        {
            Console.WriteLine("A");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("B");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("C");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("D");
        }
        else if (grade < 60)
        {
            Console.WriteLine("F");
        }
}}