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
using System.Text.Json;
using System.Text.Json.Serialization;
using LoginProject.Repository;
using LoginProject.Repository.Interfaces;

namespace LoginProject
{
    public partial class UserDetails : Form
    {
        private readonly User _currentUser;
        private  readonly IUserRepository _userRepository;
        private  readonly IBookRepository _bookRepository;
        private readonly IRentalRepository _rentalRepository;
        public UserDetails(User user,IUserRepository userRepository, IBookRepository bookRepository)
        { 
            InitializeComponent();
            _currentUser = user;
            LabelTitle.Text = $"USER {_currentUser.Username}";
            CnpText.Text = _currentUser.Cnp;
            FirstNameText.Text = _currentUser.Name;
            LastNameText.Text = _currentUser.LastName;
            _userRepository = userRepository;
            _bookRepository = bookRepository;
            _rentalRepository = new RentalItemRepository();
            _rentalRepository.LoadData();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _userRepository.UpdateUser(_currentUser, FirstNameText.Text, LastNameText.Text,_currentUser.Cnp,_currentUser.Username,_currentUser.Password);
            SaveLabel.Text = "Info saved succesfully";
        }

        private void ReturnLoginButton_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm(_userRepository,_bookRepository);
            loginForm.Show();
        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            if (CnpText.Enabled == false)
            {
                FirstNameText.Enabled = true;
                LastNameText.Enabled = true;
            }
            else
            {
                FirstNameText.Enabled = false;
                LastNameText.Enabled = false;
            }
        }

        private void RentBookButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookRent bookRent = new BookRent(_currentUser,_userRepository,_bookRepository,_rentalRepository);
            bookRent.Show();
        }

        private void RentalsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserViewRentals userViewRentals = new UserViewRentals(_currentUser,_userRepository,_bookRepository,_rentalRepository);
            userViewRentals.Show();
        }
    }
}
