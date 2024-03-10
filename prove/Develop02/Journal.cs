using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    private List<Entry> _entries;

    // Constructor for the Journal class.
    public Journal()
    {
        _entries = new List<Entry>();
    }

    // Adds a new entry to the list of entries.
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    // Display all entries by calling the Display method on each entry in the _entries collection.
    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

// Saves the journal entries to a CSV file specified by the 'file' parameter.
public void SaveToFile(string file)
{
    using (StreamWriter writer = new StreamWriter(file))
    {
        // Write the header line
        writer.WriteLine("Date,Prompt,Response");

        foreach (var entry in _entries)
        {
            // Write each entry as a line in the CSV file
            writer.WriteLine($"{entry.Date},{entry.PromptText},{entry.EntryText}");
        }
    }

    Console.WriteLine("Journal saved successfully in CSV format!");
}


    // LoadFromFile method reads the content of the specified file and populates the entries. If the file doesn't exist, it displays an error message.
    public void LoadFromFile(string file)
    {
        if (File.Exists(file))
        {
            _entries.Clear(); // Clear existing entries

            using (StreamReader reader = new StreamReader(file))
            {
                while (!reader.EndOfStream)
                {
                    string[] line = reader.ReadLine().Split(',');

                    if (line.Length == 3)
                    {
                        AddEntry(new Entry(line[0], line[1], line[2]));
                    }
                }
            }

            Console.WriteLine("Journal loaded successfully!");
        }
        else
        {
            Console.WriteLine("File not found. Create a new journal entry first.");
        }
    }
}
