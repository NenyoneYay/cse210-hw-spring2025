public class Reception : Event
{
    private List<string> _invitedList;
    private List<string> _rsvpList;

    public Reception (string title, string desc, string date, string time, List<string> invited, List<string> rsvp) :base (title, desc, date, time)
    {
        _invitedList = invited;
        _rsvpList = rsvp;
        _eventType = "Reception";
    }

    public override void DisplayFull()
    {
        DisplaySummary();
        Console.WriteLine("Guests invited:");
        foreach(string guest in _invitedList)
        {
            Console.WriteLine(guest);
        }
        Console.WriteLine("\nGuests RSVP'd:");
        foreach(string guest in _rsvpList)
        {
            Console.WriteLine(guest);
        }
        Console.WriteLine();
    }
}