using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LoginProject.Repository
{
   public class BookTextRepository : IBookRepository
    {
        public List<Book> BookList { get; set; }
        const string FILE_NAME = "BookDataFile.json";

        public BookTextRepository()
        {
            BookList = new List<Book>();
        }


        public double GetRandomNumber(double minimum, double maximum)
        {
            Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }
        public void LoadData()
        {
            if (File.Exists(FILE_NAME))
            {
                string jsonPath = Path.Combine(Environment.CurrentDirectory, FILE_NAME);
                string jsonString = File.ReadAllText(jsonPath);
                BookList = JsonSerializer.Deserialize<List<Book>>(jsonString);
            }
        }

        public void SaveData()
        {
            if (!File.Exists(FILE_NAME))
            {
                var myFile = File.Create(FILE_NAME);
                myFile.Close();
            }
            string jsonPath = Path.Combine(Environment.CurrentDirectory, FILE_NAME);
            string jsonList = JsonSerializer.Serialize(BookList);
            File.WriteAllText(jsonPath, jsonList);
        }

        public Book GetBookById(string id)
        {
            return BookList.FirstOrDefault(book=> book.Id == id);
          //  return output;
        }

        public List<Book> GetAllBooks()
        {
            return BookList;
        }

        public void InsertBook(Book book, int quantity)
        {
           Book existBook = GetBookById(book.Id);
            if (existBook == null)
            {
                BookList.Add(book);
            }
            else
            {
                existBook.Quantity += quantity;
            }
            SaveData();
        }

      
    }
}
