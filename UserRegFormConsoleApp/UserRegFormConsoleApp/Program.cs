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
            List<Person> people = new List<Person>();

            bool addAnotherUser = true;

            do
            {
                StandardMessages.WelcomeMessage();
                Person user = new Person();
                do
                {
                    Console.Write("Please enter your first name: ");
                    user.FirstName = Console.ReadLine();
                    Console.WriteLine(HelperMethods.ValidateUserName(user.FirstName));
                } while (user.FirstName.Length==0);
                do
                {
                    Console.Write("Please enter your last name: ");
                    user.LastName = Console.ReadLine();
                    Console.WriteLine(HelperMethods.ValidateUserName(user.LastName));
                } while (user.LastName.Length == 0);
                do
                {
                    Console.Write("Please enter your email: ");
                    user.Email = Console.ReadLine();
                    Console.WriteLine(HelperMethods.ValidateUserName(user.Email));
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

                //DISPLAY MOST RECENTLY REGISTERED USERS DATA
                Console.Clear();
                StandardMessages.WelcomeMessage();
                Console.WriteLine("\nUSER DATA");
                Console.WriteLine(user.DisplayRegistrationData());

                //LIST ALL USERS
                Console.WriteLine("\nLIST OF ALL USERS");
                Console.WriteLine(user.ListAllUsers(people));

                Console.WriteLine("Would you like to add another user? (y/n)");
                string answer = Console.ReadLine();

                if(answer == "y")
                {
                    addAnotherUser = true;
                } else
                {
                    addAnotherUser = false;
                }

                Console.Clear();
            } while (addAnotherUser);

            StandardMessages.ExitApp();
        }
    }
}
