using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> invitedList = new List<string>() {
            "Test1", 
            "Test2"
        };
        List<string> RSVPList = new List<string>();

        Lecture testLecture = new Lecture("I have a dream", "A lecture about equality and human rights", "08/28/1963", "5:45 PM", "Washington DC", "Martin Luther King Jr.", 250000);
        Reception testReception = new Reception("Buttercups Wedding", "Mawwiage is that bwessed awwangement that bwings us togetho today", "10/9/1987", "6:00 PM", "The Kingdom of Florin", invitedList, RSVPList);
        Outdoor testOutdoor = new Outdoor("Hank Hills Barbeque", "Grilled with the cleanest burning fuel, I tell you hwhat", "1/12/1997", "5:30 PM", "84 Rainey Street", "Overcast");

        testLecture.DisplaySummary();


    }
}