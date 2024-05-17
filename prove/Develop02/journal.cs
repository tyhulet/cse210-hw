using System;
using System.IO;
using System.Collections.Generic;

public class Journal
{
    public List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine($"{entry.Date} | {entry.Prompt} | {entry.entryText}");
        }

    }

    public void SaveToFile(string FileName)
    {
        using (StreamWriter writer = new StreamWriter(FileName))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.Date} | {entry.Prompt} | {entry.entryText}");
            }
        }
        Console.WriteLine("Saved");
    }

    public void LoadFromFile(string fileName)
    {
        entries.Clear();
        try
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        Entry entry = new Entry(parts[1], parts[2], parts[0]);
                        entries.Add(entry);
                    }

                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not Found.");
        }

    }
}