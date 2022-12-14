using CourseWork.Model;
using CourseWork.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Presenter
{
    internal class SignUpPresenter:IAddPresenter
    {
        private IUsersModel usersModel;
        private ISignUpView signUpView;

        public SignUpPresenter(IUsersModel usersModel, ISignUpView signUpView)
        {
            this.usersModel = usersModel;
            this.signUpView = signUpView;
            this.signUpView.SignUpEvent += SignUp;

        }

        

        public bool checkFieldsFilled()
        {
            foreach (var item in signUpView.getUserData())
            {
                if (item.Trim(' ') == String.Empty)
                {
                    return false;
                }


            }
            return true;
        }

        private void SignUp(object? sender, EventArgs e) {
            
            bool error = false;

            

            if (signUpView.getUserData()[1] == signUpView.getUserData()[2] && checkFieldsFilled())
            {

                
                foreach (var user in usersModel.GetUsers())
                {
                    if (signUpView.getUserData()[0].ToLower() == user.getUsernameForCheck() )
                    {

                        MessageBox.Show("Username already exist!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        error = true;
                        break;
                    }
                }

                if (!error)
                {
                    usersModel.AddUser(new User(signUpView.getUserData()[0], signUpView.getUserData()[1], signUpView.getUserData()[3], signUpView.getUserData()[4]));
                    MessageBox.Show("Registration Successfull!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
            }

            else if(!checkFieldsFilled())
            {
                MessageBox.Show("Please fill all fields", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                MessageBox.Show("Password Don't match!", "Error!", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        
        
        }


    }
}
