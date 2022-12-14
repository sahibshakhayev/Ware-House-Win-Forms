using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Model
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public User(string username, string password, string name, string surname)
        {
            Username = username;
            Password = password;
            Name = name;
            Surname = surname;
        }

        public string getUsernameForCheck()
        {
           return Username.ToLower();
        }
    }
}
