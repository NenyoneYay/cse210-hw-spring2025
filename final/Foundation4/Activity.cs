public abstract class Activity
{
    protected string _activityDate;
    protected int _activityLength; //Minutes
    
    public Activity(string date, int length)
    {
        _activityDate = date;
        _activityLength = length;
    }
    public void SetLength(int length)
    {
        _activityLength = length;
    }
}