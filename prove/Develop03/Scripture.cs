using System.ComponentModel;
using System;

public class Scripture
{
    private Reference _reference;

    private List<Word> _word;

    public Scripture(string book, int chapter, int verse, string text)
    {
        _reference = new Reference(book, chapter, verse);
        _word = text.Split(' ').Select(word => new Word(word)).ToList();

    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        List<Word> unhiddenWords = _word.Where(word => !word.isHidden()).ToList();

        if (unhiddenWords.Count > 0)
        {
            int randomIndex = random.Next(0, unhiddenWords.Count);
            unhiddenWords[randomIndex].Hide();
        }
    }

    public void Displaytext()
    {
        Console.WriteLine($"Reference: {_reference}");
        foreach (Word word in _word)
        {
            Console.WriteLine($"{word.GetDisplayText()}");
        }
        Console.WriteLine();
    }

    public bool completelyHidden()
    {
        return _word.All(word => word.isHidden());
    }
}