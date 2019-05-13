﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGame3
{
    public class MediumLevel : IGameModel
    {
        Random rnd = new Random();
        // PROPERTIES
        public int MaxGuesses { get; set; } = 3;
        public int MaxNumber { get; set; } = 10;
        public string DifficultyLevel { get; set; } = "MEDIUM";
        public int SecretNumber { get; set; }
        public int CurrentGuessCount { get; set; } = 0;
        public int Score { get; set; } = 0;
        public string UN { get; set; } = "";
        public int CurrentGuess { get; set; }// Will be passed to CalculateScore();
        public bool LevelComplete { get; set; } = false;
        public List<int> Guesses { get; set; } = new List<int>();
        public bool GameOver { get; set; } = false;


        // Constructor
        public MediumLevel()
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
            int score = 0;
            CurrentGuessCount += 1;
            if (CurrentGuess == SecretNumber && CurrentGuessCount == 1)
            {
                score += 10;
                LevelComplete = true;
            }
            else if (CurrentGuess == SecretNumber && CurrentGuessCount == 2)
            {
                score += 6;
                LevelComplete = true;
            }
            else if (CurrentGuess == SecretNumber && CurrentGuessCount == 3)
            {
                score += 2;
                LevelComplete = true;
            }
            else
                GameOver = true;




            Score = score;

            if (Score > 0 )
                EnterUsername();
        }
        public string EnterUsername()
        {
            int trimLength = 5;
            if (UN.Length > trimLength)
                UN = UN.Remove(trimLength);
            return UN;
        }
    }
}
