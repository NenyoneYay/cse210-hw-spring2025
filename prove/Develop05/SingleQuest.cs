public class SingleQuest : Quest
{
    private string _questName;
    private string _questDescription;
    private int _questEXP;
    private int _questNumber;
    private string _questType = "Single Quest";

    public SingleQuest (string questName, string questDescription, int questEXP, int questNumber):base(questName, questDescription, questEXP, questNumber)
    {
        _questName = questName;
        _questDescription = questDescription;
        _questEXP = questEXP;
        _questNumber = questNumber;
    }

    public override void DisplayQuest()
    {
        Console.WriteLine("Quest # " + _questNumber + "\nQuest: " + _questName + "\n" + GetQuestType() + "\n"+ _questDescription + "\nEXP upon completion: " +  _questEXP);
    }

    public override void DisplayQuestName()
    {
        Console.WriteLine("#" + _questNumber + " " + _questName);
    }

    public override string GetQuestType()
    {
        return _questType;
    }
}