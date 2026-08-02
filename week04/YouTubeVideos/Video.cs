using System;
using System.Collections.Generic;

public class Video
{
    private string _videoName;
    private string _videoAuthor;
    private int _videoLength;
    private List<Comment> _comments;

    public Video(string name, string author, int length)
    {
        _videoName = name;
        _videoAuthor = author;
        _videoLength = length;
        _comments = new List<Comment>();
    }


    public int CommentCount()
    {
        return _comments.Count;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public string GetVideoName()
    {
        return _videoName;
    }


    public string GetVideoAuthor()
    {
        return _videoAuthor;
    }


    public int GetVideoLength()
    {
        return _videoLength;
    }


    public List<Comment> GetComments()
    {
        return _comments;
    }

}
