using System;
using System.IO;
using System.IO.Enumeration;
using System.Security.Cryptography.X509Certificates;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry) 
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll() 
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file) 
    {
        string filename = file;
        using (StreamWriter journalOutput = new StreamWriter(filename))
        {
            foreach (Entry e in _entries) 
            {
                journalOutput.WriteLine($"{e._date}~{e._promptText}~{e._entryText}");
            }
        }
        Console.WriteLine("File saved!");
    }

    public void LoadFromFile(string file) 
    {
        _entries.Clear();
        string filename = file;
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~");

            Entry loadEntry = new Entry();
            loadEntry._date = parts[0];
            loadEntry._promptText = parts[1];
            loadEntry._entryText = parts[2];
            
            _entries.Add(loadEntry);
        }
    }
}
