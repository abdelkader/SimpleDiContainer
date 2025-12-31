using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDiContainer
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
