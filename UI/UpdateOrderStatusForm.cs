using Application.Domain;
using Application.Service;
using Application.Service.Interfaces;

namespace UI
{
    public partial class UpdateOrderStatusForm : Form
    {
        private readonly Order _order;
        private readonly IOrderService _orderService;
        private readonly INotificationService _notificationService;

        public UpdateOrderStatusForm(Order order)
        {
            InitializeComponent();
            _order = order;
            _orderService = new OrderService();
            _notificationService = new NotificationService();
        }

        private void UpdateOrderStatusForm_Load(object sender, EventArgs e)
        {
            statusComboBox.DataSource = Enum.GetValues(typeof(OrderStatus));
            statusComboBox.SelectedItem = _order.Status;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                OrderStatus newStatus = (OrderStatus)statusComboBox.SelectedItem!;
                _order.UpdateStatus(newStatus);
                _orderService.Update(_order);

                if (newStatus == OrderStatus.Completed || newStatus == OrderStatus.Cancelled)
                {
                    string msg = newStatus == OrderStatus.Completed
                        ? $"Your order #{_order.Id} has been completed."
                        : $"Your order #{_order.Id} has been cancelled.";
                    var notification = new Notification(_order.Customer, msg, DateTime.Now);
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
