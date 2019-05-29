using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook2
{
    interface IStandardUser
    {
        string name { get; set; }
        string phone { get; set; }
        string email { get; set; }

        string Display();
    }
}
