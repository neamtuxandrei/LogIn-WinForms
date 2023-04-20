using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginProject.Repository
{
    public interface IBookRepository : IRepository
    {
        Book GetBookById(string id);
        List<Book> GetAllBooks();
        void InsertBook(Book book,int quantity);
        double GetRandomNumber(double minimum, double maximum);

    }
}
