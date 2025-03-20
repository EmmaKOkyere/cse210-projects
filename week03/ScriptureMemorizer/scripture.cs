using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference; 
    private List<Word> _words;    
    private static Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(wordText => new Word(wordText)).ToList();
    }

    public void HideRandomWord()
    {
        int index = _random.Next(_words.Count);
        _words[index].Hide();
    }

    public bool AllWordsHidden()
    {
        return _words.All(w => w.IsHidden());
    }

    public string GetDisplayText()
    {
        return $"{_reference.GetDisplayText()}\n" + string.Join(" ", _words.Select(w => w.GetDisplayText()));
    }
}