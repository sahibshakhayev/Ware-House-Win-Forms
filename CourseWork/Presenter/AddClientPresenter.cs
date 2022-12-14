using CourseWork.Model;
using CourseWork.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Presenter
{
    internal class AddClientPresenter:IAddPresenter
    {
        private IClientsModel clientsModel;
        private IAddClientView addClientView;
        string User { get;}

        public AddClientPresenter(IClientsModel clientsModel, IAddClientView addClientView, string user)
        {
            this.clientsModel = clientsModel;
            this.addClientView = addClientView;
            this.addClientView.ClientAddEvent += AddClient;
            User = user;
        }

        public bool checkFieldsFilled()
        {
            foreach (var item in addClientView.getClientData())
            {
                if (item.Trim(' ') == String.Empty)
                {
                    return false;
                }


            }
            return true;
        }

        private void AddClient(object? sender, EventArgs e) {
            
            bool error = false;

                
     
                foreach (var client in clientsModel.GetClients(User))
                {
                    if (addClientView.getClientData()[0] == client.Name && addClientView.getClientData()[1] == client.Surname &&
                    addClientView.getClientData()[2] == client.Email && addClientView.getClientData()[3] == client.Phone &&
                    addClientView.getClientData()[4] == client.Address)
                    {

                        MessageBox.Show("Client already exist!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        error = true;
                        break;
                    }
                }

                if (!error && checkFieldsFilled())
                {
                    clientsModel.AddClient(new Client(addClientView.getClientData()[0], addClientView.getClientData()[1], addClientView.getClientData()[2],
                        addClientView.getClientData()[3], addClientView.getClientData()[4]), User);
                    MessageBox.Show("Add Successfull!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                    
                }
            else if (!checkFieldsFilled())
            {
                MessageBox.Show("Please Fill All Fields!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        
        
        }


    }
}
