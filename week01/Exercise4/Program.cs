using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers= new List<int>();
        Console.WriteLine("Enter a list of numbers, Enter 0 to stop.");
        int count = 1;
        int total = 0;
        
        while (count != 0)
        {
            Console.Write("Enter Number: ");
            string happy =Console.ReadLine();
            int newNumber = int.Parse(happy);
            
            if (newNumber!=0)
            {
                numbers.Add(newNumber);
            }
            else
            {
                count = 0;
            }
        }

        foreach (int num in numbers)
        {
            total += num;
            
        }

        Console.WriteLine($"The total is {total}");
        float avar = (float)total/numbers.Count;
        Console.WriteLine($"The average is {avar}");
        int highest = numbers.Max();
        
        Console.WriteLine($"The largest number is: {highest}");
    }
}