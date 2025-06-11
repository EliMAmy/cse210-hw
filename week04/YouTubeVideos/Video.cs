using System;
using System.Transactions;
public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();

    public void AddComment(Comment newComment)
    {
        _comments.Add(newComment);
    }

    public int ShowNumberComments()
    {
        int Numbersof = _comments.Count;
        return Numbersof;
    }

    public void DisplayAll()
    {
        Console.WriteLine($"\n{_title}, ({_author}): {_length} seconds\n");
        foreach (Comment comment in _comments)
        {
            comment.Display();
        }
    }
}