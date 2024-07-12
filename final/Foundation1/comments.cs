using System.Data;

public class Comments
{
    public string _commentName;

    public string _commentText;

    public Comments(string commentName, string commentText)
    {
        _commentName = commentName;
        _commentText = commentText;
    }

    public void DisplayComments()
    {
        Console.WriteLine($"{_commentName} : {_commentText}");
    }


}