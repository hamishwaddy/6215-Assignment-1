using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web.ClientServices;
using System.Web.Script.Serialization;

namespace PhoneBookConsoleApp
{
    public class Person
    {
        public int id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public Address address { get; set; }
        public Geo geo { get; set; }
        public string phone { get; set; }
        public string website { get; set; }
        public Company company { get; set; }

        public static void GetNames()
        {
            string json = new WebClient().DownloadString("https://jsonplaceholder.typicode.com/users?_limit=5");

            List<Person> users = new JavaScriptSerializer().Deserialize<List<Person>>(json);

            foreach (Person x in users)
            {
                Console.WriteLine("Name: {0}\nPhone Number: {1}\nADDRESS:\nStreet: {2}\nCity: {3}\n",x.name,x.phone,x.address.street,x.address.city);
            }

        }
    }

    public class Address
    {
        public string street { get; set; }
        public string suite { get; set; }
        public string city { get; set; }
        public string zipcode { get; set; }
    }

    public class Geo
    {
        public string lat { get; set; }
        public string lng { get; set; }
    }

    public class Company
    {
        public string name { get; set; }
        public string catchPhrase { get; set; }
        public string bs { get; set; }
    }

    
}
