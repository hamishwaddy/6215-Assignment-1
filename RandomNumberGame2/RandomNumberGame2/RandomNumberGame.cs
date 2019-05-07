using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGame2
{
    public class RandomNumberGame
    {
        public string PlayerName { get; set; }
        public int[] Guesses { get; set; }
        public int Points { get; set; }
        public string Level { get; set; }
        public int TargetNumber { get; set; }

        Random rnd = new Random();

        int getTargetNumberEasy()
        {
            int targetNum = rnd.Next(1, 5);
            return targetNum;
        }

    }
}
