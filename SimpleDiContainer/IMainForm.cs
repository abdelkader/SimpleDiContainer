using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDiContainer
{
    public interface IUserView
    {
        void DisplayUsers(List<User> users);
        void ClearFields();
        void ShowMessage(string message);
        void ShowError(string error);

        event EventHandler LoadUsers;
        event EventHandler AddUser;
        event EventHandler UpdateUser;
        event EventHandler DeleteUser;
        event EventHandler SelectUser;

        int SelectedUserId { get; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
    }
}
