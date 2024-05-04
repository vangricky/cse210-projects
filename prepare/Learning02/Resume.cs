using System.Collections.Generic;
public class Resume {
    public string _name;
    public List<Job> _jobs = new List<Job>();
    //Ahove: This is how you create member variable for List. I also initiated it to be a new List right away as well.
    public void Display() {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach(Job job in _jobs) 
        {
            job.Display();
        }

    }
}