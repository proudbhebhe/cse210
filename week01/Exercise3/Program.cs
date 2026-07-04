using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int happy = randomGenerator.Next(1, 100);
         Console.Write("What is the guess number: ");
        string guess = Console.ReadLine();
        int sad = int.Parse(guess);
        if (sad < happy)
            {
                Console.WriteLine("Higher");
            }
            else if (sad> happy)
            {
                Console.WriteLine("Lower");
            }
            else
        {
            Console.WriteLine("You guessed it correctly:");
            Console.WriteLine("It took you one try");
            
        }
        int count = 1;
        while (happy != sad)
        {
            Console.Write("What is your guess: ");
            string ted = Console.ReadLine();
            int red = int.Parse(ted);
       
            count++;
            if (red < happy)
            {
                Console.WriteLine("Higher");
            }
            else if (red> happy)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it correctly.");
                Console.WriteLine($"It took you {count} times");
                break;
            }    
        }
        
    }
}