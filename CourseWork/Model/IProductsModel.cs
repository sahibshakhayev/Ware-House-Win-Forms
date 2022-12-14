using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Model
{
    internal interface IProductsModel
    {
        BindingList<Product> GetProducts();

        public void AddProduct(Product product);
    }
}
