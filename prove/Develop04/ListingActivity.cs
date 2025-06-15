public class ListingActivity : Activity
{
    List<string> _prompts = new List<string>()
    {
        "Who are the people that you appreciate?",
        "What are some of your personal strengths?",
        "Who are people that you have helped this week?",
        "Who are some of your personal heroes?",
        "When have you felt the spirit this month?"
    };

    public ListingActivity(string activityName, string activityDescription) : base(activityName, activityDescription)
    {

    }
    public void RunActivity()
    {
        Random r = new Random();
        int rInt = r.Next(0, _prompts.Count());
        string userResponse = "";
        long endTimerSeconds;
        DateTime beginTimer;
        Console.Clear();
        Console.WriteLine("Get ready...");
        Thread.Sleep(2000);
        Console.WriteLine("List as many responses as you can to the following prompt: \n" + _prompts[rInt]);
        Console.WriteLine();
        int timer = 3;
        Console.WriteLine("You may begin in:");
        while (timer > 0)
        {
            Thread.Sleep(1000);
            Console.WriteLine(timer);
            timer --;
        }

        beginTimer = DateTime.Now;
        long beginTimerSeconds = beginTimer.Ticks;
        beginTimerSeconds = beginTimerSeconds / 10000000;
        endTimerSeconds = beginTimerSeconds + GetDuration();
        while (beginTimerSeconds < endTimerSeconds) //End loop when duration is over
        {
            beginTimer = DateTime.Now; //Update the timer
            beginTimerSeconds = beginTimer.Ticks;
            beginTimerSeconds = beginTimerSeconds / 10000000;
            // Console.WriteLine("Testing: \n" + beginTimerSeconds + "\n" + endTimerSeconds);
            userResponse = Console.ReadLine();
        }
    }
}