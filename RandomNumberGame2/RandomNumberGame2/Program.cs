using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGame2
{
    class Program
    {
        const int MinGuessValue = 1;
        int MaxGuessValue;
        const int GuessesAllowed = 3;
        static Random rand = new Random();


        static void Main(string[] args)
        {
            Console.WriteLine("***** RANDOM NUMBER GAME *****\n\n");

            int userGuess = 0;
            do
            {
                Console.Write("Enter your player name (max 5 characters): ");
                string userName = Console.ReadLine();
                EnterUserName(userName);
                Console.WriteLine("\nYour player name is: {0}\n", userName);

                Console.WriteLine("Choose the level you want to play:\n\t1 - Easy\n\t2 - Medium\n\t3 - Hard");
                string userLevelChoice = Console.ReadLine();
                ChooseDifficultyLevel(userLevelChoice, userGuess);
            
                Console.WriteLine("$Guess a number between {MinGuessValue} & {MaxGuessValue}");
                userGuess = int.Parse(Console.ReadLine());
            } while (ContinueGame());

            Console.ReadLine();
        }

        static string EnterUserName(string userName)
        {
            int trimLength = 5;
            if (userName.Length > trimLength)
                userName = userName.Remove(trimLength);
            return userName;
        }

        static void ChooseDifficultyLevel(string userLevelChoice, int userGuess)
        {
            if (userLevelChoice == "1")
            {
                PlayEasyLevel(userGuess);
            }
            else if (userLevelChoice == "2")
            {
                PlayMediumLevel(userGuess);
            }
            else
                PlayHardLevel(userGuess);
        }

        static string PlayEasyLevel(int userGuess)
        {
            const int maxGuessValue = 5;  //HOW DO I PASS THIS VALUE TO 'MAIN'???
            int guessCount = 0;
            int targetNumber = rand.Next(0, 6);

            while (guessCount < GuessesAllowed)
            {
                guessCount += 1;
                userGuess = ReadGuess();

                if (userGuess != targetNumber)
                {
                    return "Your guess was incorrect. Try again.";
                }
                else if (userGuess == targetNumber)
                {
                    break;
                }
            }

            if (guessCount < GuessesAllowed)
            {
                return $"CONGRATS! You guessed the secret number '{targetNumber}' in {guessCount} attempts.";
            }
            else
            {
                return $"Hard luck, the number you were after was {targetNumber}.";
            }
        }

        static string PlayMediumLevel(int userGuess)
        {
            constMaxGuessValue = 10;
            int guessCount = 0;
            int targetNumber = rand.Next(0, 11);

            while (guessCount < GuessesAllowed)
            {
                guessCount += 1;
                userGuess = ReadGuess();

                if (userGuess != targetNumber)
                {
                    return "Your guess was incorrect. Try again.";
                }
                else if (userGuess == targetNumber)
                {
                    break;
                }
            }

            if (guessCount < GuessesAllowed)
            {
                return $"CONGRATS! You guessed the secret number '{targetNumber}' in {guessCount} attempts.";
            }
            else
            {
                return $"Hard luck, the number you were after was {targetNumber}.";
            }
        }

        static string PlayHardLevel(int userGuess)
        {
            constMaxGuessValue = 20;
            int guessCount = 0;
            int targetNumber = rand.Next(0, 20);

            while (guessCount < GuessesAllowed)
            {
                guessCount += 1;
                userGuess = ReadGuess();

                if (userGuess != targetNumber)
                {
                    return "Your guess was incorrect. Try again.";
                }
                else if (userGuess == targetNumber)
                {
                    break;
                }
            }

            if (guessCount < GuessesAllowed)
            {
                return $"CONGRATS! You guessed the secret number '{targetNumber}' in {guessCount} attempts.";
            }
            else
            {
                return $"Hard luck, the number you were after was {targetNumber}.";
            }
        }

        static int ReadGuess()
        {
            int userGuess;
            while (!int.TryParse(Console.ReadLine(), out userGuess)
                || userGuess < MinGuessValue
                || userGuess > MaxGuessValue)
            {
                Console.WriteLine($"ERROR! Please enter a number between {MinGuessValue} and {MaxGuessValue}.");
            }
            return userGuess;
        }

        static bool ContinueGame()
        {
            Console.WriteLine("\nDo you want to play again?");
            string response = Console.ReadLine();
            return response == "y" || response == "Y";
        }

        static void EasyLevel()
        {
            RandomNumberGame gameEasy = new RandomNumberGame();
            int[] guesses = new int[3];
            int[] score = new int[3];
            
        }
    }
}
