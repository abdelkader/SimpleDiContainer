using SimpleDiContainer.Data;
using SimpleDiContainer.Presenter;
using SimpleDiContainer.Services;
using SimpleDiContainer.UI;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SimpleDiContainer
{
    public partial class MainForm : Form, IMainForm
    {
        private readonly UserPresenter _presenter;

        public event EventHandler LoadUsers;
        public event EventHandler AddUser;
        public event EventHandler UpdateUser;
        public event EventHandler DeleteUser;
        public event EventHandler SelectUser;

        public int SelectedUserId
        {
            get
            {
                if (_dgvUsers == null) return -1;
                if (_dgvUsers.SelectedRows.Count == 0) return -1;
                var cell = _dgvUsers.SelectedRows[0].Cells["Id"];
                if (cell == null || cell.Value == null) return -1;
                if (cell.Value is int i) return i;
                int parsed;
                return int.TryParse(cell.Value.ToString(), out parsed) ? parsed : -1;
            }
        }

        public string FirstName
        {
            get => _txtFirstName?.Text ?? string.Empty;
            set
            {
                if (_txtFirstName != null) _txtFirstName.Text = value;
            }
        }

        public string LastName
        {
            get => _txtLastName?.Text ?? string.Empty;
            set
            {
                if (_txtLastName != null) _txtLastName.Text = value;
            }
        }

        public string Email
        {
            get => _txtEmail?.Text ?? string.Empty;
            set
            {
                if (_txtEmail != null) _txtEmail.Text = value;
            }
        }


        public MainForm(IUserService userService)
        {
            InitializeComponent();
            AttachEventHandlers();
            _presenter = new UserPresenter(this, userService);
        }

        private void AttachEventHandlers()
        {
            _dgvUsers.SelectionChanged += (s, e) => SelectUser?.Invoke(s, e);
            _btnLoad.Click += (s, e) => LoadUsers?.Invoke(s, e);
            _btnAdd.Click += (s, e) => AddUser?.Invoke(s, e);
            _btnUpdate.Click += (s, e) => UpdateUser?.Invoke(s, e);
            _btnDelete.Click += (s, e) => DeleteUser?.Invoke(s, e);
            Load += (s, e) => LoadUsers?.Invoke(s, e);
        }

        public void DisplayUsers(List<User> users)
        {
            if (_dgvUsers != null) _dgvUsers.DataSource = users;
        }

        public void ClearFields()
        {
            FirstName = "";
            LastName = "";
            Email = "";
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ShowError(string error)
        {
            MessageBox.Show(error, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        
    }
}
