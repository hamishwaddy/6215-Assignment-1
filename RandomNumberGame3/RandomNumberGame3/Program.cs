using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGame3
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Select Level
            // Make guesses
            // If correct, score points
            // Display results to player (points scored, level points scored on, enter username)

            Console.WriteLine(StandardMessages.StartApp());
            bool keepGoing = true;
            Console.WriteLine("\n\nSelect your game level\n\t1 - Easy\n\t2 - Medium\n\t3 - Hard\n\t4 - Exit");
            string input = Console.ReadLine();
            do
            {
                if (input == "1")
                {
                    IGameModel newGame = new EasyLevel();
                    Console.Clear();
                    Console.WriteLine($"Random Number Guessing Game || {newGame.DifficultyLevel} Level");
                    Console.WriteLine($"Secret Num: {newGame.SecretNumber}");
                    Console.WriteLine($"Choose a number between 1 and {newGame.MaxNumber}. You get {newGame.MaxGuesses} guesses.");
                    Console.Write("\n\nEnter first guess: ");
                    int guess = int.Parse(Console.ReadLine());
                    guess = newGame.CurrentGuess;
                    newGame.CalculateScore(guess);
                }
                else if (input == "2")
                {
                   
                }
                else if (input == "3")
                {
                }
                else if (input == "4")
                {
                    keepGoing = false;
                }
                else
                    keepGoing = true;
                    
            } while (keepGoing == true);



            Console.ReadLine();
        }
    }
}
