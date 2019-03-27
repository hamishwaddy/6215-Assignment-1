using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegFormConsoleApp
{
    public class HelperMethods
    {

        public static string ValidMessage(string m)
        {
            if (m.Length > 0)
            {
                //return "Valid input";
                return string.Empty;
            }
            else if (m.Length == 0)
            {
                return "Invalid input, please re-enter information";
            }

            return String.Empty;
        }
    }
}
