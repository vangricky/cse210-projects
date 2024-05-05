using System.IO;
public class Journal {
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll() 
    {
        foreach(Entry prompt in _entries)
        {
            prompt.Display();
        }
    }
    public void SaveToFile(List<Entry> entries) 
    {
        string filename = "entry.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry e in entries)
            {
                outputFile.WriteLine($"{e._date} {e._promptText}: {e._entryText}");
            }
        }
    }

    public static List<Entry> LoadFromFile()
    {
        List<Entry> entries = new List<Entry>();
        string filename = "entry.txt";

        return entries;
    }
    
}