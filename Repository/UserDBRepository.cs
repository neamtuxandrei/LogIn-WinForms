using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.IO;


namespace LoginProject.Repository
{
    public class UserDBRepository : //IUserRepository // AICI MIMAM FUNCTIONALITATEA BAZEI DE DATE
    {
        public List<User> UserList { get; set; }
        const string FILE_NAME = "UsersDataDB.json";
        public UserDBRepository()
        {
            UserList = new List<User>();
        }
        public User GetUserByCnp(string cnp)
        {
            User output = UserList.FirstOrDefault(user => user.Cnp == cnp);
            return output;
        }

        public void InsertUser(User user)
        {
            //aici iei logica de insert 
            //verificam daca exista in lista
            //daca nu exista il inseram si salvam lista SaveData();

        }

        public void UpdateUser(User user)
        {
            //daca exista userul 
            //inlocuim proprietatile SaveData();
        }
        private void SaveData()
        {
            if (!File.Exists(FILE_NAME))
            {
                var myFile = File.Create(FILE_NAME);
                myFile.Close();
            }
            string jsonPath = Path.Combine(Environment.CurrentDirectory, FILE_NAME);
            string jsonList = JsonSerializer.Serialize(UserList);
            File.WriteAllText(jsonPath, jsonList);
        }

        public void LoadData()
        {
            if (File.Exists(FILE_NAME))
            {
                string jsonPath = Path.Combine(Environment.CurrentDirectory, FILE_NAME);
                string jsonString = File.ReadAllText(jsonPath);
                UserList = JsonSerializer.Deserialize<List<User>>(jsonString);
            }
        }
    }
}
