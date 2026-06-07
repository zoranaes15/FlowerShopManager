using Application.Domain;
using Application.Service;
using Application.Service.Interfaces;

namespace UI
{
    public partial class CustomerProfileForm : Form
    {
        private readonly User _user;
        private readonly IUserService _userService;

        public CustomerProfileForm(User user)
        {
            InitializeComponent();
            _user = user;
            _userService = new UserService();
        }

        private void CustomerProfileForm_Load(object sender, EventArgs e)
        {
            firstNameLabel.Text = _user.FirstName;
            lastNameLabel.Text = _user.LastName;
            emailLabel.Text = _user.Email;
            createdAtLabel.Text = _user.CreatedAt.ToString("yyyy-MM-dd");

            firstNameTextBox.Text = _user.FirstName;
            lastNameTextBox.Text = _user.LastName;
        }

        private void SaveProfileButton_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = firstNameTextBox.Text.Trim();
                string lastName = lastNameTextBox.Text.Trim();
                if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
                    throw new Exception("First name and last name cannot be empty.");

                _user.UpdateProfile(firstName, lastName);
                _userService.Update(_user);
                firstNameLabel.Text = _user.FirstName;
                lastNameLabel.Text = _user.LastName;
                MessageBox.Show("Profile updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            try
            {
                string currentPw = currentPasswordTextBox.Text;
                string newPw = newPasswordTextBox.Text;
                string confirmPw = confirmPasswordTextBox.Text;

                if (currentPw != _user.Password)
                    throw new Exception("Current password is incorrect.");
                if (newPw.Length < 8)
                    throw new Exception("New password must be at least 8 characters.");
                if (newPw != confirmPw)
                    throw new Exception("Passwords do not match.");

                _user.ResetPassword(newPw);
                _userService.Update(_user);
                currentPasswordTextBox.Text = "";
                newPasswordTextBox.Text = "";
                confirmPasswordTextBox.Text = "";
                MessageBox.Show("Password changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
