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
        public int MaxGuesses { get; set; }
        public int MaxNumber { get; set; }
        public string DifficultyLevel { get; set; }
        public int SecretNumber { get; set; }
        public int CurrentGuessCount { get; set; }

        // ATTRIBUTES
        private int maxGuesses = 3;
        private int maxNumber = 5;
        private string difficultyLevel = "EASY";

        public EasyLevel()
        {
            MaxGuesses = maxGuesses;
            MaxNumber = maxNumber;
            DifficultyLevel = difficultyLevel;
        }
        

        // METHODS
        public int SetSecretNumberEasyLevel(int maxNumber)
        {
            int secretNum = rnd.Next(1, maxNumber);
            return secretNum;
        }

        
    }
}