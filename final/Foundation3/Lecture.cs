public class Lecture : Event
{
    private string _eventTitle;
    private string _eventDesc;
    private string _eventDate;
    private string _eventTime;
    private string _eventAddress;
    private string _speaker;
    private int _capacity;

    public Lecture (string title, string desc, string date, string time, string address, string speaker, int capacity) : base(title, desc, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override void DisplaySummary()
    {
        Console.WriteLine(_eventTitle);
    }
    public override void DisplayFull()
    {
        return;
    }
    public override void DisplayBasic()
    {
        return;
    }
}