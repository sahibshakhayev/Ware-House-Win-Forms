using CourseWork.Model;
using CourseWork.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Presenter
{
    internal class AddOrderPresenter :IAddPresenter
    {
        private IOrdersModel ordersModel;
        private IProductsModel productsModel;
        private IClientsModel clientsModel;
        private IAddOrderView addOrderView;
        string User { get; }

        public AddOrderPresenter(IOrdersModel ordersModel,IClientsModel clients, IProductsModel products, IAddOrderView addOrderView, string user)
        {
            this.ordersModel = ordersModel;
            this.addOrderView = addOrderView;
            this.addOrderView.OrderAddEvent += AddOrder;
            this.clientsModel = clients;
            this.productsModel = products;
            User = user;
        }

        public bool checkFieldsFilled()
        {
            foreach (var item in addOrderView.getOrderData())
            {
                if (item.Trim(' ') == String.Empty)
                {
                    return false;
                }


            }
            return true;
        }

        public bool checkInputs() {
            

            if (int.Parse(addOrderView.getOrderData()[0]) == -1 || int.Parse(addOrderView.getOrderData()[1]) == -1 || int.Parse(addOrderView.getOrderData()[2]) == 0)
            {
                return false;
            }
            
            
            return true; 
        }

        private void AddOrder(object? sender, EventArgs e)
        {

           



            

            if (checkFieldsFilled() && checkInputs())
            {
                
                ordersModel.AddOrder(new Order(clientsModel.GetClients(User)[int.Parse(addOrderView.getOrderData()[0])].Name, 
                    productsModel.GetProducts()[int.Parse(addOrderView.getOrderData()[1])].Name, int.Parse(addOrderView.getOrderData()[2]), DateTime.Parse(addOrderView.getOrderData()[3])), User);
                MessageBox.Show("Add Successfull!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

               
            }

            else if (!checkInputs())
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
