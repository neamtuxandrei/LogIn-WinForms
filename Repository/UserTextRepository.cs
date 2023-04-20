using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.IO;

namespace LoginProject.Repository
{
    public class UserTextRepository : IUserRepository
    {
        public List<User> UserList { get; set; }
        const string FILE_NAME = "UsersDataFile.json";
        public UserTextRepository()
        {
            UserList = new List<User>();
        }

        public User GetUserByCnp(string cnp)
        {
            User output = UserList.FirstOrDefault(user => user.Cnp == cnp);
            return output;
        }

        public User GetLoginUser(string username, string password)
        {
            User output = UserList.FirstOrDefault(user => user.Username == username && user.Password == password);
            return output;
        }

        public void InsertUser(User user)
        {
           User existUser = GetUserByCnp(user.Cnp);
           if(existUser == null)
            {
                UserList.Add(user);
                SaveData();
            }
        }

        public List<User> GetAllUsers()
        {
            return UserList;
        }
       
        public void UpdateUser(User currentUser,string firstName,string lastName, string cnp, string username, string password )
        {
            User existUser = GetUserByCnp(currentUser.Cnp);
            if (existUser != null)
            {
                UserList.Remove(currentUser);
                UserList.Add(new User(firstName, lastName, cnp, username, password));
                SaveData();
            }
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

        public void SaveData()
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
    }
}
