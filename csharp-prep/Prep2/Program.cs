using System;
using System.Runtime.Serialization;

class Program
{
    static void Main(string[] args)
    {
        float grade_percent;
        Console.WriteLine("Hello user. What is your grade %? ");

        grade_percent = float.Parse(Console.ReadLine());

        if (grade_percent >= 93){
            //Case: A
            Console.WriteLine("You got an A!");
        } else if (grade_percent >= 90 && grade_percent < 93){
            //Case: A-
            Console.WriteLine("You got an A-!");
        } else if (grade_percent >= 87 && grade_percent < 90){
            //Case: B+
            Console.WriteLine("You got a B+!");
        } else if (grade_percent >= 83 && grade_percent < 87){
            //Case: B
            Console.WriteLine("You got a B!");
        } else if (grade_percent >= 80 && grade_percent < 83){
            //Case: B-
            Console.WriteLine("You got a B-!");
        } else if (grade_percent >= 77 && grade_percent < 80){
            //Case C+
            Console.WriteLine("You got a C+!");
        } else if (grade_percent >= 73 && grade_percent < 77){
            //Case C
            Console.WriteLine("You got a C!");
        } else if (grade_percent >= 70 && grade_percent < 73){
            //Case C-
            Console.WriteLine("You got a C-!");
        } else if (grade_percent >= 67 && grade_percent < 70){
            //Case D+
            Console.WriteLine("You got a D+!");
        } else if (grade_percent >= 63 && grade_percent < 67){
            //Case D
            Console.WriteLine("You got a D!");
        } else if (grade_percent >= 60 && grade_percent < 63) {
            //Case D-
            Console.WriteLine("You got a D-!");
        } else if (grade_percent < 60){
            //Case F
            Console.WriteLine("You got an F!");
        }
        if (grade_percent >= 70){
            Console.WriteLine("You passed the class! Nicely done!");
        }else{
            Console.WriteLine("You failed the class! Better luck next time!");
        }
    }
}