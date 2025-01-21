
using System;
class Program
{
    static void Main()
    {
        System.Console.WriteLine("Please enter a number To be Cube Number: ");
        string? input = Console.ReadLine();
        if (string.IsNullOrEmpty(input))
        {
            System.Console.WriteLine("Please enter a valid number");
            return;
        }
        int number = int.Parse(input);
        double result = Cube(number);

        System.Console.WriteLine($"The cube of {number} is {result}");

    }

    public static double Cube(int number)
    {
        return Math.Pow(number, 3);
    }
}