using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string user_name;
        int user_int;
        int number_squared;

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        static string PromptUserName()
        {
            string user_name;
            Console.WriteLine("Please enter your name: ");
            user_name = Console.ReadLine();
            return user_name;
        }
        static int PromptUserNumber (string user_name)
        {
            int favorite_number;
            Console.WriteLine("Hello, " + user_name + "! Please enter your favorite number");
            favorite_number = int.Parse(Console.ReadLine());
            return favorite_number;
        }
        static int SquareNumber(int number)
        {
            int square_number = number*number;
            return square_number;
        }
        static void DisplayResult(int number, string name)
        {
            Console.WriteLine(name + ", the square of your number is " + number);
        }
        DisplayWelcome();
        user_name = PromptUserName();
        user_int = PromptUserNumber(user_name);
        number_squared = SquareNumber(user_int);
        DisplayResult(number_squared, user_name);
    }
}