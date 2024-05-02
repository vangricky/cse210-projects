using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._company = "Microsoft";

        Console.WriteLine(job1._company);

        Job job2 = new Job();
        job2._company = "Apple";

        Console.WriteLine(job2._company);
    }
}