using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

    
        string name = PromptUserName();
        int number = PromptUserNumber();

        int square = SquareNumber(number);
        DisplayResults(name,square);

    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program.");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number: ");
        string odd =Console.ReadLine();
        int number = int.Parse(odd);
        return number;
    }
    static int SquareNumber(int number)
    {
        int square = number* number;
        return square;
    }

    static void DisplayResults(string name, int square)
    {
        Console.WriteLine($"{name}, your number squared is {square}");
    }
}