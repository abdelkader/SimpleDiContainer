using SimpleDiContainer.Services;
using SimpleDiContainer.UI;
using System;


namespace SimpleDiContainer.Presenter
{
    public class UserPresenter
    {
        private readonly IMainForm _view;
        private readonly IUserService _service;

        public UserPresenter(IMainForm view, IUserService service)
        {
            _view = view;
            _service = service;

            _view.LoadUsers += LoadUsers;
            _view.AddUser += AddUser;
            _view.UpdateUser += UpdateUser;
            _view.DeleteUser += DeleteUser;
            _view.SelectUser += SelectUser;
        }

        private void LoadUsers(object sender, EventArgs e)
        {
            try
            {
                var users = _service.GetAllUsers();
                _view.DisplayUsers(users);
                _view.ClearFields();
            }
            catch (Exception ex)
            {
                _view.ShowError($"Error: {ex.Message}");
            }
        }

        private void AddUser(object sender, EventArgs e)
        {
            try
            {
                _service.AddUser(_view.FirstName, _view.LastName, _view.Email);
                _view.ShowMessage("User already exists!");
                LoadUsers(sender, e);
            }
            catch (Exception ex)
            {
                _view.ShowError($"Error: {ex.Message}");
            }
        }

        private void UpdateUser(object sender, EventArgs e)
        {
            try
            {
                if (_view.SelectedUserId <= 0)
                {
                    _view.ShowError("Select a user");
                    return;
                }

                _service.UpdateUser(_view.SelectedUserId, _view.FirstName, _view.LastName, _view.Email);
                _view.ShowMessage("User modified with succes");
                LoadUsers(sender, e);
            }
            catch (Exception ex)
            {
                _view.ShowError($"Error: {ex.Message}");
            }
        }

        private void DeleteUser(object sender, EventArgs e)
        {
            try
            {
                if (_view.SelectedUserId <= 0)
                {
                    _view.ShowError("Select a user");
                    return;
                }

                _service.DeleteUser(_view.SelectedUserId);
                _view.ShowMessage("User deleted successfully");
                LoadUsers(sender, e);
            }
            catch (Exception ex)
            {
                _view.ShowError($"Error: {ex.Message}");
            }
        }

        private void SelectUser(object sender, EventArgs e)
        {
            try
            {
                if (_view.SelectedUserId <= 0) return;

                var user = _service.GetUserById(_view.SelectedUserId);
                if (user != null)
                {
                    _view.FirstName = user.FirstName;
                    _view.LastName = user.LastName;
                    _view.Email = user.Email;
                }
            }
            catch (Exception ex)
            {
                _view.ShowError($"Error: {ex.Message}");
            }
        }
    }
}
