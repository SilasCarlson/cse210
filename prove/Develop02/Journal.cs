using System;
using System.IO;

class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    public void Save(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._text}");
            }
        }
    }

    public void Load(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            Entry entry = new Entry(parts[1], parts[2]);
            entry._date = parts[0];
            _entries.Add(entry);
        }
    }

    public List<string> GetPromptsFromToday()
    {
        List<string> prompts = new List<string>();

        foreach (Entry entry in _entries)
        {
            if (entry._date == DateTime.Now.ToString("M/d/y"))
            {
                prompts.Add(entry._prompt);
            }
        }

        return prompts;
    }
}