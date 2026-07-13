using System;

public class Journal

{
    public List<Entry> _entries = new List<Entry>();


    public void AddEntry(Entry newJournalEntry)
    {
        _entries.Add(newJournalEntry);
    }
    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
    }
    public void LoadFromFile(string fileName)
    {
        _entries.Clear();
        
        string[] lines = File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            Entry savedEntry = new Entry();
            savedEntry._date = parts[0];
            savedEntry._promptText = parts[1];
            savedEntry._entryText = parts[2];

            _entries.Add(savedEntry);
        }
    }
}