using System.Text.Json;
using System.Text.Json.Serialization;
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
using LoginProject.Repository;

namespace LoginProject
{
    public partial class RegisterForm : Form

    {
        private const int MAX_LENGTH = 20;
        private const int MIN_LENGTH = 5;
        private readonly IUserRepository _userRepository;
        private readonly IBookRepository _bookRepository;
        public RegisterForm(IUserRepository userRepository, IBookRepository bookRepository)
        {
            InitializeComponent();
            _userRepository = userRepository;
            _bookRepository = bookRepository;
        }

        private void RegisterPageRegisterButton_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                User existingUser = _userRepository.GetUserByCnp(CnpText.Text);
                if (existingUser == null)
                {
                    _userRepository.InsertUser
                        (new User(FirstNameText.Text,LastNameText.Text,CnpText.Text,RegisterPageUsernameText.Text,PasswordText.Text));
                    PageLabel.ForeColor = System.Drawing.Color.Green;
                    PageLabel.Text = "You have successfully registered!\nPlease log in.";
                }
                else
                {
                    PageLabel.Text = "This account already exists!";
                }
            }
            else
            {
                PageLabel.ForeColor = System.Drawing.Color.Red;
                PageLabel.Text = "You couldn't register.";
            }
        }
        public bool ValidateFields()
        {
            bool isValid = true;
            if (FirstNameText.TextLength < MIN_LENGTH || FirstNameText.TextLength > MAX_LENGTH)
            {
                FirstNameLabel.Text = $"Your field must be between {MIN_LENGTH} and {MAX_LENGTH} chars!";
                isValid = false;
            }
            if (LastNameText.TextLength < MIN_LENGTH || LastNameText.TextLength > MAX_LENGTH)
            {
                LastNameLabel.Text = $"Your field must be between {MIN_LENGTH} and {MAX_LENGTH} chars!";
                isValid = false;
            }
            if (PasswordText.Text != ConfirmPasswordText.Text)
            {
                PasswordsLabel.Text = $"Your passwords don't match!";
                isValid = false;
            }
            if (CnpText.TextLength < MIN_LENGTH || CnpText.TextLength > MAX_LENGTH)
            {
                CnpLabel.Text = $"Your field must be between {MIN_LENGTH} and {MAX_LENGTH} chars!\n";
            }
            bool CnpConvert = long.TryParse(CnpText.Text, out long a);
            if (!CnpConvert)
            {
                CnpLabel.Text = $"You need to introduce numbers!\n";
                isValid = false;
            }

            return isValid;

        }
        private void RegisterPageLoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm(_userRepository,_bookRepository);
            loginForm.Show();

        }
        private void RegisterFormCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (RegisterFormCheckBox.Checked)
            {
                PasswordText.UseSystemPasswordChar = false;
                ConfirmPasswordText.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordText.UseSystemPasswordChar = true;
                ConfirmPasswordText.UseSystemPasswordChar = true;
            }
        }
    }
}
