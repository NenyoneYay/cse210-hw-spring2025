

class Reference
{
    private string _book;
    private string _verseNumbers;

    public Reference(string bookName, string reference)
    {
        _book = bookName;
        _verseNumbers = reference;
    }
    public void DisplayReference()
    {
        Console.WriteLine(_book + ":" + _verseNumbers);
    }
}

//We want the capability to read multiple verses.