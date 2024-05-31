using System.ComponentModel;

public class Scripture
{
    private Reference _reference;

    private List<Word> _word;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _word = text;
    }

    public void HideRandomWords(int numberToHide)
    {

    }

    public string DisplayText()
    {
        return "";
    }

    public void IsCompletelyHidden()
    {

    }
}