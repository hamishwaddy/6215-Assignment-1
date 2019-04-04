using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web.ClientServices;
using System.Web.Script.Serialization;
using PhoneBookConsoleApp.Applicants;

namespace PhoneBookConsoleApp
{
    public class PersonModel : IApplicantModel
    {
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public IAccounts AccountProcessor { get; set; } = new Accounts();


        public static void GetNames() //SHOULD THIS BE SOMEWHERE DIFFERENT TO HERE?
        {
            string json = new WebClient().DownloadString("https://jsonplaceholder.typicode.com/users?_limit=5");

            List<PersonModel> users = new JavaScriptSerializer().Deserialize<List<PersonModel>>(json);

            foreach (PersonModel x in users)
            {
                Console.WriteLine("Name: {0}\nPhone Number: {1}\nADDRESS:\nStreet: {2}\nCity: {3}\n",x.name,x.phone,x.address.street,x.address.city);
            }

        }
    }

    
}
