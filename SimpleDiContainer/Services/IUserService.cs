using SimpleDiContainer.Data;
using System.Collections.Generic;


namespace SimpleDiContainer.Services
{
    public interface IUserService
    {
        List<User> GetAllUsers();
        User GetUserById(int id);
        void AddUser(string firstName, string lastName, string email);
        void UpdateUser(int id, string firstName, string lastName, string email);
        void DeleteUser(int id);
    }
}
