using Application.Domain;
using Application.Service;
using Application.Service.Interfaces;
using System.Data;

namespace UI
{
    public partial class AdministratorForm : Form
    {
        private readonly User _user;
        private readonly IOrderService _orderService;
        private readonly IPaymentService _paymentService;
        private readonly IProductService _productService;

        public AdministratorForm(User user)
        {
            InitializeComponent();
            _user = user;
            _orderService = new OrderService();
            _paymentService = new PaymentService();
            _productService = new ProductService();
        }

        private void AdministratorForm_Load(object sender, EventArgs e)
        {
            LoadDashboard();
        }
        private void DashboardButton_Click(object sender, EventArgs e)
        {
            LoadDashboard();
        }
        private void LoadDashboard()
        {
            try
            {
                var orders = _orderService.GetAll();
                var payments = _paymentService.GetAll();
                var products = _productService.GetAll();

                // Stats
                double revenue = payments.Where(p => p.Status == PaymentStatus.Completed).Sum(p => p.Amount);
                int activeOrders = orders.Count(o => o.Status == OrderStatus.Pending || o.Status == OrderStatus.Processing);
                int lowStockCount = products.Count(p => p.Stock < 25);

                groupBoxTotalRevenue.Text = "Total Revenue";
                label2.Text = $"${revenue:F2}";

                groupBoxActiveOrders.Text = "Active Orders";
                label3.Text = $"{activeOrders}";

                groupBoxLowStock.Text = "Low Stock Products";
                label4.Text = $"{lowStockCount}";

                // Recent orders grid
                var recentOrders = orders.OrderByDescending(o => o.OrderDate).Take(5).ToList();
                var dt = new DataTable();
                dt.Columns.Add("Id", typeof(int));
                dt.Columns.Add("Customer", typeof(string));
                dt.Columns.Add("Date", typeof(DateTime));
                dt.Columns.Add("Total", typeof(double));
                dt.Columns.Add("Status", typeof(string));
                foreach (var o in recentOrders)
                    dt.Rows.Add(o.Id, $"{o.Customer.FirstName} {o.Customer.LastName}", o.OrderDate, o.TotalAmount, o.Status.ToString());

                dataGridViewOrders.DataSource = dt;
                dataGridViewOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewOrders.RowHeadersVisible = false;
                dataGridViewOrders.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            new OrdersForm(_user).Show();
        }

        private void PaymentButton_Click(object sender, EventArgs e)
        {
            new PaymentForm(_user).Show();
        }

        private void ProductsButton_Click_1(object sender, EventArgs e)
        {
            new ProductsForm(_user).Show();
        }

        private void NotificationButton_Click(object sender, EventArgs e)
        {
            new NotificationsForm(_user).Show();
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            new ReportForm(_user).Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }

        private void UserButton_Click(object sender, EventArgs e)
        {
            new UsersForm().Show();
        }

        private void BackupButton_Click(object sender, EventArgs e)
        {
            using var dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() != DialogResult.OK) return;
            try
            {
                string dest = Path.Combine(dialog.SelectedPath, $"FlowerShop_{DateTime.Now:yyyyMMdd_HHmmss}.db");
                new BackupService().Backup(dest);
                MessageBox.Show($"Backup saved to:\n{dest}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RestoreButton_Click(object sender, EventArgs e)
        {
            using var dialog = new OpenFileDialog { Filter = "SQLite DB|*.db" };
            if (dialog.ShowDialog() != DialogResult.OK) return;
            try
            {
                new BackupService().Restore(dialog.FileName);
                MessageBox.Show("Database restored. Please restart the application.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
