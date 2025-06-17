using System;
class Program
{
    static void Main(string[] args)
    {
        Rectangle myRectangle = new Rectangle("Red", 10, 8);
        // mySquare.SetColor("blue");
        Console.WriteLine("Testing: " + myRectangle.GetColor());
        Console.WriteLine("Area: " + myRectangle.GetArea());

        Circle myCircle = new Circle("purple", 7);
        // mySquare.SetColor("blue");
        Console.WriteLine("Testing: " + myCircle.GetColor());
        Console.WriteLine("Area: " + myCircle.GetArea());

        Square mySquare = new Square("silver", 4);
        // mySquare.SetColor("blue");
        Console.WriteLine("Testing: " + mySquare.GetColor());
        Console.WriteLine("Area: " + mySquare.GetArea());
    }

}