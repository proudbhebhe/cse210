using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator prompts = new PromptGenerator();

        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to the Journal Program");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write New Entry");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = prompts.GetRandomPrompt();

                Console.WriteLine();
                Console.WriteLine(prompt);

                Console.Write("> ");
                string response = Console.ReadLine();

                Entry entry = new Entry(prompt, response);

                journal.AddEntry(entry);

                Console.WriteLine("Entry added.");
            }
            else if (choice == "2")
            {
                journal.DisplayJournal();
            }
            else if (choice == "3")
            {
                Console.Write("Enter filename: ");
                string filename = Console.ReadLine();

                journal.SaveJournal(filename);
            }
            else if (choice == "4")
            {
                Console.Write("Enter filename: ");
                string filename = Console.ReadLine();

                journal.LoadJournal(filename);
            }
            else if (choice != "5")
            {
                Console.WriteLine("Invalid choice.");
            }
        }

        Console.WriteLine("Goodbye!");
    }
}