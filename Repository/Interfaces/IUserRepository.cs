using System.Collections.Generic;

namespace LoginProject.Repository
{
    public interface IUserRepository : IRepository
    {
        void InsertUser(User user);
        User GetUserByCnp(string cnp);
        User GetLoginUser(string username, string password);
        void UpdateUser(User currentUser, string firstName, string lastName, string cnp, string username, string password);
        List<User> GetAllUsers();
    
        
    }
}


