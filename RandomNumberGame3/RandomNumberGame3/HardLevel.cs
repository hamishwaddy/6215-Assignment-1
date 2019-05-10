using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGame3
{
    public class HardLevel : IGameModel
    {
        Random rnd = new Random();
        // PROPERTIES
        public int MaxGuesses { get; set; } = 3;
        public int MaxNumber { get; set; } = 20;
        public string DifficultyLevel { get; set; } = "HARD";
        public int SecretNumber { get; set; }
        public int CurrentGuessCount { get; set; } = 0;


        // Constructor
        public HardLevel()
        {
            SecretNumber = SetSecretNumberHardLevel();
        }

        // METHODS
        public int SetSecretNumberHardLevel()
        {
            int secretNum = rnd.Next(1, MaxNumber);
            return secretNum;
        }
    }
}
