using CourseWork.Model;
using CourseWork.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Presenter
{
    internal class AddProductPresenter:IAddPresenter
    {
        private IProductsModel productsModel;
        private IAddProductView addProductView;
        

        public AddProductPresenter(IProductsModel productsModel, IAddProductView addProductView)
        {
            this.productsModel = productsModel;
            this.addProductView = addProductView;
            this.addProductView.ProductAddEvent += AddProduct;
            
        }

        public bool checkFieldsFilled()
        {
            foreach (var item in addProductView.getProductData())
            {
                if (item.Trim(' ') == String.Empty)
                {
                    return false;
                }


            }
            return true;
        }

        

        private void AddProduct(object? sender, EventArgs e) {
            
            bool error = false;
            bool exist = false;
            string exist_product = null;
            double Price;
            int Quantity;

            bool result = double.TryParse(addProductView.getProductData()[1], out Price);

            result = int.TryParse(addProductView.getProductData()[2], out Quantity);

            foreach (var product in productsModel.GetProducts())
                {
                    if (addProductView.getProductData()[0] == product.Name && addProductView.getProductData()[1] == product.Price.ToString() &&
                    addProductView.getProductData()[2] == product.Quantity.ToString() && addProductView.getProductData()[3] == product.Description)
                    {

                        MessageBox.Show("Product already exist!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        error = true;
                        break;
                    }

                    else if (product.getNameForCheck() == addProductView.getProductData()[0].ToLower())
                   {
                    exist = true;
                    exist_product = product.getNameForCheck();
                   

                   }
                }

                if (!error && checkFieldsFilled() && !exist && result && Price != 0 && Quantity != 0)

                {
                


                    productsModel.AddProduct(new Product(addProductView.getProductData()[0], Price, Quantity,
                        addProductView.getProductData()[3]));
                    MessageBox.Show("Add Successfull!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
   
                    addProductView.Close();
                }

            else if (!error && checkFieldsFilled() && exist && result && Price != 0 && Quantity !=0)
            {
                for (int i = 0; i < productsModel.GetProducts().Count; i++)
                {
                    if (productsModel.GetProducts()[i].getNameForCheck() == exist_product)
                    {
                        Product product = new Product(productsModel.GetProducts()[i].Name, Price, productsModel.GetProducts()[i].Quantity + Quantity, addProductView.getProductData()[3]);
                        productsModel.GetProducts()[i] = product;
                        


                        
                       

                    }
                }
            }

            else if (!result || Quantity == 0 || Price == 0)
            {

                MessageBox.Show("Error in input!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!checkFieldsFilled())
            {
                MessageBox.Show("Please Fill All Fields!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        
        
        }


    }
}
