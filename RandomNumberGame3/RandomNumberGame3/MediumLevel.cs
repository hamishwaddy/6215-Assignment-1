using System;
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


        // Constructor
        public MediumLevel()
        {
            SecretNumber = SetSecretNumberMediumLevel();
        }

        // METHODS
        public int SetSecretNumberMediumLevel()
        {
            int secretNum = rnd.Next(1, MaxNumber);
            return secretNum;
        }
    }
}
