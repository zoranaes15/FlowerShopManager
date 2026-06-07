using Application.Domain;
using Application.Service.Interfaces;
using Application.Service;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class RegistrationForm : Form
    {
        private readonly IUserService _userService;
        public RegistrationForm()
        {
            InitializeComponent();
            _userService = new UserService();
            comboBox1.DataSource = Enum.GetValues(typeof(UserRole));
            comboBox1.SelectedIndex = 0;
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string firstName = FirstNameTextBox.Text.Trim();
            string lastName = LastNameTextBox.Text.Trim();
            string email = EmailTextBox.Text.Trim();
            string password = PasswordTextBox.Text;
            string confirmPassword = ConfirmPasswordTextBox.Text;
            UserRole role = (UserRole)comboBox1.SelectedIndex;

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Sva polja su obavezna.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Sifre moraju da se poklapaju.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            User newUser = new User
            (
                firstName: firstName,
                lastName: lastName,
                email: email,
                password: password,
                createdAt: DateTime.Now,
                role: role
            );
            _userService.Register(newUser);

            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

    }
}
