using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Model
{
    public class Client
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public Client(string name, string surname, string email, string phone, string adress)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Phone = phone;
            Address = adress;
            
            
        }




    }
}
