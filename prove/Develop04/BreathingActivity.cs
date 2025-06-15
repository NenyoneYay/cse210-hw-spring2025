public class BreathingActivity : Activity
{
    public BreathingActivity(string activityName, string activityDescription) : base(activityName, activityDescription)
    {
        
    }
    public void RunActivity()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        Thread.Sleep(5000);
        int timer = 0;
        while (timer < GetDuration()){
            Console.WriteLine("Breathe in...");
            Thread.Sleep(5000);
            Console.WriteLine("\n\nNow breathe out...");
            Thread.Sleep(5000);
            timer += 10;
        }
    }

}