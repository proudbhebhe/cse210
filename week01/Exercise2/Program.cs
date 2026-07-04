using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your final score? ");
        string score = Console.ReadLine();
        int mark = int.Parse(score);
        string letter = "";

        if (90<=mark)
        {
            letter = "A";
        }
        else if (80<=mark)
        {
            letter ="B";
        }
        else if (70<=mark)
        {
            letter = "C";
        }
        else if (60<=mark)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine(letter);
        if (mark>=70)
        {
            Console.WriteLine("Congratulations!! You passed the term");
        }
        else
        {
            Console.WriteLine("You might want to try again next term.");
        }
    }
}