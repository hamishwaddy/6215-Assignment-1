using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGame3
{
    public class EasyLevel : IGameModel
    {
        Random rnd = new Random();
        // PROPERTIES
        public int MaxGuesses { get; set; } = 3;
        public int MaxNumber { get; set; } = 5;
        public string DifficultyLevel { get; set; } = "EASY";
        public int SecretNumber { get; set; }
        public int CurrentGuessCount { get; set; } = 0;
        public int Score { get; set; } = 0;
        public string UN { get; set; }=""; 
        public int CurrentGuess { get; set; }// Will be passed to CalculateScore();
        public bool LevelComplete { get; set; } = false;
        public List<int> Guesses { get; set; } = new List<int>();
        public bool GameOver { get; set; } = false;


        // Constructor
        public EasyLevel()
        {
            SecretNumber = SetSecretNumber();
        }

        // METHODS
        public int SetSecretNumber()
        {
            int secretNum = rnd.Next(1, MaxNumber);
            return secretNum;
        }


        public void CalculateScore()
        {
            Guesses.Add(CurrentGuess);
            //Guesses.Add($"{CurrentGuess} @ {DifficultyLevel}");

            CurrentGuessCount += 1;
            if (CurrentGuess == SecretNumber && CurrentGuessCount == 1)
            {
                Score += 10;
                LevelComplete = true;
            }
            else if (CurrentGuess == SecretNumber && CurrentGuessCount == 2)
            {
                Score += 6;
                LevelComplete = true;
            }
            else if (CurrentGuess == SecretNumber && CurrentGuessCount == 3)
            {
                Score += 2;
                LevelComplete = true;
            }
            else
                GameOver = true;


            //if ( Score >0 || GameOver == true)
            EnterUsername();
        }

        public void EnterUsername()
        {
            char[] constrained = new char[5];
            char[] og = UN.ToCharArray();
            if(UN.Length > 5)
            {
                for (int i = 0; i < 5; i++)
                    constrained[i] = og[i];
            }
            else
            {
                for (int i = 0; i < UN.Length; i++)
                    constrained[i] = og[i];
            }
            string result = "";
            foreach (char x in constrained)
                result += x;
            UN = result;
            //concantinate the string back together and use it to set UN
        }
    }
}