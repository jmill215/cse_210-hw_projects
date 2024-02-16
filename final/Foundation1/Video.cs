using System;
using System.Reflection;

public class Video
{
    //working with using getters in better detail
    protected string _videoTitle;

    protected string _videoAuthor;

    protected int _videoLength;

    protected List<Comment> _commentList;

    public Video(string title, string author, int length)
    {
        _videoTitle = title;

        _videoAuthor = author;

        _videoLength = length;

        _commentList = new List<Comment>();
    }

    //methods to add and return video and comment data
    public void addComment(string author, string text)
    {
        //practicing using var more often
        var newComment = new Comment(author, text);
        _commentList.Add(newComment);
    }

    public void DisplayVideoDetails()
    {
        Console.WriteLine($"Video Title: {_videoTitle}\nAuthor: {_videoAuthor}\nDuration (seconds): {_videoLength}");

        Console.WriteLine("\n Video Comments: ");
        //iterate through commentlist for video, using commentDisplay from Comment class
        foreach (var comment in _commentList)
        {
            comment.commentDisplay();
        }
        
    }
}