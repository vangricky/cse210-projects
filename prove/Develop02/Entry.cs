public class Entry {
    public string _date = DateTime.Now.ToString("MM-dd-yyyy");
    
    public string _promptText;
    public string _entryText;
    public Entry() 
    {

    }
    public void Display() 
    {
        Console.WriteLine($"Date: {_date} - Prompt : {_promptText}");
        Console.WriteLine($"{_entryText}");
    }
}