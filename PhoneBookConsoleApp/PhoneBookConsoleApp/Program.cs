using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StandardMessages.AppStart();

            Person.GetNames();

            StandardMessages.ExitApp();
        }
    }
}
