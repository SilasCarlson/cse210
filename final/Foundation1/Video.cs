class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public void Display()
    {
        Console.WriteLine($"{_title} by {_author} ({_length}s)");
        Console.WriteLine($"Number of comments: {GetCommentCount()}");

        foreach (Comment comment in _comments)
        {
            comment.Display();
        }
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
}