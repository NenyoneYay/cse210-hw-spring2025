public class StepQuest : Quest
{
    private string _questName;
    private string _questDescription;
    private int _questEXP;
    private int _questNumber;
    private int _steps;
    private int _completedSteps;
    private int _stepWorth;
    private string _questType = "Step Quest";

    public StepQuest (string questName, string questDescription, int questEXP, int questNumber, int steps, int stepWorth) :base(questName, questDescription, questEXP, questNumber)
    {
        _questName = questName;
        _questDescription = questDescription;
        _questEXP = questEXP;
        _questNumber = questNumber;
        _steps = steps;
        _stepWorth = stepWorth;
        _completedSteps = 0;
    }

    public override void DisplayQuest()
    {
        Console.WriteLine("Quest # " + _questNumber + "\nQuest: " + _questName + "\n" + GetQuestType() + "\n"+ _questDescription + "\nEXP upon completion: " +  _questEXP + "\nProgress: "+ _completedSteps + "/" + _steps);
    }

    public override void DisplayQuestName()
    {
        Console.WriteLine("#" + _questNumber + " " + _questName + "[" + _completedSteps + "/" + _steps + "]");
    }

    public int CompleteStep()
    {
        return _stepWorth;
    }

    public void IncStep()
    {
        _completedSteps ++;
    }

    public int GetCompletedSteps()
    {
        return _completedSteps;
    }
    public int GetSteps()
    {
        return _steps;
    }

    public override string GetQuestType()
    {
        return _questType;
    }
}