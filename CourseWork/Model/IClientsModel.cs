using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Model
{
    internal interface IClientsModel
    {
        BindingList<Client> GetClients(string user);

        public void AddClient(Client client, string user);
    }
}
