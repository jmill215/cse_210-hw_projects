using System;

public class Comment
{
    protected string _commentAuthor;

    protected string _commentText;

    public Comment(string author, string text)
    {
        _commentAuthor = author;

        _commentText = text;
    }

    
    
    public void commentDisplay()
    {
        Console.WriteLine($"{_commentAuthor} - {_commentText}");
    }
}   