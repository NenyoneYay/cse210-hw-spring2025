using System;
using System.Net.WebSockets;

class Program
{
    static void Main(string[] args)
    {
        string play_again;
        do{
            int guessed_number;
            int guesses = 0;
            Random r = new Random();
            int magic_number = r.Next(1,100);
            Console.WriteLine("Hello! Lets play the guessing number game!");
            do{
                Console.WriteLine("Choose a number between 1 and 100");
                guessed_number = int.Parse(Console.ReadLine());
                guesses ++;
                if ((guessed_number > 100) || (guessed_number < 1))
                {
                    Console.WriteLine("Your number is outside the range of 1-100! Try again!");
                    continue;
                }
                if (guessed_number == magic_number)
                {
                 break;
                }
                else if (guessed_number > magic_number)
                {
                    Console.WriteLine("Guess again! It's less than " + guessed_number + "!");
                }
                else if (guessed_number < magic_number)
                {
                    Console.WriteLine("Guess again! It's more than " + guessed_number + "!");
                }
            }while(guessed_number != magic_number);

            Console.WriteLine("You did it! The answer is " + magic_number + "! Number of guesses: " + guesses);
            Console.WriteLine("Do you want to play again? {yes} {no}");
            play_again = Console.ReadLine().ToLower();
        }while (play_again == "yes");
        Console.WriteLine("Thank you for playing!");
    }
}