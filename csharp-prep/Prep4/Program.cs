using System.Collections.Generic;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");
        // This Prep4, it will be about "lists" and how to work with them.

        //To create a list, it look like line 12:
        List<String> words = new List<string>();
        //To add values into the list:
        words.Add("phone");
        words.Add("keybaord");
        words.Add("mouse");

        //To see how many items are in the list, use .Count (it is a property, not a function):
        Console.WriteLine(words.Count);

        //To iterate through a list:
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }

        Console.WriteLine("");

        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int exitNum = -1;
        while (exitNum != 0)
        {
            Console.Write("Enter a number: ");
            string response = Console.ReadLine();
            exitNum = int.Parse(response);

            if (exitNum != 0)
            {
                numbers.Add(exitNum);
            }
        }

        int sum = 0;
        foreach(int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}