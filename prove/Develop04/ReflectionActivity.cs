public class ReflectionActivity : Activity
{
    LoadingScreen _reflectLoad = new LoadingScreen(3);
    List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity(string activityName, string activityDescription) : base(activityName, activityDescription)
    {
        
    }
    public void RunActivity()
    {
        Random r = new Random();
        int rInt = r.Next(0, _prompts.Count());
        int rQInt = r.Next(0, _questions.Count());
        string userResponse = "";
        long endTimerSeconds;
        DateTime beginTimer;
        Console.Clear();
        Console.WriteLine("Get ready...");
        Console.WriteLine("Consider the following prompt: " + _prompts[rInt]);
        Console.WriteLine();
        Thread.Sleep(2000);

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
            rQInt = r.Next(0, _questions.Count());
            Console.WriteLine(_questions[rQInt]);
            userResponse = Console.ReadLine();
            _reflectLoad.DisplayLoadingScreen();
        }
    }
}