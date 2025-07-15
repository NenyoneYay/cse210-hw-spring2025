public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture (string title, string desc, string date, string time, string speaker, int capacity) : base(title, desc, date, time)
    {
        _speaker = speaker;
        _capacity = capacity;
        _eventType = "Lecture";
    }

    public override void DisplayFull()
    {
        DisplaySummary();
        Console.WriteLine("Speaker: " + _speaker + "\nCapacity: " + _capacity);
        Console.WriteLine();
    }
}