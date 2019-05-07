using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace PhoneBook2
{
    class Program
    {


        static void Main(string[] args)
        {
            List<Phonebook> users = new List<Phonebook>();
            string json = new WebClient().DownloadString("https://jsonplaceholder.typicode.com/users?_limit=5");
            users = new JavaScriptSerializer().Deserialize<List<Phonebook>>(json);


            StandardMessages messages = new StandardMessages();
            Console.WriteLine(messages.StartApp);
            Console.WriteLine();
            Console.WriteLine();

            

            bool keepGoing = true;
            do
            {
                Console.WriteLine("Select your user status\n\t1 - Standard User\n\t2 - Supervisor\n\t3 - Exit");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":

                        foreach (Phonebook phonebook in users)
                        {
                            IStandardUser user = new StandardUser(phonebook);
                            Console.WriteLine(user.Display());
                        }

                        break;

                    case "2":

                        foreach (Phonebook phonebook in users)
                        {
                            ISupervisor user = new Supervisor(phonebook);
                            Console.WriteLine(user.Display());
                        }

                        break;

                    default:
                        keepGoing = false;
                        break;
                }


            } while (keepGoing == true);


            Console.WriteLine(messages.EndApp);




            /*
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
            */
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();

        }


    }
}
