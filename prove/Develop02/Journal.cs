


using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

public class Journal
{
    public string _journalName = "";
    public List<Entry> _journalContents;
    public List<string> _prompts = new List<string>();



    public Entry WriteEntry(int entryCount)
    {
        Entry tempEntry = new Entry();

        List<string> promptList =
        [
            "Who was the most interesting person you interacted with today?",
            "What was the best part of your day?",
            "How did you see the hand of the Lord in your life today?",
            "What was the strongest emotion you felt today?",
            "If you had one thing you could do over today, what would it be?",
            "What is something new that you learned today?",
            "What did you eat for your most recent meal?",
        ];
        int promptListSize = promptList.Count;
        Random randomPicker = new Random();
        int randomPromptIndex = randomPicker.Next(0, promptListSize);
        tempEntry._entryNumber = entryCount;

        Console.WriteLine("Please enter todays date: ");
        tempEntry._date = Console.ReadLine();
        Console.WriteLine("Todays prompt: " + promptList[randomPromptIndex]);
        tempEntry._userWriting = Console.ReadLine();
        return tempEntry;
    }
}