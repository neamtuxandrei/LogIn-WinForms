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
    public partial class BuyBook : Form
    {
        
        private readonly IUserRepository _userRepository;
        private readonly IBookRepository _bookRepository;
        private double _bookPrice;
        public BuyBook(IUserRepository userRepository, IBookRepository bookRepository)
        {
            InitializeComponent();
            _userRepository = userRepository;
            _bookRepository = bookRepository;
            _bookPrice = _bookRepository.GetRandomNumber(1, 100);
            
        }
        private void PriceTextBox_TextChanged(object sender, EventArgs e)
        {
             double.TryParse(PriceTextBox.Text,out double result);
            _bookPrice = result;
        }
        private void QuantityValue_ValueChanged(object sender, EventArgs e)
        {
            TotalPrice.Text = ( CalculateTotalPrice(_bookPrice, (int)QuantityNumber.Value) ).ToString();
        }
        private void CreateButton_Click(object sender, EventArgs e)
        {

            if (SalePrice.Text == string.Empty)
            {
                double.TryParse(PriceTextBox.Text, out double bookPrice);
                _bookRepository.InsertBook
              (new Book(TitleTextBox.Text, PublisherTextBox.Text, AuthorTextBox.Text, bookPrice, IdTextBox.Text,
              (int)QuantityNumber.Value), (int)QuantityNumber.Value);
            }
            else
            {
                double.TryParse(SalePrice.Text, out double salePrice);
                _bookRepository.InsertBook
               (new Book(TitleTextBox.Text, PublisherTextBox.Text, AuthorTextBox.Text, salePrice, IdTextBox.Text,
               (int)QuantityNumber.Value), (int)QuantityNumber.Value);
            }
            BuyLabel.ForeColor = System.Drawing.Color.Green;
            BuyLabel.Text = "Bought succesfully!";
           
        }
        private double CalculateTotalPrice (double bucPrice, int quantity)
        {
            return bucPrice * quantity;
        }

        private void ReturnToMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu menu = new AdminMenu(_userRepository, _bookRepository);
            menu.Show();
        }

        
    }
}
