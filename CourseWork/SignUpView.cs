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
    public partial class SignUpView : MetroSetForm, ISignUpView
    {
        public SignUpView()
        {
            InitializeComponent();
        }

        public event EventHandler? SignUpEvent;

        public string[] getUserData()
        {
            return new String[5] { UsernameSignUp.Text, PasswordSignUp.Text, RepeatPasswordSignUp.Text, NameSignUp.Text, SurnameSignUp.Text };
        }

        
        private void PasswordShow_MouseDown(object sender, MouseEventArgs e)
        {
            PasswordSignUp.UseSystemPasswordChar = false;
            PasswordSignUp.WatermarkText = "Password";
        }

        private void PasswordShow_MouseUp(object sender, MouseEventArgs e)
        {
            PasswordSignUp.UseSystemPasswordChar = true;
            PasswordSignUp.WatermarkText = "Password";
        }

        private void RepeatPasswordShow_MouseDown(object sender, MouseEventArgs e)
        {
            RepeatPasswordSignUp.UseSystemPasswordChar = false;
            RepeatPasswordSignUp.WatermarkText = "Repeat Password";
        }

        private void RepeatPasswordShow_MouseUp(object sender, MouseEventArgs e)
        {
            RepeatPasswordSignUp.UseSystemPasswordChar = true;
            RepeatPasswordSignUp.WatermarkText = "Repeat Password";
        }

        private void SignUpUserButton_Click(object sender, EventArgs e)
        {
            SignUpEvent?.Invoke(sender, e);
        }
    }
}
