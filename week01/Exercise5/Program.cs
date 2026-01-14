using System;
using System.ComponentModel.DataAnnotations;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        // Display results
        Console.WriteLine(DisplayMessage());

        Console.Write("Enter your Full name here: ");
        string FullName = Console.ReadLine();

        Console.Write("Enter your favorite number: ");
        int FavNum = int.Parse(Console.ReadLine());

        // Display
        Console.WriteLine($"{PromptUserName(FullName)}, The square of your number is {SquareNumber(FavNum)}");
    
    }

    static string DisplayMessage()
    {
        return "Hello world!";
    }
    
    // Prompt user name
    static string PromptUserName(string Name)
    {
        return Name;
    }

    static int PromptUserNumber(int number)
        {
            return number;
        }

    static int SquareNumber(int Num)
        {
            int Sqr = Num * Num;
            return Sqr;
        }

}