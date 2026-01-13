using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage here: ");
        String grade1 = Console.ReadLine();
        int grade = int.Parse(grade1);
        String message1 = "Congrats! You passed";
        String message2 = "Opps! Please try harder next time";

        String letter;
        if (grade >= 90) letter = "A";
        else if (grade >= 80) letter = "B";
        else if (grade >= 70) letter = "C";
        else if (grade >= 60) letter = "D";
        else letter = "F";

        Console.WriteLine($"{letter}");

        if (grade >= 70)
        {
            Console.WriteLine($"{message1}");
        }
        else
        {
            Console.WriteLine($"{message2}");
        }


        Console.WriteLine("Hello World! This is the Exercise2 Project.");
    }
}