using Application.Domain;
using System.Data;
using Application.Service;
using Application.Service.Interfaces;

namespace UI
{
    public partial class OrdersForm : Form
    {
        private readonly User _user;
        private readonly IOrderService _orderService;

        private DataTable ordersTable;

        public OrdersForm(User user)
        {
            InitializeComponent();
            ordersGridView.RowHeadersVisible = false;
            ordersGridView.AllowUserToAddRows = false;
            _user = user;
            _orderService = new OrderService();
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            ordersTable = new DataTable("Orders");

            var detailsBtn = new DataGridViewButtonColumn();
            detailsBtn.HeaderText = "Details";
            detailsBtn.Text = "Details";
            detailsBtn.UseColumnTextForButtonValue = true;
            detailsBtn.Name = "DetailsCol";

            var updateStatusBtn = new DataGridViewButtonColumn();
            updateStatusBtn.HeaderText = "Update Status";
            updateStatusBtn.Text = "Update";
            updateStatusBtn.UseColumnTextForButtonValue = true;
            updateStatusBtn.Name = "UpdateStatusCol";

            ordersGridView.DataSource = null;
            ordersGridView.Columns.Clear();

            ordersTable.Columns.Add("Id", typeof(int));
            ordersTable.Columns.Add("Customer Name", typeof(string));
            ordersTable.Columns.Add("Customer Surname", typeof(string));
            ordersTable.Columns.Add("Date", typeof(DateTime));
            ordersTable.Columns.Add("Total", typeof(double));
            ordersTable.Columns.Add("Status", typeof(string));

            List<Order> orders = LoadProperOrdersForUser();

            foreach (var order in orders)
            {
                ordersTable.Rows.Add(order.Id, order.Customer.FirstName, order.Customer.LastName, order.OrderDate, order.TotalAmount, order.Status);
            }

            ordersGridView.DataSource = ordersTable;
            ordersGridView.Columns.Add(detailsBtn);
            if (_user.Role == UserRole.Admin || _user.Role == UserRole.Staff)
                ordersGridView.Columns.Add(updateStatusBtn);
            ordersGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ordersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var selectedRow = ordersGridView.Rows[e.RowIndex];

            if (ordersGridView.Columns[e.ColumnIndex].Name == "DetailsCol")
            {
                int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                Order order = _orderService.GetById(id);
                new OrderDetailForm(order).ShowDialog();
            }
            else if (ordersGridView.Columns[e.ColumnIndex].Name == "UpdateStatusCol")
            {
                if (_user.Role != UserRole.Admin && _user.Role != UserRole.Staff)
                {
                    MessageBox.Show("Access denied.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                Order order = _orderService.GetById(id);
                var statusForm = new UpdateOrderStatusForm(order);
                if (statusForm.ShowDialog() == DialogResult.OK)
                    OrdersForm_Load(this, EventArgs.Empty);
            }
        }

        private List<Order> LoadProperOrdersForUser()
        {
            if (_user.Role == UserRole.Admin || _user.Role == UserRole.Staff)
                return _orderService.GetAll();
            else
                return _orderService.GetByCustomerId(_user.Id);
        }
    }
}
