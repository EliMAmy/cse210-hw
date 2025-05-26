public class Journal
{
    public List<Entry> _entries= new List<Entry>();
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry item in _entries)
        {
            item.Display();
        }
    }
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry item in _entries)
            {
                outputFile.WriteLine($"{item._date}-{item._promptText}-{item._entryText}");
            }
        }
    }
    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);
        _entries = new List<Entry>();
        foreach (string line in lines)
        {
            string[] parts = line.Split("-");
            string Date = parts[0];
            string Prompt = parts[1];
            string Text = parts[2];

            if (parts.Length == 3)
            {
                Entry pastEntries = new Entry();
                pastEntries._date = Date;
                pastEntries._entryText = Text;
                pastEntries._promptText = Prompt;
                _entries.Add(pastEntries);
            }
        }    
    }
}