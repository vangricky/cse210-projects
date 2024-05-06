using System.IO;
public class Journal {
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry()
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        Entry anEntry = new Entry();
        anEntry._promptText = promptGenerator.GetRandomPrompt();
        Console.WriteLine(anEntry._promptText);
        anEntry._entryText = Console.ReadLine();

        _entries.Add(anEntry);
    }

    public void DisplayAll() 
    {
        foreach(Entry prompt in _entries)
        {
            prompt.Display();
        }
    }
    public void SaveToFile() 
    {
        Console.WriteLine("Name your journal: ");
        string filename = Console.ReadLine() + ".txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry e in _entries)
            {
                outputFile.WriteLine($"{e._date},{e._promptText},{e._entryText}");
            }
        }
    }

    public void LoadFromFile()
    {
        _entries.Clear();
        Console.WriteLine("Enter a journal name to load: ");
        string filename = Console.ReadLine() + ".txt";
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

           Entry anEntry = new Entry();
           anEntry._date = parts[0];
           anEntry._promptText = parts[1];
           anEntry._entryText = parts[2];
            _entries.Add(anEntry);

        }
    }

    internal void AddEntry(string answer)
    {
        throw new NotImplementedException();
    }
}