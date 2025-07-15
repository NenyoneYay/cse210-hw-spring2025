using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> invitedList = new List<string>() {
            "Clark", 
            "Toby", 
            "Sam"
        };
        List<string> RSVPList = new List<string>(){
            "Clark",
            "Toby"
        };

        Lecture testLecture = new Lecture("I have a dream", "A lecture about equality and human rights", "08/28/1963", "5:45 PM", "Martin Luther King Jr.", 250000);
        Reception testReception = new Reception("Buttercups Wedding", "Mawwiage is that bwessed awwangement that bwings us togetho today", "10/9/1987", "6:00 PM", invitedList, RSVPList);
        Outdoor testOutdoor = new Outdoor("Hank Hills Barbeque", "Grilled with the cleanest burning fuel, I tell you hwhat", "1/12/1997", "5:30 PM", "Overcast");

        testLecture.SetAddress("Washington Monument", "Washington DC", "Washington DC", "14220");
        testReception.SetAddress("63 Forest Street", "Florence", "Florin Kingdom", "63445");
        testOutdoor.SetAddress("84 Rainy Street", "Arlin", "Texas", "99330");
        //Full displays
        testLecture.DisplayFull();
        testReception.DisplayFull();
        testOutdoor.DisplayFull();
        testOutdoor.SetWeather("Sunny");
        testOutdoor.DisplayFull();
        Console.ReadLine();

        //Display summaries
        testLecture.DisplaySummary();
        testReception.DisplaySummary();
        testOutdoor.DisplaySummary();
        Console.ReadLine();

        testLecture.DisplayBasic();
        testReception.DisplayBasic();
        testOutdoor.DisplayBasic();
        Console.ReadLine();
    }
}