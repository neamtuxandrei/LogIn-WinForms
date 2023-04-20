using LoginProject.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginProject
{
    public partial class AdminMenu : Form
    {
        private readonly IUserRepository _userRepository;
        private readonly IBookRepository _bookRepository;

        public AdminMenu(IUserRepository userRepository, IBookRepository bookRepository)
        {
            InitializeComponent();
            _userRepository = userRepository;
            _bookRepository = bookRepository;
        }

        private void ViewUsersButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminViewUsers viewUsers = new AdminViewUsers(_userRepository,_bookRepository);
            viewUsers.Show();
        }

        private void BuyBookButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            BuyBook buyBook = new BuyBook(_userRepository, _bookRepository);
            buyBook.Show();
        }

        private void ViewBooksButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminViewBooks viewBooks = new AdminViewBooks(_userRepository, _bookRepository);
            viewBooks.Show();
        }

        private void ReturnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm(_userRepository, _bookRepository);
            loginForm.Show();
        }

     

     
    }
}
