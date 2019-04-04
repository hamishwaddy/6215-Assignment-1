using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookConsoleApp
{
    class EmployeeModel
    {
        public string name { get; set; }
        public string email { get; set; }
        public AddressModel address { get; set; }
        public string phone { get; set; }
        public bool IsManager { get; set; } = false;
    }
}
