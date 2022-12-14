using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Model
{
    internal class UsersModel : IUsersModel
    {

        

        

        List<User> _users;


        public UsersModel()
        {

           try
            {
                string json = File.ReadAllText("..\\..\\..\\Model\\DatabaseFiles\\Users.json");
                var List = JsonConvert.DeserializeObject<List<User>>(json);
                _users = List;

            }

            catch
            {
                _users = new List<User>();
            }

        }
        public void AddUser(User user)
        {
           _users.Add(user);
            File.WriteAllText("..\\..\\..\\Model\\DatabaseFiles\\Users.json", JsonConvert.SerializeObject(_users));



        }

        public List<User> GetUsers()
        {


            
            return _users;
        }
    }
}
