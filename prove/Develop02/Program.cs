using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator PromptGet = new PromptGenerator();
        PromptGet.GetRandomPrompt();

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        Journal journal = new Journal();

        Entry e = new Entry();
    
        int digit = -1;
        string answer = "";
        while (digit != 5)
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do? ");
            digit = int.Parse(Console.ReadLine());

            if (digit == 1)
            {
                Console.WriteLine(PromptGet.GetRandomPrompt());
                answer = Console.ReadLine();
                Console.WriteLine("");
            }
            else if (digit == 2)
            {
                 Console.WriteLine(answer);
                 Console.WriteLine("");
            }
            else if (digit == 3) 
            {
                
            }
            else if (digit == 4)
            {
                
            }
            else
            {
                break;
            }


        }



    }
}