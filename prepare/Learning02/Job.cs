public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine("Company: " + _company + "\nJob title: " + _jobTitle + "\nFrom " + _startYear + "-" + _endYear + "\n");
    }
}