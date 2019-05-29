using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook2
{
    public class StandardUser : IStandardUser
    {
        public string name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }

        public StandardUser(Phonebook phonebook)
        {
            name = phonebook.name;
            phone = phonebook.phone;
            email = phonebook.email;
        }

        public string Display()
        {
            return $"Name:\t{name}\nPhone:\t{phone}\nEmail:\t{email}\n\n";
        }
    }
}
