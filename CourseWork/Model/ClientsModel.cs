using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Model
{
    internal class ClientsModel : IClientsModel
    {

        Dictionary<string, BindingList<Client>> _clients;
       

        public ClientsModel()
        {
            try
            {
                string dic_json = File.ReadAllText("..\\..\\..\\Model\\DatabaseFiles\\Clients.json");
                var Dic = JsonConvert.DeserializeObject<Dictionary<string, BindingList<Client>>>(dic_json);
                _clients = Dic;

            }

            catch
            {
                _clients = new Dictionary<string, BindingList<Client>>();
            }
        }



        public void AddClient(Client client, string user)
        {
            if (_clients.ContainsKey(user))
            {
                BindingList<Client> clients = _clients[user];
                
                clients.Add(client);
                
                _clients[user] = clients;
               

                

            }

            else
            {
                BindingList<Client> clients = new BindingList<Client>();
                clients.Add(client);
                _clients.Add(user, clients);

            }

            File.WriteAllText("..\\..\\..\\Model\\DatabaseFiles\\Clients.json", JsonConvert.SerializeObject(_clients));
        }

        public BindingList<Client> GetClients(string user)
        {
            if (_clients.ContainsKey(user)) { return _clients[user]; } else { _clients.Add(user, new BindingList<Client>()); return _clients[user];};
            
        }
    }
}
