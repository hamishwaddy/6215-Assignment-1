using RandomNumberGame3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook3
{
    public class BaseGameModel : IEasyLevel, IMediumLevel, IHardLevel
    {
        Random rnd = new Random();

        public int SecretNumber { get; set; }
        public int MaxNumber { get; set; }
        public string DifficultyLevel { get; set; } // DOES THIS NEED TO BE OWN CLASS? (with easy, med, hard)

        private int maxGuesses = 3;

        public int SetSecretNumberEasyLevel()
        {
            int secretNum = rnd.Next(1, 6);
            return secretNum;
        }
        public int SetSecretNumberMediumLevel()
        {
            int secretNum = rnd.Next(1, 11);
            return secretNum;
        }
        public int SetSecretNumberHardLevel()
        {
            int secretNum = rnd.Next(1, 21);
            return secretNum;
        }
        public string DisplayDifficultyLevel()
        {
            return ""; // HOW DO I SET EASY, MED, HARD LEVEL? DOES DIFFICULTY LEVEL NEED TO BE ITS OWN CLASS?
        }
        
    }
}
