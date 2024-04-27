using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep2 World!");


        // Console.Write("What is your grade percentage? ");
        // string gradePercent = Console.ReadLine();
        // int percentNum = int.Parse(gradePercent);

        // if (percentNum >= 90)
        // {
        //     Console.WriteLine($"Your final grade is: A");
        // }
        // else if (percentNum >= 80)
        // {
        //     Console.WriteLine($"Your final grade is: B");
        // }
        // else if (percentNum >= 70)
        // {
        //     Console.WriteLine($"Your final grade is: C");         
        // }
        // else if (percentNum >= 60)
        // {
        //     Console.WriteLine($"Your final grade is: D");         
        // }
        // else
        // {
        //     Console.WriteLine($"Your final grade is: F");         
        // }

        // if (percentNum > 70)
        // {
        //     Console.WriteLine("You passed the course!");
        // }
        // else 
        // {
        //     Console.WriteLine("You did not pass.");
        // }

        Console.Write("What is your grade percentage? ");
        string gradePercent = Console.ReadLine();
        int percentNum = int.Parse(gradePercent);
        string letter;

        if (percentNum >= 90)
        {
            letter = "A";
        }
        else if (percentNum >= 80)
        {
            letter = "B";
        }
        else if (percentNum >= 70)
        {
            letter = "C";
        }
        else if (percentNum >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }
        
        Console.WriteLine($"Your final grade is: {letter}");

        if (percentNum > 70)
        {
            Console.WriteLine("You passed the course!");
        }
        else 
        {
            Console.WriteLine("You did not pass.");
        }

    }
}