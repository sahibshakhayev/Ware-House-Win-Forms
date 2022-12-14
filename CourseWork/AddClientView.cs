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
    public partial class AddClientView : MetroSetForm, IAddClientView
    {
        public AddClientView()
        {
            InitializeComponent();
        }

        public event EventHandler ClientAddEvent;

        public string[] getClientData()
        {
            return new String[5] { AddCleintName.Text, AddClientSurname.Text, AddClientEmail.Text, AddClientPhone.Text, AddClientAddress.Text };
        }

        private void AddClientSaveBt_Click(object sender, EventArgs e)
        {
            ClientAddEvent?.Invoke(sender, e);
        }
    }
}
