public class Reception : Event
{
    private string _eventTitle;
    private string _eventDesc;
    private string _eventDate;
    private string _eventTime;
    private string _eventAddress;
    private List<string> _invitedList;
    private List<string> _rsvpList;

    public Reception (string title, string desc, string date, string time, string address, List<string> invited, List<string> rsvp) :base (title, desc, date, time, address)
    {
        _invitedList = invited;
        _rsvpList = rsvp;
    }

    public override void DisplaySummary()
    {
        return;
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