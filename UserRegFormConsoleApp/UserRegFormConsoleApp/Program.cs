using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegFormConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StandardMessages.WelcomeMessage();

            List<Person> people = new List<Person>();

            Person user = new Person();
            do
            {
                Console.Write("Please enter your first name: ");
                user.FirstName = Console.ReadLine();
                Console.WriteLine(HelperMethods.ValidMessage(user.FirstName));
            } while (user.FirstName.Length == 0);

            do
            {
                Console.Write("Please enter your last name: ");
                user.LastName = Console.ReadLine();
                Console.WriteLine(HelperMethods.ValidMessage(user.LastName));
            } while (user.LastName.Length == 0);

            do
            {
                Console.Write("Please enter your email address: ");
                user.Email = Console.ReadLine(); //HOW DO I VALIDATE AN EMAIL ADDRESS???
                Console.WriteLine(HelperMethods.ValidMessage(user.Email));
            } while (user.Email.Length == 0);

            //AUTOMATICALLY GENERATE USERNAME
            user.Username =  user.GenerateUserName();
            Console.WriteLine(user.Username);


            //ALLOW USER TO SET PASSWORD
            Console.WriteLine("\n... Set your password ...");

            string password1, password2;

            do
            {
                Console.Write("Enter your password: ");
                password1 = Console.ReadLine();
                Console.Write("Confirm your password: ");
                password2 = Console.ReadLine();
                if (password1 != password2)
                {
                    Console.WriteLine("\nYour passwords didn't match. Please try again.");
                }
            } while (password1 != password2);

            Console.WriteLine("... SUCCESS! Password saved ...\n");
            people.Add(user);

            foreach (Person x in people)
                x.ListAllUsers();

            StandardMessages.ExitApp();
        }
    }
}
