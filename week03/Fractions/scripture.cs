using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference; // Stores the reference for the scripture  
    private List<Word> _words;    // Stores the list of Word objects  
    private static Random random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // Split the text into words and create Word objects  
        foreach (string wordText in text.Split(' ', StringSplitOptions.RemoveEmptyEntries))
        {
            _words.Add(new Word(wordText));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        if (numberToHide > _words.Count)
        {
            numberToHide = _words.Count;
        }

        int count = 0;

        while (count < numberToHide)
        {
            int index = random.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                count++;
            }
        }
    }

    public void HideAllWords()
    {
        foreach (var word in _words)
        {
            word.Hide();
        }
    }

    public string GetDisplayText()
    {
        return string.Join(" ", _words.Select(w => w.GetDisplayText()));
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}