using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.View
{
    internal interface IAddProductView
    {
        public event EventHandler ProductAddEvent;
        String[] getProductData();
        public void Close();
    }
}
