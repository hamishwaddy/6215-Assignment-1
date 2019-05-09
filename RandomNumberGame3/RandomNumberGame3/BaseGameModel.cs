using RandomNumberGame3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGame3
{
    public class BaseGameModel : IGameModel
    {
        public int SecretNumber { get; set; }
        public int MaxNumber { get; set; }
        public string DifficultyLevel { get; set; }
        public int MaxGuesses { get; set; }
        public int CurrentGuessCount { get; set; }
        

        // DOES THIS CLASS NEED A CONSTRUCTOR???

        // Sequence for 'playing' the game should be here??? And pass the 'playing sequence' method the game level so it knows 'max number' & name of 'difficulty level'

        /*
        public string ExplainRules(string DifficultyLevel, int SecretNumber, int MaxNumber)
        {
            return $"You have chosen to play '{difficultyLevel}' level. \nYou are allowed up to {maxGuesses} guesses to try and pick the secret number between 1 and {maxNumber}";
        }
        */



    }
}
