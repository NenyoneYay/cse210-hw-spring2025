public class Outdoor : Event
{
    private string _eventTitle;
    private string _eventDesc;
    private string _eventDate;
    private string _eventTime;
    private string _eventAddress;
    private string _weatherStatus;

    public Outdoor (string title, string desc, string date, string time, string address, string weather) :base(title, desc, date, time, address)
    {
        _weatherStatus = weather;
    }

    public void SetWeather(string weather)
    {
        _weatherStatus = weather;
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