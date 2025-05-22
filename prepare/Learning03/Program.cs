using System;
using System.Xml.Schema;

class Program
{
    static void Main(string[] args)
    {
        string fractionString;
        double fractionDouble;

        Fraction fractionOne = new Fraction(); // Test case: No parameters set, t/b = 1/1
        fractionString = fractionOne.GetFractionString();
        fractionDouble = fractionOne.GetDecimalValue();
        Console.WriteLine(fractionString);
        Console.WriteLine(fractionDouble);

        Fraction fractionTwo = new Fraction(5); //Test case: One parameter set, t/b = t/1
        fractionString = fractionTwo.GetFractionString();
        fractionDouble = fractionTwo.GetDecimalValue();
        Console.WriteLine(fractionString);
        Console.WriteLine(fractionDouble);

        Fraction fractionThree = new Fraction(3, 4); //Test case: Two parameters set, t/b = t/b
        fractionString = fractionThree.GetFractionString();
        fractionDouble = fractionThree.GetDecimalValue();
        Console.WriteLine(fractionString);
        Console.WriteLine(fractionDouble);

        Fraction fractionFour = new Fraction(); //Test case: set and get variables.
        Console.WriteLine("Top number: " + fractionFour.GetTopNumber());
        Console.WriteLine("Bottom number: " + fractionFour.GetBottomNumber()); //Read default numbers
        fractionFour.SetTopNumber(9);
        fractionFour.SetBottomNumber(2);    //Set new numbers in top and bottom
        Console.WriteLine("Top number: " + fractionFour.GetTopNumber());
        Console.WriteLine("Bottom number: " + fractionFour.GetBottomNumber()); //Read new numbers
        Console.WriteLine(fractionFour.GetFractionString());
        Console.WriteLine(fractionFour.GetDecimalValue());

    }
}