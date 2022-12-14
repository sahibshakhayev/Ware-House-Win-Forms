

using MetroSet_UI.Forms;
using CourseWork.Model;
using System.ComponentModel;
using System.Data;
using CourseWork.View;
using MetroSet_UI.Controls;

namespace CourseWork
{
    public partial class MainView : MetroSetForm, IMainView
    {
        
        public MainView()
        {
            InitializeComponent();
            LoginPanel.BorderColor = Color.White;
            metroSetLabel2.ForeColor = Color.FromArgb(102, 102, 102);
            HidePanelsExpect(LoginPanel);
            Menu.Hide();
            Filter.Hide();
            checkedMenuItem = ListClient;
            checkedMenuItem.Checked = true;
         }

        private ToolStripMenuItem checkedMenuItem;

       

        public event EventHandler? LogoutEvent;
        public event EventHandler? AddOrderEvent;
        public event EventHandler? AddProductEvent;
        public event EventHandler? AddClientEvent;
        public event EventHandler? ListOrderEvent;
        public event EventHandler? ListProductEvent;
        public event EventHandler? ListClientEvent;
        public event EventHandler? SignUpEvent;
        public event EventHandler? FilterEvent;
        public event EventHandler? LoginEvent;

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            SignUpEvent?.Invoke(sender, e);
        }

        private void Filter_TextChanged(object sender, EventArgs e)
        {
            FilterEvent?.Invoke(sender, e);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginEvent?.Invoke(sender, e);
        }

        private void AddClient_Click(object sender, EventArgs e)
        {
            AddClientEvent?.Invoke(sender, e);
            
        }

        private void ListClient_Click(object sender, EventArgs e)
        {
            ListClientEvent?.Invoke(sender, e);
            checkMenuItems(sender);
        }

        private void AcceptOrder_Click(object sender, EventArgs e)
        {
            AddOrderEvent?.Invoke(sender, e);
        }

        private void ListOrder_Click(object sender, EventArgs e)
        {
            ListOrderEvent?.Invoke(sender, e);
            checkMenuItems(sender);
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            AddProductEvent?.Invoke(sender, e);
        }

        private void ListProduct_Click(object sender, EventArgs e)
        {
            ListProductEvent?.Invoke(sender, e);
            checkMenuItems(sender);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            LogoutEvent?.Invoke(sender, e);
        }

        public void HidePanelsExpect(MetroSet_UI.Controls.MetroSetPanel panelForShow)
        {
            foreach (var panel in this.Controls)
            {
                if (panel is MetroSet_UI.Controls.MetroSetPanel)
                {
                    (panel as MetroSet_UI.Controls.MetroSetPanel).Hide();
                }
            }

            panelForShow.Show();
        }

        private void CorrectColumns(DataGridView dataGridView)
        {

            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                dataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        public void checkMenuItems(object sender)
        {

            if (checkedMenuItem != null)
            {

                checkedMenuItem.Checked = false;

            }
            checkedMenuItem = sender as ToolStripMenuItem;
            checkedMenuItem.Checked = true;


        }

        public string[] getLoginData()
        {
            return new String[2] { UsernameLogin.Text, PasswordLogin.Text };
        }
        
        
         public void ShowClients(BindingList<Client> clients)
        {
           
            
            ClientView.DataSource = clients;
            CorrectColumns(ClientView);
            HidePanelsExpect(ClientPanel);
            Menu.Show();
            Filter.Hide();
            
        }

        public void ShowProducts(BindingList<Product> products)
        {
            
            ProductView.DataSource = products;
            CorrectColumns(ProductView);
            HidePanelsExpect(ProductPanel);
            Filter.Hide();
        }

        public void ShowOrders(BindingList<Order> orders)
        {
            OrderView.DataSource = orders;
            CorrectColumns(OrderView);
            HidePanelsExpect(OrderPanel);
            Filter.Show();
        }

        public void LogOut()
        {
            HidePanelsExpect(LoginPanel);
            Menu.Hide();
            Filter.Hide();
            checkedMenuItem = ListClient;
            checkedMenuItem.Checked = true;
            UsernameLogin.Text = "";
            PasswordLogin.Text = "";
        }
    }
}