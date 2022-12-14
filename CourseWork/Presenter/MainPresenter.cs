using CourseWork.Model;
using CourseWork.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Presenter
{
    internal class MainPresenter
    {
        private IUsersModel usersModel;
        private IMainView mainView;
        private IClientsModel clientsModel;
        private IProductsModel productsModel;
        private IOrdersModel ordersModel;
        
        public string User { get; set; }


        public MainPresenter(IUsersModel usersModel, IMainView mainView, IClientsModel clientsModel, IProductsModel productsModel, IOrdersModel ordersModel)
        {
            this.usersModel = usersModel;
            this.mainView = mainView;
            this.mainView.LoginEvent += Login;
            this.mainView.SignUpEvent += SignUp;
            this.mainView.AddClientEvent += AddClient;
            this.mainView.AddProductEvent += AddProduct;
            this.mainView.ListClientEvent += ListClient;
            this.mainView.ListProductEvent += ListProducts;
            this.mainView.ListOrderEvent += ListOrders;
            this.mainView.AddOrderEvent += AddOrder;
            this.mainView.FilterEvent += FilterOrders;
            this.mainView.LogoutEvent += LogOut;

            this.clientsModel = clientsModel;
            this.productsModel = productsModel;
            this.ordersModel = ordersModel;
        }

        private void Login(object? sender, EventArgs e)
        {
            if (usersModel.GetUsers().Count == 0)
            {
                MessageBox.Show("No user in database! Create user first!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

             else if (mainView.getLoginData()[0].Trim(' ') != String.Empty && mainView.getLoginData()[1] != String.Empty)
            {
                string username = mainView.getLoginData()[0];
                string password = mainView.getLoginData()[1];

                bool check_user()
                {
                    foreach (User user in usersModel.GetUsers())
                    {
                        if (user.Username == username && user.Password == password)
                        {
                            return true;

                        }
                    }
                        return false;

                }


                if (check_user())
                {


                    User = username;
                    mainView.ShowClients(clientsModel.GetClients(username));
                }

                else
                {
                    MessageBox.Show("Incorrect Username or Password", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }


            else
            {
                MessageBox.Show("Enter Data", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void SignUp(object? sender, EventArgs e)
        {
            var signUpView = new SignUpView();
            var signUpPresenter = new SignUpPresenter(usersModel, signUpView);

            signUpView.ShowDialog();

        }
        private void ListClient(object? sender, EventArgs e)
        {

            mainView.ShowClients(clientsModel.GetClients(User));
            

        }
        private void AddClient(object? sender, EventArgs e)
        {
            var addClientView = new AddClientView();
            var addClientPresenter = new AddClientPresenter(clientsModel, addClientView, User);

            addClientView.ShowDialog();
            

        }

        private void ListProducts(object? sender, EventArgs e)
        {
            mainView.ShowProducts(productsModel.GetProducts());

        }

        private void ListOrders(object? sender, EventArgs e)
        {
            mainView.ShowOrders(ordersModel.GetOrders(User));

        }
        private void AddOrder(object? sender, EventArgs e)
        {

            var addOrderView = new AddOrderView(clientsModel.GetClients(User), productsModel.GetProducts());
            var addOrderPresenter = new AddOrderPresenter(ordersModel, clientsModel, productsModel, addOrderView, User);
            addOrderView.ShowDialog();

            
        }

        private void AddProduct(object? sender, EventArgs e)
        {
            var addProductView = new AddProductView();
            var addProductPresenter = new AddProductPresenter(productsModel, addProductView);

            addProductView.ShowDialog();

            
            

        }


        private void FilterOrders(object? sender, EventArgs e)
        {

            var textBox = sender as MetroSet_UI.Controls.MetroSetTextBox;

             var FilterResult = from order in ordersModel.GetOrders(User)  where order.Name.ToLower().Contains(textBox.Text.ToLower()) || (order.Product.ToLower().Contains(textBox.Text.ToLower())) select order;
           
            mainView.ShowOrders(new BindingList<Order>(FilterResult.ToList()));
               

        }

        private void LogOut(object? sender, EventArgs e)
        {

            mainView.LogOut();
        }

    }
}
