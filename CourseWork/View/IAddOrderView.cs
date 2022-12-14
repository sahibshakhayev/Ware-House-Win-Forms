using CourseWork.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.View
{
    internal interface IAddOrderView
    {
        public event EventHandler OrderAddEvent;
        String[] getOrderData();
        public void Close();
    }
}
