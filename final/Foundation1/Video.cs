public class Video 
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _commentList = new List<Comment>();

    public Video (string title)
    {
        _title = title;
    }

    public int GetCommentCount ()
    {
        Console.WriteLine("Comment count: " + _commentList.Count());
        return _commentList.Count();
    }
}