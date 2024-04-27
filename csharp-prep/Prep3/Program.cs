using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep3 World!");

        // Console.Write("What is the magic number? ");
        // string num = Console.ReadLine();
        // int magicNum = int.Parse(num);


        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1,101);




        // Console.Write("What is your guess? ");
        // string guess = Console.ReadLine();
        // int finalGuess = int.Parse(guess);

        // if (finalGuess > magicNum)
        // {
        //     Console.WriteLine("Lower");
        // }
        // else if (finalGuess < magicNum)
        // {
        //     Console.WriteLine("Higher");
        // }
        // else 
        // {
        //     Console.WriteLine("You guessed it!");
        // }


        //BELOW: USING WHILE LOOP



        int guess = -1;

        while (guess != magicNum)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNum > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNum < guess)
            {
                Console.WriteLine("Lower");
            }
            else 
            {
                Console.WriteLine("You guessed it!");
            }
        }

    }
}