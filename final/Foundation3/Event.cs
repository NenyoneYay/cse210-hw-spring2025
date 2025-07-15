public abstract class Event
{
    private string _eventTitle;
    private string _eventDesc;
    private string _eventDate;
    private string _eventTime;
    private string _eventAddress;

    public Event(string title, string desc, string date, string time, string address)
    {
        _eventTitle = title;
        _eventDesc = desc;
        _eventDate = date;
        _eventTime = time;
        _eventAddress = address;
    }

    public abstract void DisplaySummary();
    public abstract void DisplayFull();
    public abstract void DisplayBasic();
}