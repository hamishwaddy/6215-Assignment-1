using System;

namespace TaskThreeCommon
{
    public class Program
    {
        static IGameModel EasyGame = new EasyLevel();
        static IGameModel MediumGame = new MediumLevel();
        static IGameModel HardGame = new HardLevel();
        static void Main(string[] args)
        {

            // Select Level
            // Make guesses
            // If correct, score points
            // Display results to player (points scored, level points scored on, enter username)

            Console.WriteLine(StandardMessages.StartApp());
            Console.WriteLine("\n\nSelect your game level\n\t1 - Easy\n\t2 - Medium\n\t3 - Hard\n\t4 - Exit");
            int input = int.Parse(Console.ReadLine());

            /*Easy*/
            if (input == 1)
            {
                do
                {
                    /*Display the easy level and take the input*/
                    StandardMessages.DisplayGame(EasyGame.SecretNumber, EasyGame.DifficultyLevel, EasyGame.MaxNumber, EasyGame.MaxGuesses, EasyGame.CurrentGuessCount);
                    EasyGame.CurrentGuess = int.Parse(Console.ReadLine());

                    /*Play the Game*/
                    EasyGame.CalculateScore(EasyGame.CurrentGuess);

                    /*Move to the next level if completed*/
                    if (EasyGame.LevelComplete)
                        StandardMessages.YouWon();
                        input++;
                } while (EasyGame.LevelComplete == false && EasyGame.GameOver == false);

                if (EasyGame.GameOver && EasyGame.Score > 0)
                    EasyGame.EnterUsername(StandardMessages.GetName(EasyGame.Score));

                Console.WriteLine($"Thank you for playing {EasyGame.UN}\nPress ENTER to continue...");
            }

            /*Medium*/
            if (input == 2)
            {
                do
                {
                    /*Carry over the score from previous level*/
                    MediumGame.Score = EasyGame.Score;
                    StandardMessages.DisplayGame(MediumGame.SecretNumber, MediumGame.DifficultyLevel, MediumGame.MaxNumber, MediumGame.MaxGuesses, MediumGame.CurrentGuessCount);
                    MediumGame.CurrentGuess = int.Parse(Console.ReadLine());

                    MediumGame.CalculateScore(MediumGame.CurrentGuess);

                    if (MediumGame.LevelComplete)
                        input++;
                } while (MediumGame.LevelComplete == false && MediumGame.GameOver == false);

                if (MediumGame.GameOver && MediumGame.Score > 0)
                    MediumGame.EnterUsername(StandardMessages.GetName(MediumGame.Score));

                Console.WriteLine($"Thank you for playing {MediumGame.UN}\nPress ENTER to continue...");
            }

            /*Hard*/
            if (input == 3)
            {
                do
                {
                    /*Carry over the score from previous level*/
                    HardGame.Score = MediumGame.Score;
                    StandardMessages.DisplayGame(HardGame.SecretNumber, HardGame.DifficultyLevel, HardGame.MaxNumber, HardGame.MaxGuesses, HardGame.CurrentGuessCount);
                    HardGame.CurrentGuess = int.Parse(Console.ReadLine());

                    HardGame.CalculateScore(HardGame.CurrentGuess);

                    if (HardGame.LevelComplete)
                        input++;
                } while (HardGame.LevelComplete == false && HardGame.GameOver == false);

                if (HardGame.GameOver && HardGame.Score > 0)
                    HardGame.EnterUsername(StandardMessages.GetName(HardGame.Score));

                Console.WriteLine($"Thank you for playing {HardGame.UN}\nPress ENTER to continue...");
            }

            /* Exit App*/
            if (input == 4)
            {
                Console.Clear();
                Console.WriteLine("Thanks for playing. Press any key to exit.");
            }


            Console.ReadLine();
        }
        
    }
}
