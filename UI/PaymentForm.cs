using Application.Domain;
using Application.Service;
using Application.Service.Interfaces;
using System.Data;

namespace UI
{
    public partial class PaymentForm : Form
    {
        private readonly User _user;
        private readonly IPaymentService _paymentService;

        public PaymentForm(User user)
        {
            InitializeComponent();
            _user = user;
            _paymentService = new PaymentService();
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            LoadPayments();
        }

        private void LoadPayments()
        {
            try
            {
                var dt = new DataTable();
                dt.Columns.Add("Id", typeof(int));
                dt.Columns.Add("OrderId", typeof(int));
                dt.Columns.Add("Customer", typeof(string));
                dt.Columns.Add("Amount", typeof(double));
                dt.Columns.Add("Date", typeof(DateTime));
                dt.Columns.Add("Status", typeof(string));

                foreach (var p in _paymentService.GetAll())
                {
                    string customer = p.Order?.Customer != null
                        ? $"{p.Order.Customer.FirstName} {p.Order.Customer.LastName}"
                        : "-";
                    dt.Rows.Add(p.Id, p.Order?.Id, customer, p.Amount, p.Date, p.Status.ToString());
                }

                paymentsGridView.DataSource = dt;
                paymentsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                paymentsGridView.RowHeadersVisible = false;
                paymentsGridView.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddPaymentButton_Click(object sender, EventArgs e)
        {
            var form = new AddPaymentForm();
            if (form.ShowDialog() == DialogResult.OK)
                LoadPayments();
        }
    }
}
