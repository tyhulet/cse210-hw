using System.ComponentModel;
using System;

public class Scripture
{
    private Reference _reference;

    private List<Word> _word;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _word = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void hideRandomWords()
    {
        Random random = new Random();
        List<Word> unhiddenWords = _word.Where(word => !word.isHidden()).ToList();

        if (unhiddenWords.Count > 0)
        {
            int randomIndex = random.Next(0, unhiddenWords.Count);
            unhiddenWords[randomIndex].Hide();
        }
    }

    public void displayText()
    {
        Console.WriteLine($"Reference: {_reference}");
        foreach (Word word in _word)
        {
            Console.WriteLine($"{word.GetDisplayText()}");
        }
        Console.WriteLine();
    }

    public bool IsCompletelyHidden()
    {
        return _word.All(word => word.isHidden());
    }
}