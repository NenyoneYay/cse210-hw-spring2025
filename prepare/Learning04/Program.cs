using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Assignment testAssignment = new Assignment("Bob Testingburger", "TopicTest");

        MathAssignment mathAttack = new MathAssignment("Bob Testingburger", "Math", "The Bible", "How many woodchucks can YOU sit on?");
        string mathAttackString = mathAttack.GetHomeworkList();
        Console.WriteLine(mathAttack.GetSummary());
        Console.WriteLine(mathAttackString);
        WritingAssignment writeBooks = new WritingAssignment("Stacy Bookwriter", "Writing", "Once upon a midnight hour, Stacy tasted something sour.");
        Console.WriteLine(writeBooks.GetSummary() + "\n" + writeBooks.GetWritingInformation());
    }
}