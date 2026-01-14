using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = numbers = new List<int>();

        int input = -1;

        while (input != 0)
        {
            Console.Write("Enter number (type 0 to quit): ");
            int inputNumber = int.Parse(Console.ReadLine());

            if (inputNumber != 0)
            {
                numbers.Add(inputNumber);
            }

            // Calculate the sum
            int sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }
            Console.WriteLine($"The sum is {sum}");

            // Calculate the average
            float average = ((float)sum) / numbers.Count;
            Console.WriteLine($"The average is {average}");

            // Find the max number
            int max = numbers[0];
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            Console.WriteLine($"Tha maximum number is {max}");
        }
    }
}