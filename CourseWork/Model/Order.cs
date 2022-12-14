using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Model
{
    public class Order
    {
        
        public string Name { get; set; }

        public string Product { get; set; }

        public int Quantity { get; set; }

        public DateTime Arrieve_Date { get; set; }
        
         public Order(string name, string product,  int quantity, DateTime arrievedate ) { 
         Name = name;
         Product = product;
         Quantity = quantity;
         Arrieve_Date = arrievedate;
          
        }
    }
}
