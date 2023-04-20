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
    public partial class UserViewRentals : Form
    {
        private readonly User _currentUser;
        private readonly IUserRepository _userRepository;
        private readonly IBookRepository _bookRepository;
        private readonly IRentalRepository _rentalRepository;
        private const double TAX_PENALIZATION = (30.0 / 100);
        private double _daysLeft;

        public UserViewRentals(User currentUser, IUserRepository userRepository,
            IBookRepository bookRepository, IRentalRepository rentalRepository)
        {
            InitializeComponent();
            _currentUser = currentUser;
            _userRepository = userRepository;
            _bookRepository = bookRepository;
            _rentalRepository = rentalRepository;
            BooksListBox.DataSource = _rentalRepository.GetRentalsByCnp(_currentUser.Cnp);
            UserWalletText.Text = _currentUser.Wallet.ToString();
        }

        private void SearchBooksText_TextChanged(object sender, EventArgs e)
        {
            List<Rental> rentalList = _rentalRepository.GetRentalsByCnp(_currentUser.Cnp);
            if (string.IsNullOrEmpty(SearchBooksText.Text) == false)
            {
                var rentalsSearched = rentalList.Where(rental => rental.RentedBook.Title.StartsWith(SearchBooksText.Text));
                BooksListBox.DataSource = rentalsSearched.ToList();
            }
            else if (SearchBooksText.Text == "")
            {
                BooksListBox.DataSource = rentalList;
            }
        }

        private void ReturnBookButton_Click(object sender, EventArgs e)
        {
            Rental currentRental = (Rental)BooksListBox.SelectedItem;
            if (_daysLeft < 0)
            {
                TaxUser(currentRental.PricePerDay);
            }
            else
            {
                PayBackUser(currentRental);
            }
            if(currentRental.RentedBook.Quantity > 1)
            {
                currentRental.RentedBook.Quantity--;
            }
            else
            {
                _rentalRepository.DeleteRental(currentRental);
            }
            BooksListBox.DataSource = null;
            BooksListBox.DataSource = _rentalRepository.GetAllRentals();
        }

        private void UpdateTextNewBalance(Rental currentRental)
        {
            if (_daysLeft < 0)
            {
                NewBalanceText.Text = $"{_currentUser.Wallet} - {Math.Round(_currentUser.Wallet - (TAX_PENALIZATION * currentRental.PricePerDay),2)}";
            }
            else
            {
                NewBalanceText.Text = $"{_currentUser.Wallet} + {Math.Round(_currentUser.Wallet + (currentRental.PricePerDay * _daysLeft),2)} ";
            }
        }
        private void PayBackUser(Rental currentRental)
        {
            _currentUser.Wallet = Math.Round(_currentUser.Wallet + (currentRental.PricePerDay * _daysLeft), 2);
        }
        private void TaxUser(double rentalPrice)
        {
            _currentUser.Wallet = Math.Round(_currentUser.Wallet - (TAX_PENALIZATION * rentalPrice), 2);
            _userRepository.SaveData();
            UpdateTextWallet();
        }

        private void BooksListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            Rental currentRental = (Rental)BooksListBox.SelectedItem;
            _daysLeft = (currentRental.EndDate - DateTime.Now).TotalDays;
            RentedDueLabel.Text = currentRental.EndDate.ToString("dddd , MMM dd yyyy");
            PricePerDayText.Text = currentRental.PricePerDay.ToString();
            NewBalanceText.Text = $"{_currentUser.Wallet}";
            UpdateTextNewBalance(currentRental);
        }
        private void UpdateTextWallet()
        {
            UserWalletText.Text = _currentUser.Wallet.ToString();
        }

        private void UserViewRentals_Load(object sender, EventArgs e)
        {
            CurrentDateLabel.Text = DateTime.Now.ToString("dddd , MMM dd yyyy");
        }
    }
 }


