using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application.Service.Interfaces;
using Application.Service;
using Application.Repository.Interfaces;
using Application.Repository;
using Application.Database;
using Application.Domain;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string email = UsernametextBox1.Text;
            string password = PasswordtextBox2.Text;
            User loggedUser;
            using (FlowerShopManagerDbContext context = new FlowerShopManagerDbContext())
            {
                IUserService userService = new UserService(new UserDatabaseRepository(context));
                loggedUser = userService.Authenticate(email, password);
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
