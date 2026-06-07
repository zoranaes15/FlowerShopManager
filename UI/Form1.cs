using Application.Service.Interfaces;
using Application.Service;
using Application.Repository.Interfaces;
using Application.Repository;
using Application.Domain;
using Application.Database;

namespace UI
{
    public partial class Form1 : Form
    {
        private readonly IUserService _userService;

        public Form1()
        {
            InitializeComponent();
            _userService = new UserService();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string email = UsernametextBox1.Text.Trim();
            string password = PasswordtextBox2.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Unesite email i lozinku.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                User loggedUser = _userService.Authenticate(email, password);

                this.Hide();

                switch (loggedUser.Role)
                {
                    case UserRole.Admin:
                        new AdministratorForm(loggedUser).Show();
                        break;
                    case UserRole.Staff:
                        new StaffForm(loggedUser).Show();
                        break;
                    case UserRole.Customer:
                        new CustomerPortalForm(loggedUser).Show();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška pri prijavi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Registerbutton_Click(object sender, EventArgs e)
        {
            RegistrationForm form2 = new RegistrationForm();
            form2.Show();
            this.Hide();
        }

    }
}