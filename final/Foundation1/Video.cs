public class Video
{
    private string _title;
    private string _author;
    private int _length;
    public List<Comment> _commentList = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void DisplayVidDetails()
    {
        Console.WriteLine("Title: " + _title);
        Console.WriteLine("Duration: " + _length);
        GetCommentCount();
    }

    public void GetCommentCount()
    {
        Console.WriteLine("Comment count: " + _commentList.Count());
        // return _commentList.Count();
    }

    public void AddComment(Comment comment)
    {
        _commentList.Add(comment);
    }
}