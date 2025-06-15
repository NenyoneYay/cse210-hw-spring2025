public class Activity
{
    private string _activityName;
    private string _activityDescription;
    private int _activityDuration;
    public Activity (string name, string description)
    {
        _activityName = name;
        _activityDescription = description;
    }
    public void DisplayStartMessage()
    {
        Console.WriteLine("Welcome to the " + _activityName + ". " + _activityDescription + "\nHow many seconds would you like to do this activity? ");
    }
    public void DisplayEndMessage()
    {
        Console.WriteLine("All done with the "+ _activityName + "! Press any key to return to main menu.");
        Console.ReadLine();
        Console.Clear();
    }
    public int GetDuration()
    {
        return _activityDuration;
    }
    public void SetDuration(int time)
    {
        _activityDuration = time;
    }
}