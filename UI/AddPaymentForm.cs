using Application.Domain;
using Application.Service;
using Application.Service.Interfaces;

namespace UI
{
    public partial class AddPaymentForm : Form
    {
        private readonly IOrderService _orderService;
        private readonly IPaymentService _paymentService;
        private readonly INotificationService _notificationService;

        public AddPaymentForm()
        {
            InitializeComponent();
            _orderService = new OrderService();
            _paymentService = new PaymentService();
            _notificationService = new NotificationService();

            statusComboBox.DataSource = Enum.GetValues(typeof(PaymentStatus));
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                int orderId = (int)orderIdNumeric.Value;
                double amount = (double)amountNumeric.Value;
                PaymentStatus status = (PaymentStatus)statusComboBox.SelectedItem!;

                Order order = _orderService.GetById(orderId);

                var existing = _paymentService.GetAll()
                    .FirstOrDefault(p => p.Order.Id == orderId && p.Status == PaymentStatus.Completed);
                if (existing != null)
                    throw new Exception("This order already has a completed payment.");

                var payment = new Payment(order, amount, DateTime.Now, status);
                _paymentService.Create(payment);

                if (status == PaymentStatus.Refunded)
                {
                    var notification = new Notification(order.Customer,
                        $"A refund has been processed for order #{order.Id}.", DateTime.Now);
                    _notificationService.Create(notification);
                }

                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
