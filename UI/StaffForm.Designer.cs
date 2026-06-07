namespace UI
{
    partial class StaffForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            ordersButton = new Button();
            paymentsButton = new Button();
            notificationsButton = new Button();
            logoutButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();

            panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(ordersButton);
            panel1.Controls.Add(paymentsButton);
            panel1.Controls.Add(notificationsButton);
            panel1.Controls.Add(logoutButton);
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Size = new System.Drawing.Size(160, 300);
            panel1.Name = "panel1";

            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(50, 10);
            label1.Text = "Staff Menu";
            label1.Name = "label1";

            ordersButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            ordersButton.Location = new System.Drawing.Point(26, 50);
            ordersButton.Size = new System.Drawing.Size(108, 32);
            ordersButton.Text = "Orders";
            ordersButton.Name = "ordersButton";
            ordersButton.UseVisualStyleBackColor = true;
            ordersButton.Click += OrdersButton_Click;

            paymentsButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            paymentsButton.Location = new System.Drawing.Point(26, 96);
            paymentsButton.Size = new System.Drawing.Size(108, 32);
            paymentsButton.Text = "Payments";
            paymentsButton.Name = "paymentsButton";
            paymentsButton.UseVisualStyleBackColor = true;
            paymentsButton.Click += PaymentsButton_Click;

            notificationsButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            notificationsButton.Location = new System.Drawing.Point(26, 142);
            notificationsButton.Size = new System.Drawing.Size(108, 32);
            notificationsButton.Text = "Notifications";
            notificationsButton.Name = "notificationsButton";
            notificationsButton.UseVisualStyleBackColor = true;
            notificationsButton.Click += NotificationsButton_Click;

            logoutButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            logoutButton.Location = new System.Drawing.Point(26, 240);
            logoutButton.Size = new System.Drawing.Size(108, 32);
            logoutButton.Text = "Logout";
            logoutButton.Name = "logoutButton";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += LogoutButton_Click;

            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(400, 300);
            Controls.Add(panel1);
            Name = "StaffForm";
            Text = "Staff Panel";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        private Panel panel1;
        private Label label1;
        private Button ordersButton;
        private Button paymentsButton;
        private Button notificationsButton;
        private Button logoutButton;
    }
}
