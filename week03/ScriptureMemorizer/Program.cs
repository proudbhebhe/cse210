using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Reference refer1 = new Reference("Alma", 11, 40);
        Scripture script1 = new Scripture(refer1, "And he shall come into the world to redeem his people; and he shall take upon him the transgressions of those who believe on his name; and these are they that shall have eternal life, and salvation cometh to none else.");

        while(!script1.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(script1.GetDisplayText());
            Console.WriteLine();
            Console.Write("Press Enter to continue or type 'quit': ");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }

            script1.HideRandomWords(4);
        }
        Console.WriteLine(script1.GetDisplayText());

        
    }
}