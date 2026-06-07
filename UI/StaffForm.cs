using Application.Domain;

namespace UI
{
    public partial class StaffForm : Form
    {
        private readonly User _user;

        public StaffForm(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            new OrdersForm(_user).Show();
        }

        private void PaymentsButton_Click(object sender, EventArgs e)
        {
            new PaymentForm(_user).Show();
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
