public class LoadingScreen
{
    private string[] _loadingCharacters;
    private int _loadingTime;

    public LoadingScreen()
    {
        _loadingCharacters = new string[4] {"-", "\\", "|", "/"};
        _loadingTime = 5;
    }
    public LoadingScreen(int timer)
    {
        _loadingCharacters = new string[4] {"-", "\\", "|", "/"};
        _loadingTime = timer;
    }
    public void DisplayLoadingScreen()
    {
        Console.WriteLine("Testing");
        int timer = 0;
        int index = 0;
        while (timer < (_loadingTime*2.5))
        {
            Console.Clear();
            Console.WriteLine("{" + _loadingCharacters[index] + "} Loading...");
            index ++;
            if (index >= _loadingCharacters.Count())
            {
                index = 0;
            }
            timer ++;
            Thread.Sleep(200);
        }
        Console.Clear();
    }
}