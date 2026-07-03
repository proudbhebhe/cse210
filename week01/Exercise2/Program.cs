using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your final score? ");
        string score = Console.ReadLine();
        int mark = int.Parse(score);

        if (90<=mark)
        {
            Console.WriteLine("A");
        }
        else if (80<=mark)
        {
            Console.WriteLine("B");
        }
        else if (70<=mark)
        {
            Console.WriteLine("C");

        }
    }
}