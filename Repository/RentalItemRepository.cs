using LoginProject.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LoginProject.Repository
{
    public class RentalItemRepository : IRentalRepository
    {
        public List<Rental> RentalItems { get; set; }
        public const string FILE_NAME = "RentalDataFile.json";
        public RentalItemRepository()
        {
            RentalItems = new List<Rental>();
        }

        public void SaveData()
        {
            if (!File.Exists(FILE_NAME))
            {
                var myFile = File.Create(FILE_NAME);
                myFile.Close();
            }
            string jsonPath = Path.Combine(Environment.CurrentDirectory, FILE_NAME);
            string jsonList = JsonSerializer.Serialize(RentalItems);
            File.WriteAllText(jsonPath, jsonList);
        }

        public void LoadData()
        {
            if (File.Exists(FILE_NAME))
            {
                string jsonPath = Path.Combine(Environment.CurrentDirectory, FILE_NAME);
                string jsonString = File.ReadAllText(jsonPath);
                RentalItems = JsonSerializer.Deserialize<List<Rental>>(jsonString);
            }
        }
        public List<Rental> GetRentalsByCnp(string cnp)
        {
            List<Rental> rental =( RentalItems.Where(rentalUser => rentalUser.UserCnp == cnp) ).ToList();
            return rental;
        }
        public List<Rental> GetAllRentals()
        {
            return RentalItems;
        }
        public void DeleteRental(Rental rental)
        {
            if(RentalItems.Contains(rental))
            {
                RentalItems.Remove(rental);
            }
            SaveData();
        }

        public void Insert(Rental rental)
        {
            RentalItems.Add(rental);
            SaveData();
        }
    }
}
