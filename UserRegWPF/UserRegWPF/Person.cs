using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegFormConsoleApp
{
    public class Person : IPerson, IEmail, IPassword, IUsername, IRole
    {
        //PERSON VARIABLES
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public bool IsAdmin { get; set; } = false;
        public bool IsUser { get; set; } = true;
        //public List<Person> AllUsers { get; set; }


        //PERSON METHODS
        public string GenerateUserName()  //AUTOMATICALLY CREATE A USERNAME
        {
            return $"Your username is: { FirstName.Substring(0, 1).ToLower() }.{ LastName.ToLower() }";
        }
        

        public string DisplayRegistrationData()
        {
            
            string output = $"{FirstName} {LastName}\n{Email}\n{Username}\nAdmin: {IsAdmin}\tUser: {IsUser}";
            return output;
        }
        

        public string ListAllUsers(List<Person> people)
        {
            string output = "";
            foreach (Person item in people)
            {
                output +=  $"Name: {item.FirstName} {item.LastName}\n";
            }
                return output;
        }

    }

    
}
