namespace UI
{
    partial class NotificationsForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            UnreadCountLabel = new Label();
            markAllAsReadButton = new Button();
            notificationsGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)notificationsGridView).BeginInit();
            SuspendLayout();

            UnreadCountLabel.AutoSize = true;
            UnreadCountLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            UnreadCountLabel.Location = new System.Drawing.Point(12, 15);
            UnreadCountLabel.Text = "Unread: 0";
            UnreadCountLabel.Name = "UnreadCountLabel";

            markAllAsReadButton.Location = new System.Drawing.Point(300, 10);
            markAllAsReadButton.Size = new System.Drawing.Size(140, 30);
            markAllAsReadButton.Text = "Mark All as Read";
            markAllAsReadButton.Name = "markAllAsReadButton";
            markAllAsReadButton.UseVisualStyleBackColor = true;
            markAllAsReadButton.Click += MarkAllAsReadButton_Click;

            notificationsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            notificationsGridView.Location = new System.Drawing.Point(12, 55);
            notificationsGridView.Size = new System.Drawing.Size(560, 260);
            notificationsGridView.Name = "notificationsGridView";
            notificationsGridView.RowHeadersWidth = 51;
            notificationsGridView.CellClick += notificationsGridView_CellClick;

            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(590, 335);
            Controls.Add(UnreadCountLabel);
            Controls.Add(markAllAsReadButton);
            Controls.Add(notificationsGridView);
            Name = "NotificationsForm";
            Text = "Notifications";
            Load += NotificationsForm_Load;
            ((System.ComponentModel.ISupportInitialize)notificationsGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label UnreadCountLabel;
        private Button markAllAsReadButton;
        private DataGridView notificationsGridView;
    }
}
