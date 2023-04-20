using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginProject
{
    public class User
    {    
        public string Name { get; set; } 
        public string LastName { get; set; } 
        public string Username { get; set; } 
        public string Password { get; set; }
        public string Cnp { get; set; }
        public bool IsAdmin { get; set; } = false;
        public List<Book> BooksRented { get; set; }
        public double Wallet { get; set; } = 1000;

        public User(string name, string lastname, string cnp, string username, string password)
        {
            Name = name;
            LastName = lastname;
            Cnp = cnp;
            Username = username;
            Password = password;
        }
        public override string ToString()
        {
            return String.Format("{0} {1} Cnp:{2}", this.Name, this.LastName, this.Cnp);
        }

    }
}
