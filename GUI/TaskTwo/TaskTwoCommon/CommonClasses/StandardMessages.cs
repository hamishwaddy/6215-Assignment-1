using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTwoCommon
{
    public class StandardMessages
    {
        public string StartApp = "Welcome to the Phonebook app.";

        public string EndApp = "Thanks for using the Phonebook app.";

        public static void StandardUserViewTitle()
        {
            Console.WriteLine("****************************************");
            Console.WriteLine("***** Standard User Phonebook View *****");
            Console.WriteLine("****************************************\n\n");
        }

        public static void SupervisorViewTitle()
        {
            Console.WriteLine("***************************************");
            Console.WriteLine("****** Supervisor Phonebook View ******");
            Console.WriteLine("***************************************\n\n");
        }

    }
}
