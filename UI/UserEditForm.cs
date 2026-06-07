using Application.Domain;
using Application.Service;
using Application.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class UserEditForm : Form
    {
        private User _user;
        private readonly IUserService _userService;
        public UserEditForm(User user)
        {
            InitializeComponent();
            _user = user;
            _userService = new UserService();
        }

        private void UserEditForm_Load(object sender, EventArgs e)
        {
            FirstNameTextBox.Text = _user.FirstName;
            LastNameTextBox.Text = _user.LastName;
            EmailTextBox.Text = _user.Email;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            User newUser = new User
            (
                id: _user.Id,
                firstName: FirstNameTextBox.Text.Trim(),
                lastName: LastNameTextBox.Text.Trim(),
                email: EmailTextBox.Text.Trim(),
                password: _user.Password,
                createdAt: _user.CreatedAt,
                role: _user.Role
            );

            _userService.Update(newUser);

            MessageBox.Show("User information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
