using System;

// void DisplayMenu()
// {
//     Console.WriteLine("Testing");
// }

class Program
{
    
    static string DisplayMenu(int timer)
    {
        if (timer >= 60)
        {
            Console.WriteLine("Time spent this session: " + (timer / 60) + " minutes");
        }
        Console.WriteLine("Please select an option: \n1: Start breathing activity\n2: Start reflecting activity\n3: Start listing activity\n0:Quit");
        return Console.ReadLine();

    }
    static void Main(string[] args)
    {
        int activityCount = 0;
        LoadingScreen testingLoadingScreen = new LoadingScreen();
        bool stillRunning = true;
        string userChoice;
        int activityDuration;
        BreathingActivity breathingActivity;
        ListingActivity listingActivity;
        ReflectionActivity reflectionActivity;

        while (stillRunning)
        {
            Console.Clear();
            userChoice = DisplayMenu(activityCount);

            if (userChoice == "1")
            {
                Console.WriteLine("Now starting: Breathing activity");
                Thread.Sleep(2000);
                testingLoadingScreen.DisplayLoadingScreen();
                breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. \nClear your mind and focus on your breathing.");
                breathingActivity.DisplayStartMessage();
                activityDuration = int.Parse(Console.ReadLine());
                breathingActivity.SetDuration(activityDuration);
                breathingActivity.RunActivity();
                breathingActivity.DisplayEndMessage();
                testingLoadingScreen.DisplayLoadingScreen();
                activityCount += breathingActivity.GetDuration();

            }
            else if (userChoice == "2")
            {
                Console.WriteLine("Now starting: Reflecting activity");
                Thread.Sleep(2000);
                testingLoadingScreen.DisplayLoadingScreen(); 
                reflectionActivity = new ReflectionActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. \nThis will help you recognize the power you have and how you can use it \nin other aspects of your life.");
                reflectionActivity.DisplayStartMessage();
                activityDuration = int.Parse(Console.ReadLine());
                reflectionActivity.SetDuration(activityDuration);
                reflectionActivity.RunActivity();
                reflectionActivity.DisplayEndMessage();
                testingLoadingScreen.DisplayLoadingScreen();
                activityCount += reflectionActivity.GetDuration();
            }
            else if (userChoice == "3")
            {
                Console.WriteLine("Now starting: Listing activity");
                Thread.Sleep(2000);
                testingLoadingScreen.DisplayLoadingScreen();
                listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in life by having you \nlist as many things as you can in a certain area.");
                listingActivity.DisplayStartMessage();
                activityDuration = int.Parse(Console.ReadLine());
                listingActivity.SetDuration(activityDuration);
                listingActivity.RunActivity();
                listingActivity.DisplayEndMessage();
                testingLoadingScreen.DisplayLoadingScreen();
                activityCount += listingActivity.GetDuration();
            }

            else if (userChoice == "0")
            {
                stillRunning = false; //Break out of While loop
                Console.WriteLine("Goodbye");
                break;
            }
            else
            {
                Console.WriteLine("I'm sorry, I don't recognize the input '" + userChoice + "'. Please try again.");
            }
        }
    }
}
