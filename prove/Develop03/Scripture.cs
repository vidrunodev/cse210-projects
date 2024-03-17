using System;
using System.Collections.Generic;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // Split the text into words
        string[] wordArray = text.Split(' ');

        // Create Word objects for each word in the text
        foreach (string wordText in wordArray)
        {
            _words.Add(new Word(wordText));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        int wordsHidden = 0;

        while (wordsHidden < numberToHide)
        {
            int index = rand.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                wordsHidden++;
            }
        }
    }

    public void ReplaceHiddenWords(string replacement)
    {
        for (int i = 0; i < _words.Count; i++)
        {
            if (_words[i].IsHidden())
            {
                _words[i].Replace(replacement);
                // Once a hidden word is replaced, break the loop
                break;
            }
        }
    }

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + ": ";

        foreach (Word word in _words)
        {
            displayText += word.IsHidden() ? "____ " : word.GetDisplayText() + " ";
        }

        return displayText.Trim(); // Remove trailing space
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
