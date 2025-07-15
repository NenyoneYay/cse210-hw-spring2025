public abstract class Event
{
    protected string _eventTitle;
    protected string _eventDesc;
    protected string _eventDate;
    protected string _eventTime;
    protected string _eventAddress;
    protected string _eventType;
    protected Address _address;

    public Event(string title, string desc, string date, string time)
    {
        _eventTitle = title;
        _eventDesc = desc;
        _eventDate = date;
        _eventTime = time;
    }

    public void SetAddress(string street, string city, string state, string zip)
    {
        _address = new Address(street, city, state, zip);
    }

    public void DisplaySummary()
    {
        Console.WriteLine("Event title: " + _eventTitle + "\nType: " + _eventType + "\nDescription: " + _eventDesc + "\nDate: " + _eventDate + " " + _eventTime);
        _address.DisplayAddress();
        Console.WriteLine();
    }
    public abstract void DisplayFull();
    public void DisplayBasic()
    {
        Console.WriteLine("Event title: " + _eventTitle + "\nType: " + _eventType + "\nDate: " + _eventDate);
        Console.WriteLine();
    }
    
}