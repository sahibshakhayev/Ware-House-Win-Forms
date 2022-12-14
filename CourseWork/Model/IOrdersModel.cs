using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Model
{
    internal interface IOrdersModel
    {
        BindingList<Order> GetOrders(string user);

        public void AddOrder(Order order, string user);
    }
}
