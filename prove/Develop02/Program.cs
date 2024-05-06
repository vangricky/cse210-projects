using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator PromptGet = new PromptGenerator();
        PromptGet.GetRandomPrompt();

        Journal journal = new Journal();
    
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

                journal.AddEntry();
            }
            else if (digit == 2)
            {
                journal.DisplayAll();
            }
            else if (digit == 3) 
            {
                journal.LoadFromFile();
            }
            else if (digit == 4)
            {
                journal.SaveToFile();
            }
            else
            {
                break;
            }


        }



    }
}