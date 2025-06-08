using System;

//Stretch goal: Added a function to Scripture called Test() that prompts the user to type the scripture from memory, and compares their typed out scripture to the reference scripture (does not penalize changes in capitalization)

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Scripture testScriptureOne = new Scripture("Proverbs", "3:5", "Trust in the Lord with all thine heart; and lean not unto thine own understanding");
        // testScriptureOne.Memorize();
        // testScriptureOne.Test();
        Scripture testScriptureTwo = new Scripture("2 Nephi", "9:28-29", "28: O that cunning plan of the evil one! O the vainness, and the frailties, and the foolishness of men! When they are learned they think they are wise, and they hearken not unto the counsel of God, for they set it aside, supposing they know of themselves, wherefore, their wisdom is foolishness and it profiteth them not. And they shall perish.", "29 But to be learned is good if they hearken unto the counsels of God.");
        // testScriptureTwo.Memorize();
        Scripture testScriptureThree = new Scripture("D&C", "64:9-11", "9 Wherefore, I say unto you, that ye ought to forgive one another; for he that forgiveth not his brother his trespasses standeth condemned before the Lord; for there remaineth in him the greater sin.", "10 I, the Lord, will forgive whom I will forgive, but of you it is required to forgive all men.", "11 And ye ought to say in your hearts—let God judge between me and thee, and reward thee according to thy deeds.");
        testScriptureThree.Memorize();
        // testScriptureThree.Test();
    }
}