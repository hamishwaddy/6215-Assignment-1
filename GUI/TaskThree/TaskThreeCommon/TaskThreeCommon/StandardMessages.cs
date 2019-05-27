using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskThreeCommon
{
    public class StandardMessages
    {
        static public string StartApp()
        {
            return "Welcome to the Random Number Game";
        }

        static public string EndApp()
        {
            return "Thanks for playing.";
        }

        static public void DisplayGame(int num, string level, int max, int guesses, int currentGuess)
        {
            Console.Clear();
            Console.WriteLine($"Secret Num: {num}");//For Testing only, delete
            Console.WriteLine($"Random Number Guessing Game || {level} Level");
            Console.WriteLine($"Choose a number between 1 and {max}. You get {guesses} guesses.");
            Console.Write($"\n\nAttempt number {currentGuess}: ");
        }

        static public string GetName(int score)
        {
            Console.Clear();
            Console.Write($"\nGame Over\nYour score was: {score}\nPlease enter your name: ");
            return Console.ReadLine();
        }

        static public void YouWon()
        {
            Console.Clear();
            Console.WriteLine("***** CONGRATULATIONS - YOU WON *****");
            Console.WriteLine("\n\nYou guessed the correct number");
        }
    }
}
