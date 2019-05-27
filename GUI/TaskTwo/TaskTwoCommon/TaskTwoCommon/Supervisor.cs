using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTwoCommon
{
    public class Supervisor : ISupervisor
    {
        public string name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public Address address { get; set; }

        public Supervisor(Phonebook phonebook)
        {
            name = phonebook.name;
            phone = phonebook.phone;
            email = phonebook.email;
            address = phonebook.address;
        }

        public string Display()
        {
            return $"Name:\t{name}\nPhone:\t{phone}\nEmail:\t{email}\nADDRESS\nStreet:\t{address.street}\nCity:\t{address.city}\n\n";
        }
    }
}
