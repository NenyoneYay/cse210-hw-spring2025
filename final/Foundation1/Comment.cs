public class Comment
{
    private string _commentText;
    private string _commentAuthor;

    public Comment(string text, string author)
    {
        _commentText = text;
        _commentAuthor = author;
    }
    public void DisplayComment()
    {
        Console.WriteLine(_commentAuthor);
        Console.WriteLine(_commentText);
    }
}
