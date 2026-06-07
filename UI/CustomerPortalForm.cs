using Application.Domain;

namespace UI
{
    public partial class CustomerPortalForm : Form
    {
        private readonly User _user;

        public CustomerPortalForm(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            new ProductsForm(_user).ShowDialog();
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            new OrdersForm(_user).ShowDialog();
        }

        private void PlaceOrderButton_Click(object sender, EventArgs e)
        {
            new PlaceOrderForm(_user).Show();
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            new CustomerProfileForm(_user).Show();
        }

        private void NotificationsButton_Click(object sender, EventArgs e)
        {
            new NotificationsForm(_user).Show();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }
    }
}
