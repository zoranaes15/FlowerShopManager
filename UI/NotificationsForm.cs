using Application.Domain;
using Application.Service;
using Application.Service.Interfaces;
using System.Data;

namespace UI
{
    public partial class NotificationsForm : Form
    {
        private readonly User _user;
        private readonly INotificationService _notificationService;
        private List<Notification> _notifications = new();

        public NotificationsForm(User user)
        {
            InitializeComponent();
            _user = user;
            _notificationService = new NotificationService();
        }

        private void NotificationsForm_Load(object sender, EventArgs e)
        {
            LoadNotifications();
        }

        private void LoadNotifications()
        {
            try
            {
                _notifications = _notificationService.GetByReceiverId(_user.Id);
                int unread = _notifications.Count(n => !n.IsSeen);
                UnreadCountLabel.Text = $"Unread: {unread}";

                var dt = new DataTable();
                dt.Columns.Add("Id", typeof(int));
                dt.Columns.Add("Message", typeof(string));
                dt.Columns.Add("CreatedAt", typeof(DateTime));
                dt.Columns.Add("Seen", typeof(bool));

                foreach (var n in _notifications)
                    dt.Rows.Add(n.Id, n.Message, n.CreatedAt, n.IsSeen);

                notificationsGridView.DataSource = dt;
                notificationsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                notificationsGridView.RowHeadersVisible = false;
                notificationsGridView.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MarkAllAsReadButton_Click(object sender, EventArgs e)
        {
            try
            {
                _notificationService.MarkAllAsRead(_user.Id);
                LoadNotifications();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void notificationsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            try
            {
                int id = Convert.ToInt32(notificationsGridView.Rows[e.RowIndex].Cells["Id"].Value);
                var n = _notifications.FirstOrDefault(x => x.Id == id);
                if (n != null && !n.IsSeen)
                {
                    n.MarkAsSeen();
                    _notificationService.Update(n);
                    LoadNotifications();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
