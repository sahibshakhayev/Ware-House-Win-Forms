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
    public partial class AddProductView : MetroSetForm,IAddProductView
    {
        public AddProductView()
        {
            InitializeComponent();
        }

        public event EventHandler ProductAddEvent;

        public string[] getProductData()
        {
            return new String[4] {AddProductName.Text, AddProductPrice.Text, AddProductQuantity.Value.ToString(),AddProductDescription.Text };
        }

        private void AddProductBt_Click(object sender, EventArgs e)
        {
            ProductAddEvent?.Invoke(sender, e);
        }
    }
}
