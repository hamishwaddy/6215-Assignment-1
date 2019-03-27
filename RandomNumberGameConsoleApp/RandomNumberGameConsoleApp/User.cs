using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGameConsoleApp
{
    public class User
    {
        //USER VARIABLES
        public string UserName { get; set; }
        public int Guess1 { get; set; }
        public int Guess2 { get; set; }
        public int Guess3 { get; set; }
        public int NumberOfGuesses { get; set; }

        //USER CONSTRUCTORS
        //public User(string _userName)
        //{
        //    UserName = _userName;
        //}



        //USER METHODS
        public static string SetUserName()
        {
            Console.WriteLine("Enter your player name (max 5 characters): ");
            string userName = Console.ReadLine();
            int trimLength = 5;
            if (userName.Length > trimLength)
            {
                userName = userName.Remove(trimLength);
            }

            Console.WriteLine("\nYour player name is: {0}",userName);
            
            return userName;
        }
    }
}
