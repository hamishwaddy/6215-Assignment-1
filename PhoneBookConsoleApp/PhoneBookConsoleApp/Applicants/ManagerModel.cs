using PhoneBookConsoleApp.Applicants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookConsoleApp
{
    public class ManagerModel : IApplicantModel
    {
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public AddressModel street { get; set; }
        public AddressModel city { get; set; }
        public IAccounts AccountProcessor { get; set; } = new Accounts();

    }
}
