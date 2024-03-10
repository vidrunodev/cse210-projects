using System;

class Entry
{
    public string Date { get; private set; }
    public string PromptText { get; private set; }
    public string EntryText { get; private set; }  

    // Constructor for creating a new Entry object with the given date, prompt text, and entry text.
    public Entry(string date, string promptText, string entryText)
    {
        Date = date;
        PromptText = promptText;
        EntryText = entryText;
    }

    // Display the date, prompt text, and entry text.
    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {PromptText}");
        Console.WriteLine($"Response: {EntryText}\n");
    }
}
