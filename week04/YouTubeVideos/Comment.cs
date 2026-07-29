using System;

public class Comment
{
private string _commentAuthor;
private string _commentText;

public Comment(string name, string text)
{
_commentAuthor = name;
_commentText = text;
}

public string GetCommentAuthor()
{
return _commentAuthor;
}

public string GetCommentText()
{
return _commentText;
}

}
