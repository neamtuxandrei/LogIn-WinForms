using LoginProject.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginProject
{
    public partial class LoginForm : Form
    {
        private readonly IUserRepository _userRepository;
        private readonly IBookRepository _bookRepository;
        public LoginForm(IUserRepository userRepository,IBookRepository bookRepository)
        {
            InitializeComponent();
            _userRepository = userRepository;
            _bookRepository = bookRepository;
        }

        private void LoginFormCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(LoginFormCheckBox.Checked)
            {
                LoginPagePasswordText.UseSystemPasswordChar = false;
            }else
            {
                LoginPagePasswordText.UseSystemPasswordChar = true;
            }
        }
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm(_userRepository,_bookRepository);
            registerForm.Show();
        }
        private void LoginPageLoginButton_Click(object sender, EventArgs e)
        {
            User loginUser = _userRepository.GetLoginUser(LoginPageUsernameText.Text, LoginPagePasswordText.Text);
            if (loginUser != null)
            {
                if (loginUser.IsAdmin)
                {
                    this.Hide();
                    AdminMenu admin = new AdminMenu(_userRepository,_bookRepository);
                    admin.Show();
                }
                else
                {
                    MessageBox.Show("You have successfully logged in!");
                    this.Hide();
                    UserDetails userDetails= new UserDetails(loginUser, _userRepository,_bookRepository);
                    userDetails.Show();
                }

            }
            else
            {
                MessageBox.Show("Username or password incorect!");
            }
            
        }

        
    }
}
