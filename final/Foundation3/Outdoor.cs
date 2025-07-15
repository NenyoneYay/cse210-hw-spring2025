public class Outdoor : Event
{
    private string _weatherStatus;

    public Outdoor (string title, string desc, string date, string time, string weather) :base(title, desc, date, time)
    {
        _weatherStatus = weather;
        _eventType = "Outdoors";
    }

    public void SetWeather(string weather)
    {
        _weatherStatus = weather;
    }

    public override void DisplayFull()
    {
        DisplaySummary();
        Console.WriteLine("Weather: " + _weatherStatus);
        Console.WriteLine();
    }
}