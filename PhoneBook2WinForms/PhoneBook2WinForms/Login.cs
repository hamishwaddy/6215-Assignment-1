using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook2
{
    public class Login
    {
        //public string userName { get; set; }
        //public string password { get; set; }
        public static bool isSupervisor { get; set; }

        /*
        public bool UserAuthentication(string user, string password)
        {
            var userList = MockLogin();

            foreach(var item in userList)
            {
                if(item.userName == user && item.password == password)
                {
                    return true;
                }
            }
            return false;
        }
        */
        /*
        public  bool checkSupervisor(string user)
        {
            var userList = MockLogin();

            foreach (var item in userList)
            {
                if (item.userName == user)
                {
                    return item.isSupervisor;
                }
            }
            return false;
        }
        */

        /*
        public static List<Login> MockLogin()
        {
            return  new List<Login>
            {
                new Login() { userName = "sam", password = "123", isSupervisor = true },
                new Login() { userName = "orrie", password = "123", isSupervisor = false },
                //new Login() { userName = "sam", password = "123", isSupervisor = true }
            };
        }
        */
    }


}
