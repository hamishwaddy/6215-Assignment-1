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
                        Console.Clear();
                        StandardMessages.StandardUserViewTitle();
                        foreach (Phonebook phonebook in users)
                        {
                            IStandardUser user = new StandardUser(phonebook);
                            Console.WriteLine(user.Display());
                        }
                        //Console.WriteLine("Press any key to return to the main menu.");
                        break;

                    case "2":
                        Console.Clear();
                        StandardMessages.SupervisorViewTitle();
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
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}
