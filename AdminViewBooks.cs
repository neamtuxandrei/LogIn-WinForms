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
    public partial class AdminViewBooks : Form
    {
        private readonly IUserRepository _userRepository;
        private readonly IBookRepository _bookRepository;
        public AdminViewBooks(IUserRepository userRepository, IBookRepository bookRepository)
        {
            InitializeComponent();
            _userRepository = userRepository;
            _bookRepository = bookRepository;
            BooksListBox.DataSource = _bookRepository.GetAllBooks();
        }

        private void ReturnLoginButton_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm(_userRepository, _bookRepository);
            loginForm.Show();
        }

        private void ReturnMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu menu = new AdminMenu(_userRepository, _bookRepository);
            menu.Show();
        }

        private void SearchBooksText_TextChanged(object sender, EventArgs e)
        {
            List<Book> bookList = _bookRepository.GetAllBooks();
           if(string.IsNullOrEmpty(SearchBooksText.Text) == false)
            {
                // "Where" method returns a iEnumerable, not a List.
                var booksSearched = bookList.Where(book => book.Title.StartsWith(SearchBooksText.Text));
                BooksListBox.DataSource = booksSearched.ToList();
            }
           else if(SearchBooksText.Text == "")
            {
                BooksListBox.DataSource = bookList;
            }
        }
    }
}
