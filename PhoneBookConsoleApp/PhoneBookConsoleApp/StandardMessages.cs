using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookConsoleApp
{
    class StandardMessages
    {
        public static void AppStart()
        {
            Console.WriteLine("*********** Assignment 1 *********");
            Console.WriteLine("************* Task 2 *************");
            Console.WriteLine("********* Phone Book App *********\n\n");
        }

        public static void ExitApp()
        {
            {
                Console.WriteLine("\n\nYou have completed this program.\nPress any key to exit");
                Console.ReadLine();
            }
        }
    }
}
