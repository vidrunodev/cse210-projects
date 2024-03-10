using System;
using System.Collections.Generic;

class PromptGenerator
{
    private List<string> _prompts;

    // Constructor for PromptGenerator class, initializes _prompts with default prompts and adds custom prompts if provided.
    public PromptGenerator(List<string> customPrompts)
    {
        _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        // Include custom prompts
        _prompts.AddRange(customPrompts);
    }

    // Returns a random prompt from the list of prompts.
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}
