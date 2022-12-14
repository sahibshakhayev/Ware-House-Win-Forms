using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.View
{
    internal interface ISignUpView
    {
        public event EventHandler SignUpEvent;

        String[] getUserData();
        public void Close();
    }
}
