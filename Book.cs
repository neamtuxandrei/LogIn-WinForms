using LoginProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginProject
{
    public class Book
    {
        public string Title { get; set; }
        public string Publisher { get; set; }
        public string Author { get; set; }
        public double Price { get; set; } = 0;
        public string Id { get; set; }
        public int Quantity { get; set; }

        public Book (string title, string publisher, string author, double price,string id,int quantity)
        {
            Title = title;
            Publisher = publisher;
            Author = author;
            Price = price;
            Id = id;
            Quantity = quantity;
        }
        public override string ToString()
        {
            return String.Format("{0} {1} x{2}", this.Title, this.Id, this.Quantity);
        }
        public double GetPriceByPercentage(double percentage)
        {
            return percentage * Price;
        } 
    }
}
