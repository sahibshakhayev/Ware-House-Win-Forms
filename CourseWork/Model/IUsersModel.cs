using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Model
{
    internal interface IUsersModel
    {
        List<User> GetUsers();
        public void AddUser(User user);
    }
}
