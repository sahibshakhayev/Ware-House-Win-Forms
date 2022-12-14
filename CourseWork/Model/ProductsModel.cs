using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Model
{

    internal class ProductsModel : IProductsModel
    {
        BindingList<Product> _products;


        public ProductsModel()
        {
            try
            {
                string json = File.ReadAllText("..\\..\\..\\Model\\DatabaseFiles\\Products.json");
                var List = JsonConvert.DeserializeObject<BindingList<Product>>(json);
                _products = List;

            }

            catch
            {
                _products = new BindingList<Product>();
            }
        }
        public void AddProduct(Product product)
        {
            _products.Add(product);
            File.WriteAllText("..\\..\\..\\Model\\DatabaseFiles\\Products.json", JsonConvert.SerializeObject(_products));
        }

        public BindingList<Product> GetProducts()
        {
            return _products;
        }
    }
}
