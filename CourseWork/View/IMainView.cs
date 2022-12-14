using CourseWork.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.View
{
    internal interface IMainView
    {
        public event EventHandler LoginEvent;
        public event EventHandler LogoutEvent;
        public event EventHandler AddOrderEvent;
        public event EventHandler AddProductEvent;
        public event EventHandler AddClientEvent;
        public event EventHandler ListOrderEvent;
        public event EventHandler ListProductEvent;
        public event EventHandler ListClientEvent;
        public event EventHandler SignUpEvent;
        public event EventHandler FilterEvent;

        public void HidePanelsExpect(MetroSet_UI.Controls.MetroSetPanel panelForShow);

        String[] getLoginData();

        public void ShowClients(BindingList<Client> clients);

        public void ShowProducts(BindingList<Product> products);

        public void ShowOrders(BindingList<Order> orders);

        public void LogOut();

    }
}
