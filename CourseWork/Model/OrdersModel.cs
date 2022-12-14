using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Model
{
    internal class OrdersModel : IOrdersModel
    {
        Dictionary<string, BindingList<Order>> _orders;

        public OrdersModel()
        {
            try
            {
                string dic_json = File.ReadAllText("..\\..\\..\\Model\\DatabaseFiles\\Orders.json");
                var Dic = JsonConvert.DeserializeObject<Dictionary<string, BindingList<Order>>>(dic_json);
                _orders = Dic;

            }

            catch
            {
                _orders = new Dictionary<string, BindingList<Order>>();
            }
        }



        public void AddOrder(Order order, string user)
        {
            if (_orders.ContainsKey(user))
            {
                BindingList<Order> orders = _orders[user];

                orders.Add(order);

                _orders[user] = orders;




            }

            else
            {
                BindingList<Order> orders = new BindingList<Order>();
                orders.Add(order);
                _orders.Add(user, orders);

            }

            File.WriteAllText("..\\..\\..\\Model\\DatabaseFiles\\Orders.json", JsonConvert.SerializeObject(_orders));
        }

        public BindingList<Order> GetOrders(string user)
        {
            if (_orders.ContainsKey(user)) { return _orders[user]; } else { _orders.Add(user, new BindingList<Order>()); return _orders[user]; };

        }

    }
}
