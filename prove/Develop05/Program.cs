//Exceeds Requirements: Added a system to allow for multiple user accounts, each with a name and separately tracked quests, levels and experience points

using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static int DisplayMenu(Player player){
        int userChoice;
        player.Display();
        /*
            Add these menu options:
            1: View quests
            2: Add quest
            3: Complete quest
            4: Save and Quit
        */
        Console.WriteLine("Welcome, " + player.GetName() + "! Choose one of these options.\n1. View quests\n2: Add quest\n3: Complete quest\n4: Save and Quit\n0: Quit");//TODO: insert player name
        userChoice = int.Parse(Console.ReadLine());
        return userChoice;
    }
    static List<Player> LoadPlayers(string filePath)
    {
        List<Player> tempList = new List<Player>();
        List<Quest> tempQuestList = new List<Quest>();
        Player tempPlayer;
        Quest tempQuest;
        var lines = File.ReadAllLines(filePath);
        for (int i = 0; i < lines.Length;)
        {
            if (string.IsNullOrWhiteSpace(lines[i]))
            {
                i++;
                continue;
            }
            string name = lines[i].Trim();
            int level = int.Parse(lines[i + 1].Trim());
            int exp = int.Parse(lines[i + 2].Trim());
            

            tempPlayer = new Player(name, level, exp);
            tempList.Add(tempPlayer);


            i += 4; // Skip to next block (3 lines + 1 empty line)
        }

        return tempList;
    }
    

    static void Main(string[] args)
    {
        Console.Clear(); //Begin code with a clear console.
                         //Variable declarations
        List<Player> playerList = new List<Player>();
        string playerChoice = "";
        string questTypeChoice = "";
        int stepChoice;
        int stepWorth;
        int whileRunning = 1;
        int whileChoosePlayer = 1;
        int menuChoice = 1000;
        LoadingScreen loading = new LoadingScreen(1);
        Player currentPlayer = null;

        string tempQuestName;
        string tempQuestDesc;
        int tempQuestEXP;
        int tempQuestNum;
        Quest tempQuest;

        //Create testplayers
        Player testPlayer1 = new Player("Tom");
        Player testPlayer2 = new Player("Dick");
        Player testPlayer3 = new Player("Stanley");
        playerList.Add(testPlayer1);
        playerList.Add(testPlayer2);
        playerList.Add(testPlayer3);

        playerList = LoadPlayers("players.txt");

        Console.WriteLine("Welcome to [TODO: Cool name for app]!");


        if (playerList.Count() < 1) //If no saved players detected...
        {
            Console.WriteLine("No saved players detected! Lets create a new player.");
            Console.WriteLine("What is your players name?");
            Player tempPlayer = new Player(Console.ReadLine()); //Create a player
                                                                // tempPlayer.Display();
            playerList.Add(tempPlayer);
        }
        else
        {
            while (whileChoosePlayer == 1) //Select which player to use
            {
                Console.WriteLine("Choose your player: ");
                int tempNumber = 1;
                foreach (Player player in playerList) //Display the players in the database
                {
                    Console.WriteLine(tempNumber.ToString() + ": " + player.GetName());
                    tempNumber++;
                }
                Console.WriteLine(tempNumber.ToString() + ": Create a new player");
                playerChoice = Console.ReadLine();

                if (playerChoice == tempNumber.ToString()) //If user selects "create a new player"...
                {
                    Console.WriteLine("What is your players name?");
                    Player tempPlayer = new Player(Console.ReadLine());
                    playerList.Add(tempPlayer); //Add player to list
                    currentPlayer = tempPlayer; //Select new player as selected character.
                    whileChoosePlayer = 0;
                }
                else if ((int.Parse(playerChoice) > 0) && (int.Parse(playerChoice) < playerList.Count() + 1))
                {
                    currentPlayer = playerList[int.Parse(playerChoice) - 1];
                    whileChoosePlayer = 0;
                }
                else
                {
                    Console.WriteLine("Choice not recognized.");
                    whileChoosePlayer = 1;
                    currentPlayer = null;
                }
            }
            // currentPlayer = testPlayer1;
            //currentPlayer should now have the values of the chosen player.
            //test:
            Console.WriteLine("Testing: " + currentPlayer.GetName());
        }

        while (whileRunning == 1)
        {
            loading.DisplayLoadingScreen();
            menuChoice = DisplayMenu(currentPlayer);
            if (menuChoice == 0)
            {
                break;
            }
            else if (menuChoice == 1)
            {
                loading.DisplayLoadingScreen();
                currentPlayer.DisplayQuestList();
                Console.WriteLine("Testing");
            }
            else if (menuChoice == 2) //Add a new quest
            {
                /*
                    TODO: Update for different quest types
                */

                //Default quest: 
                loading.DisplayLoadingScreen();
                Console.WriteLine("Enter the quest name: ");
                tempQuestName = Console.ReadLine();
                Console.WriteLine("Enter the quest description: ");
                tempQuestDesc = Console.ReadLine();
                Console.WriteLine("How much EXP is this quest worth when completed? ");
                tempQuestEXP = int.Parse(Console.ReadLine());
                tempQuestNum = currentPlayer.GetQuestListLength() + 1;
                Console.WriteLine("Is this quest a...\n1: Single Quest\n2: Repeat Quest\n3: Step Quest");
                questTypeChoice = Console.ReadLine();
                if (questTypeChoice == "1")
                {
                    tempQuest = new SingleQuest(tempQuestName, tempQuestDesc, tempQuestEXP, tempQuestNum);
                }
                else if (questTypeChoice == "2")
                {
                    tempQuest = new RepeatQuest(tempQuestName, tempQuestDesc, tempQuestEXP, tempQuestNum);
                }
                else if (questTypeChoice == "3")
                {
                    Console.WriteLine("How many steps are there to this quest?");
                    stepChoice = int.Parse(Console.ReadLine());
                    Console.WriteLine("How much bonus EXP is each step worth?");
                    stepWorth = int.Parse(Console.ReadLine());
                    tempQuest = new StepQuest(tempQuestName, tempQuestDesc, tempQuestEXP, tempQuestNum, stepChoice, stepWorth);
                }
                else
                {
                    Console.WriteLine("That's not an option! Press enter to continue.");
                    Console.ReadLine();
                    tempQuest = null;
                }
                currentPlayer.AddQuest(tempQuest);

                loading.DisplayLoadingScreen();
            }
            else if (menuChoice == 3) //Complete a quest
            {
                Console.WriteLine("Enter the number of the quest to be completed.");
                currentPlayer.DisplayQuestNames();
                menuChoice = int.Parse(Console.ReadLine());
                if (menuChoice > currentPlayer.GetQuestListLength() || menuChoice < 1)
                {
                    Console.WriteLine("That number isn't in the quest list!");
                }
                else
                {
                    currentPlayer.RemoveQuest(menuChoice);
                }
                //TODO: After you remove a quest, update the quest numbers!

            }
            else if (menuChoice == 9) //This one is for testing purposes.
            {
                SingleQuest testQuest = new SingleQuest("TestyQuest", "This is a test", 10, 1);
                Console.WriteLine("Testing: " + testQuest.GetQuestType());
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Choice not recognized.");
                Console.ReadLine();
            }
        }

        //Begin wrapup code
        Console.WriteLine("goodbye, " + currentPlayer.GetName() + "!");
        //End wrapup code

        /* Begin test stuff
        // testPlayer1.Display();
        // testPlayer1.GainEXP(1500);
        // testPlayer1.Display();
        / End test stuff
        */
    }
}