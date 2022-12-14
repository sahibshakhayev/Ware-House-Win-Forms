using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.View
{
    internal interface IAddClientView
    {
        public event EventHandler ClientAddEvent;
        String[] getClientData();
        public void Close();
    }
}
