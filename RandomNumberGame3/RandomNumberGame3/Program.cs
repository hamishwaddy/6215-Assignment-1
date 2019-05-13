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
            int input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                IGameModel newGame = new EasyLevel();
                newGame.E
                do
                {
                    Console.Clear();
                    Console.WriteLine(newGame.LevelComplete);//remove
                    Console.WriteLine($"Random Number Guessing Game || {newGame.DifficultyLevel} Level");
                    Console.WriteLine($"Secret Num: {newGame.SecretNumber}");
                    Console.WriteLine($"Choose a number between 1 and {newGame.MaxNumber}. You get {newGame.MaxGuesses} guesses.");
                    Console.Write("\n\nEnter first guess: ");
                    int guess = int.Parse(Console.ReadLine());
                    newGame.CurrentGuess = guess;

                    newGame.CalculateScore();

                    if (newGame.LevelComplete)
                        input++;

                } while (newGame.CurrentGuessCount < 3 );
                if (newGame.GameOver)
                {
                    Console.Clear();
                    Console.WriteLine(newGame.Score);//remove
                    Console.Write("Game Over, please enter your name: ");

                    newGame.UN = Console.ReadLine();

                    Console.WriteLine(newGame.UN);

                    Console.ReadLine();
                }
                newGame.
            }
            if (input == 2)
            {
                IGameModel newGame = new MediumLevel();
                do
                {
                    Console.Clear();
                    Console.WriteLine($"Random Number Guessing Game || {newGame.DifficultyLevel} Level");
                    Console.WriteLine($"Secret Num: {newGame.SecretNumber}");
                    Console.WriteLine($"Choose a number between 1 and {newGame.MaxNumber}. You get {newGame.MaxGuesses} guesses.");
                    Console.Write("\n\nEnter first guess: ");
                    int guess = int.Parse(Console.ReadLine());
                    newGame.CurrentGuess = guess;
                    newGame.CalculateScore();
                    if (newGame.LevelComplete)
                        input++;
                } while (newGame.CurrentGuessCount < 3 || newGame.LevelComplete == true);
                if (newGame.GameOver)
                {
                    Console.Clear();
                    Console.WriteLine("Game Over...");
                }

            }
            if (input == 3)
            {
            }
            if (input == 4)
            {
                keepGoing = false;
            }
            else
                keepGoing = true;

            Console.ReadLine();
        }
    }
}
