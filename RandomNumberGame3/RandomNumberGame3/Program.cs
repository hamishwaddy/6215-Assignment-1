using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGame3
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Select Level
            // Make guesses
            // If correct, score points
            // Display results to player (points scored, level points scored on, enter username)

            Console.WriteLine(StandardMessages.StartApp());
            bool keepGoing = true;
            do
            {
                Console.WriteLine("\n\nSelect your game level\n\t1 - Easy\n\t2 - Medium\n\t3 - Hard\n\t4 - Exit");
                string input = Console.ReadLine();
                if (input == "1")
                {
                    IGameModel newGame = new IGameModel; // AM TRYING TO CREATE NEW INSTANCE OF 'EASYLEVEL' GAME
                    
                }
                else if (input == "2")
                {
                   
                }
                else if (input == "3")
                {
                }
                else if (input == "4")
                {
                    keepGoing = false;
                }
                else
                    keepGoing = true;
                    
            } while (keepGoing == true);



            Console.ReadLine();
        }
    }
}
