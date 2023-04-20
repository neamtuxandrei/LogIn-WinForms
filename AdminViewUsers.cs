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
   public partial class AdminViewUsers : Form
    {
        private  readonly IUserRepository _userRepository;
        private  readonly IBookRepository _bookRepository;
        public AdminViewUsers(IUserRepository userRepository,IBookRepository bookRepository)
        {
            InitializeComponent();
            _userRepository = userRepository;
            _bookRepository = bookRepository;
            UsersListBox.DataSource = _userRepository.GetAllUsers();
        }

        private void ReturnLoginButton_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm(_userRepository,_bookRepository);
            loginForm.Show();
        }

        private void UsersListBox_DoubleClick(object sender, EventArgs e)
        {
            User currentUser = (User)UsersListBox.SelectedItem;
            this.Hide();
            UserDetails userDetails = new UserDetails(currentUser,_userRepository,_bookRepository);
            userDetails.Show();

        }

        private void ReturnMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu menu = new AdminMenu(_userRepository,_bookRepository);
            menu.Show();
        }
    }
}
