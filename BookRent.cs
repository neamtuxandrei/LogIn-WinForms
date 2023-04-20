using LoginProject.Repository;
using LoginProject.Repository.Interfaces;
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
    public partial class BookRent : Form
    {
        private readonly User _currentUser;
        private readonly IUserRepository _userRepository;
        private readonly IBookRepository _bookRepository;
        private readonly IRentalRepository _rentalRepository;
        private readonly List<Book> cartBooks;
        private double _totalPrice = 0.0;
        private const double PERCENTAGE_OF_BOOK = 5.0 / 100;


        public BookRent(User currentUser, IUserRepository userRepository, IBookRepository bookRepository, IRentalRepository rentalRepository)
        {
            InitializeComponent();
            _currentUser = currentUser;
            _userRepository = userRepository;
            _bookRepository = bookRepository;
            BooksListBox.DataSource = _bookRepository.GetAllBooks();
            _rentalRepository = rentalRepository;
            cartBooks = new List<Book>();
        }

        private void BooksListBox_Click(object sender, EventArgs e)
        {
            Book currentBook = (Book)BooksListBox.SelectedItem;
            PricePerDay.Text = (currentBook.GetPriceByPercentage(PERCENTAGE_OF_BOOK)).ToString();
        }



        private void BookRent_Load(object sender, EventArgs e)
        {
            DateTimePicker.MinDate = DateTime.Now;
            DateTimePicker.MaxDate = DateTime.Now.AddYears(2);
            Sold.Text = _currentUser.Wallet.ToString();
            RemoveRentButton.Enabled = false;
            BooksListBox.ClearSelected();
        }

        private void RemoveRentButton_Click(object sender, EventArgs e)
        {
            Book bookSelected = (Book)BooksListBox.SelectedItem;
            Book currentCartBook = (Book)CartListBox.SelectedItem;
            if (CartListBox.Items.Contains(currentCartBook))
            {
                RemoveRentButton.Enabled = true;
                if (currentCartBook.Quantity > 1)
                {
                    currentCartBook.Quantity--;
                } else
                {
                    cartBooks.Remove(currentCartBook);
                }
                UpdateCartDataSource();
                MinusCartPrice(currentCartBook.GetPriceByPercentage(PERCENTAGE_OF_BOOK));
                bookSelected.Quantity++;
                UpdateBooksDataSource();
            }
            else
            {
                RemoveRentButton.Enabled = false;
                UpdateTotalPriceText();
            }
        }
        private void AddRentButton_Click(object sender, EventArgs e)
        {
            Book currentBook = (Book)BooksListBox.SelectedItem;
            if (currentBook.Quantity > 0)
            {
                AddRentButton.Enabled = true;
                if (cartBooks.Exists(bookie => bookie.Id == currentBook.Id))
                {
                    foreach (Book book in cartBooks)
                    {
                        if (book.Id == currentBook.Id)
                        {
                            book.Quantity++;
                            UpdateCartDataSource();
                        }
                    }
                }
                else
                {
                    cartBooks.Add(new Book(currentBook.Title, currentBook.Publisher, currentBook.Author, currentBook.Price, currentBook.Id, 1));
                    CartListBox.DataSource = null;
                    CartListBox.Items.Add(currentBook);
                    CartListBox.DataSource = cartBooks;
                }
                AddCartPrice(currentBook.GetPriceByPercentage(PERCENTAGE_OF_BOOK));
                currentBook.Quantity--;
                BooksListBox.ClearSelected();
                UpdateBooksDataSource();
            }

        }
        private void AddCartPrice(double bookPrice)
        {
            _totalPrice = Math.Round(_totalPrice + bookPrice, 2);
            UpdateTotalPriceText();
        }

        private void MinusCartPrice(double bookPrice)
        {
            _totalPrice = Math.Round(_totalPrice - bookPrice, 2);
            UpdateTotalPriceText();
        }

        private void UpdateTotalPriceText()
        {
            TotalPrice.Text = _totalPrice.ToString();
        }
        private void UpdateCartDataSource()
            {
            CartListBox.DataSource = null;
            CartListBox.DataSource = cartBooks;
        }
        private void UpdateBooksDataSource()
        {
            _bookRepository.SaveData();
            BooksListBox.DataSource = null;
            BooksListBox.DataSource = _bookRepository.GetAllBooks();
        }

        private void RentButton_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                foreach (Book book in cartBooks)
                {
                    var rentalItem = new Rental(_currentUser.Cnp, book, DateTime.Now, DateTimePicker.Value, GetRentedDays(DateTimePicker.Value),
                        book.GetPriceByPercentage(PERCENTAGE_OF_BOOK), _totalPrice);
                    _rentalRepository.Insert(rentalItem);
                }
                PageLabel.ForeColor = System.Drawing.Color.Green;
                PageLabel.Text = "You rented succesfully!";
                CartListBox.DataSource = null;
                _bookRepository.LoadData();
            }
        }
        private double GetRentedDays(DateTime endDate)
        {
            return (endDate - DateTime.Now).TotalDays;
        }


        private bool ValidateFields()
        {
            bool isValid = true;
            if (CartListBox.Items.Count == 0)
            {
                PageLabel.ForeColor = System.Drawing.Color.Red;
                PageLabel.Text = "You need to choose a book!";
                isValid = false;
            }
            return isValid;
        }
        private void SearchBooksText_TextChanged(object sender, EventArgs e)
        {
            List<Book> bookList = _bookRepository.GetAllBooks();
            if (string.IsNullOrEmpty(SearchBooksText.Text) == false)
            {
                var booksSearched = bookList.Where(book => book.Title.StartsWith(SearchBooksText.Text));
                BooksListBox.DataSource = booksSearched.ToList();
            }
            else if (SearchBooksText.Text == "")
            {
                BooksListBox.DataSource = bookList;
            }
        }

        private void ReturnMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserDetails userDetails = new UserDetails(_currentUser, _userRepository, _bookRepository);
            userDetails.Show();
        }

        private void ReturnLoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm(_userRepository, _bookRepository);
            loginForm.Show();
        }

        private void BooksListBox_SelectedValueChanged_1(object sender, EventArgs e)
        {
            Book currentBook = (Book)BooksListBox.SelectedItem;
            if (currentBook == null)
                AddRentButton.Enabled = false;
            else if (currentBook.Quantity < 1)
                AddRentButton.Enabled = false;
            else
                AddRentButton.Enabled = true;
        }

        private void CartListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            Book currentBook = (Book)CartListBox.SelectedItem;
            if (currentBook == null)
                RemoveRentButton.Enabled = false;
            else
                RemoveRentButton.Enabled = true;
        }
    }
}
    

