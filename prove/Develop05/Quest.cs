public abstract class Quest
{
    private string _questName;
    private string _questDescription;
    private int _questEXP;
    private int _questNumber;
    private string _questType;


    public Quest (string questName, string questDescription, int questEXP, int questNumber)
    {
        _questName = questName;
        _questDescription = questDescription;
        _questEXP = questEXP;
        _questNumber = questNumber;
    }
    public int CompleteQuest()
    {
        return _questEXP;
    }
    public abstract void DisplayQuest(); //TODO Make this abstract

    public abstract void DisplayQuestName();

    public abstract string GetQuestType();

    public void SetQuestNumber(int number)
    {
        _questNumber = number;
    }


}