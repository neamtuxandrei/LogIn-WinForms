using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginProject
{
    public class Rental
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string UserCnp { get; set; }
        public Book RentedBook { get; set; }
        public double RentedDays { get; set; }
        public double PricePerDay { get; set; }
        public double TotalPrice { get; set; }
        public Rental(string userCnp, Book rentedBook, DateTime startDate, DateTime endDate,
            double rentedDays,double pricePerDay, double totalPrice)
        {
            UserCnp = userCnp;
            RentedBook = rentedBook;
            StartDate = startDate;
            EndDate = endDate;
            RentedDays = rentedDays;
            PricePerDay = pricePerDay;
            TotalPrice = totalPrice;
        }
        public override string ToString()
        {
            return String.Format("{0} x{1}", this.RentedBook.Title, this.RentedBook.Quantity);
        }
    }
}
