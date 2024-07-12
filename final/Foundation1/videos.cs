using System.Runtime.InteropServices;
using System.Transactions;

public class Videos
{
    public string _videoTitle;

    public string _videoAuthor;

    public int _videoLength;

    public List<Comments> _comment = new List<Comments>();

    public Videos(string videoTitle, string videoAuthor, int videoLength)
    {
        _videoTitle = videoTitle;
        _videoAuthor = videoAuthor;
        _videoLength = videoLength;
    }

    public void AddComment(Comments comment)
    {
        _comment.Add(comment);
    }

    public int commentsCounter()
    {
        int count = 0;
        count = _comment.Count;
        return count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Video Title: {_videoTitle}");
        Console.WriteLine($"Video Author: {_videoAuthor}");
        Console.WriteLine($"Video Length in Secounds: {_videoLength}");
        int totalcomments = commentsCounter();
        Console.WriteLine($"Totla number of comments: {totalcomments}");

        foreach (Comments comment in _comment)
        {
            comment.DisplayComments();
        }
    }
}