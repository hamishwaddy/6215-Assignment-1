using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook2
{
    class Program
    {
        static void Main(string[] args)
        {
            Login currentUser = new Login();

            Console.Write("Please enter your username: ");
            currentUser.userName= Console.ReadLine();
            Console.Write("Please enter your password: ");
            currentUser.password = Console.ReadLine();

            
            while(!currentUser.UserAuthentication(currentUser.userName, currentUser.password))
            {
                Console.WriteLine("Login details incorrect. Please try again");
                Console.Write("Please enter your password: ");
                currentUser.password = Console.ReadLine();

            }

            Phonebook phonebookList = new Phonebook();
            phonebookList.DisplayPhonebook(currentUser);

            Console.ReadLine();

        }
    }
}
