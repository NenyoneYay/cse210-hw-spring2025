public class Player
{
    private string _playerName;
    private int _playerLevel = 0;
    private int _playerEXP = 0;
    List<Quest> _questList;

    public Player(string name)
    {
        _playerName = name;
        _playerLevel = 1;
        _playerEXP = 0;
        _questList = new List<Quest>();
        SingleQuest _tutorialQuest = new SingleQuest("Tutorial", "This is a tutorial quest!", 10, _questList.Count()+1);
        _questList.Add(_tutorialQuest);
    }

    public Player(string name, int level, int exp) //, List<Quest> questList
    {
        _playerName = name;
        _playerLevel = level;
        _playerEXP = exp;
        // _questList = questList;
    }

    public void Display() //Display to console players name, level and EXP
    {
        Console.WriteLine("Player name: " + _playerName + "\nLevel: " + _playerLevel + "\nEXP: " + _playerEXP + "/1000");
    }
    public void DisplayName()
    {
        Console.WriteLine(_playerName);
    }
    public string GetName()
    {
        return _playerName;
    }
    public void GainEXP(int amount) //Increase EXP, and level up if EXP reaches 1000.
    {
        _playerEXP += amount;
        if (_playerEXP >= 1000)
        {
            _playerLevel ++;
            _playerEXP -= 1000;
        }
    }
    public void DisplayQuestList()
    {
        foreach(Quest quest in _questList)
        {
            quest.DisplayQuest();
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
        }
    }
    public void DisplayQuestNames()
    {
        foreach(Quest quest in _questList)
        {
            quest.DisplayQuestName();
        }
    }
    public int GetQuestListLength()
    {
        return _questList.Count();
    }
    public void AddQuest(Quest quest)
    {
        _questList.Add(quest);
    }
    public void RemoveQuest(int number)
    {
        int i = 0;
        
        if (_questList[number-1].GetQuestType() == "Single Quest")
        {
            GainEXP(_questList[number-1].CompleteQuest()); //Gain EXP for the quest
            _questList.Remove(_questList[number-1]);       //Remove quest from list.

            i = 1;
            foreach(Quest quest in _questList) //Reset all the quest numbers in the list.
            {
                quest.SetQuestNumber(i);
                i++;
            }
        }
        else if (_questList[number-1].GetQuestType() == "Repeat Quest")
        {
            GainEXP(_questList[number-1].CompleteQuest()); //Gain EXP for the quest

        }
        else if (_questList[number-1] is StepQuest stepQuest)
        {
            GainEXP(stepQuest.CompleteStep());
            stepQuest.IncStep();
            if (stepQuest.GetCompletedSteps() == stepQuest.GetSteps())
            {
                Console.WriteLine("You completed the quest!");
                _questList.Remove(stepQuest);
                i = 1;
                foreach(Quest quest in _questList) //Reset all the quest numbers in the list.
                {
                    quest.SetQuestNumber(i);
                    i++;
                }
            }
        }
        // else if (_questList[number-1].GetQuestType() == "Step Quest")
        // {
        //     GainEXP(_questList[number-1].CompleteStep());
        //     _questList[number-1].IncStep();
        //     if (_questList[number-1].GetCompletedSteps() == _questList[number-1].GetSteps())
        //     {
        //         Console.WriteLine("You completed the quest!");
        //         _questList.Remove(_questList[number-1]);
        //         int i = 1;
        //         foreach(Quest quest in _questList) //Reset all the quest numbers in the list.
        //         {
        //             quest.SetQuestNumber(i);
        //             i++;
        //         }
        //     }
        // }
    }
}