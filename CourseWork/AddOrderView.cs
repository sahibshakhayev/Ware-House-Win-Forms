using CourseWork.Model;
using CourseWork.View;
using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class AddOrderView : MetroSetForm, IAddOrderView
    {
        public AddOrderView(BindingList<Client> clients, BindingList<Product> products)
        {
            InitializeComponent();
            AddOrderSelectClient.DataSource = clients.Select(cl => $"{cl.Name} {cl.Surname} {cl.Address}").ToArray();
            AddOrderProductSelect.DataSource = products.Select(pd => $"{pd.Name} {pd.Price} {pd.Description}").ToArray();
        }

        public event EventHandler OrderAddEvent;

        public string[] getOrderData()
        {
            return new String[4] {AddOrderSelectClient.SelectedIndex.ToString(),AddOrderProductSelect.SelectedIndex.ToString(),AddOrderQuantity.Value.ToString(), AddOrderArriveTime.Value.ToString()};
        }

        private void AddOrderBt_Click(object sender, EventArgs e)
        {
            OrderAddEvent?.Invoke(sender, e);
        }
    }
}
