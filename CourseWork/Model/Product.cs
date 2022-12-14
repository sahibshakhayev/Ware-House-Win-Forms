using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Model
{
    public class Product
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }
        public string Description { get; set; }
        public Product(string name, double price, int quantity, string description)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Description = description;

        }
        public string getNameForCheck()
        {

            return Name.ToLower();
        }


    }
}
