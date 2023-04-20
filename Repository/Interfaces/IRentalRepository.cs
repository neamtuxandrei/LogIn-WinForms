using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginProject.Repository.Interfaces
{
    public interface IRentalRepository : IRepository
    {
        List<Rental> GetAllRentals();
        List<Rental> GetRentalsByCnp(string cnp);
        void Insert(Rental rental);
        void DeleteRental(Rental rental);
    }
}
