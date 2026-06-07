namespace UI
{
    partial class AdministratorForm
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
            logoutButton = new Button();
            label1 = new Label();
            NotificationButton = new Button();
            ReportButton = new Button();
            PaymentButton = new Button();
            UserButton = new Button();
            OrderButton = new Button();
            ProductsButton = new Button();
            DashboardButton = new Button();
            panel2 = new Panel();
            dataGridViewOrders = new DataGridView();
            groupBoxLowStock = new GroupBox();
            label4 = new Label();
            groupBoxActiveOrders = new GroupBox();
            label3 = new Label();
            groupBoxTotalRevenue = new GroupBox();
            label2 = new Label();
            BackupButton = new Button();
            RestoreButton = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            groupBoxLowStock.SuspendLayout();
            groupBoxActiveOrders.SuspendLayout();
            groupBoxTotalRevenue.SuspendLayout();
            SuspendLayout();

            panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            panel1.Controls.Add(logoutButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(NotificationButton);
            panel1.Controls.Add(ReportButton);
            panel1.Controls.Add(PaymentButton);
            panel1.Controls.Add(UserButton);
            panel1.Controls.Add(OrderButton);
            panel1.Controls.Add(ProductsButton);
            panel1.Controls.Add(DashboardButton);
            panel1.Location = new System.Drawing.Point(-2, -1);
            panel1.Size = new System.Drawing.Size(142, 430);
            panel1.Name = "panel1";

            logoutButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            logoutButton.Location = new System.Drawing.Point(12, 385);
            logoutButton.Size = new System.Drawing.Size(108, 32);
            logoutButton.Text = "Logout";
            logoutButton.Name = "logoutButton";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;

            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Sitka Small", 10.8F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(37, 0);
            label1.Text = "Menu";
            label1.Name = "label1";

            NotificationButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            NotificationButton.Location = new System.Drawing.Point(12, 301);
            NotificationButton.Size = new System.Drawing.Size(108, 32);
            NotificationButton.Text = "Notifications";
            NotificationButton.Name = "NotificationButton";
            NotificationButton.UseVisualStyleBackColor = true;
            NotificationButton.Click += NotificationButton_Click;

            ReportButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            ReportButton.Location = new System.Drawing.Point(12, 255);
            ReportButton.Size = new System.Drawing.Size(108, 32);
            ReportButton.Text = "Report";
            ReportButton.Name = "ReportButton";
            ReportButton.UseVisualStyleBackColor = true;
            ReportButton.Click += ReportButton_Click;

            PaymentButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            PaymentButton.Location = new System.Drawing.Point(12, 209);
            PaymentButton.Size = new System.Drawing.Size(108, 32);
            PaymentButton.Text = "Payment";
            PaymentButton.Name = "PaymentButton";
            PaymentButton.UseVisualStyleBackColor = true;
            PaymentButton.Click += PaymentButton_Click;

            UserButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            UserButton.Location = new System.Drawing.Point(12, 71);
            UserButton.Size = new System.Drawing.Size(108, 32);
            UserButton.Text = "Users";
            UserButton.Name = "UserButton";
            UserButton.UseVisualStyleBackColor = true;
            UserButton.Click += UserButton_Click;

            OrderButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            OrderButton.Location = new System.Drawing.Point(12, 164);
            OrderButton.Size = new System.Drawing.Size(108, 32);
            OrderButton.Text = "Orders";
            OrderButton.Name = "OrderButton";
            OrderButton.UseVisualStyleBackColor = true;
            OrderButton.Click += OrderButton_Click;

            ProductsButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            ProductsButton.Location = new System.Drawing.Point(12, 117);
            ProductsButton.Size = new System.Drawing.Size(108, 32);
            ProductsButton.Text = "Products";
            ProductsButton.Name = "ProductsButton";
            ProductsButton.UseVisualStyleBackColor = true;
            ProductsButton.Click += ProductsButton_Click_1;

            DashboardButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            DashboardButton.Location = new System.Drawing.Point(12, 26);
            DashboardButton.Size = new System.Drawing.Size(108, 32);
            DashboardButton.Text = "Dashboard";
            DashboardButton.Name = "DashboardButton";
            DashboardButton.UseVisualStyleBackColor = true;
            DashboardButton.Click += DashboardButton_Click;

            panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            panel2.Controls.Add(dataGridViewOrders);
            panel2.Controls.Add(groupBoxLowStock);
            panel2.Controls.Add(groupBoxActiveOrders);
            panel2.Controls.Add(groupBoxTotalRevenue);
            panel2.Controls.Add(BackupButton);
            panel2.Controls.Add(RestoreButton);
            panel2.Location = new System.Drawing.Point(153, 9);
            panel2.Size = new System.Drawing.Size(660, 420);
            panel2.Name = "panel2";

            dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrders.Location = new System.Drawing.Point(13, 145);
            dataGridViewOrders.Size = new System.Drawing.Size(630, 170);
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.RowHeadersWidth = 51;
            dataGridViewOrders.ReadOnly = true;

            groupBoxLowStock.Controls.Add(label4);
            groupBoxLowStock.Location = new System.Drawing.Point(433, 10);
            groupBoxLowStock.Size = new System.Drawing.Size(195, 98);
            groupBoxLowStock.Text = "Low Stock Products";
            groupBoxLowStock.Name = "groupBoxLowStock";

            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            label4.Location = new System.Drawing.Point(70, 44);
            label4.Text = "0";
            label4.Name = "label4";

            groupBoxActiveOrders.Controls.Add(label3);
            groupBoxActiveOrders.Location = new System.Drawing.Point(218, 10);
            groupBoxActiveOrders.Size = new System.Drawing.Size(200, 98);
            groupBoxActiveOrders.Text = "Active Orders";
            groupBoxActiveOrders.Name = "groupBoxActiveOrders";

            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            label3.Location = new System.Drawing.Point(66, 44);
            label3.Text = "0";
            label3.Name = "label3";

            groupBoxTotalRevenue.Controls.Add(label2);
            groupBoxTotalRevenue.Location = new System.Drawing.Point(13, 10);
            groupBoxTotalRevenue.Size = new System.Drawing.Size(190, 98);
            groupBoxTotalRevenue.Text = "Total Revenue";
            groupBoxTotalRevenue.Name = "groupBoxTotalRevenue";

            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            label2.Location = new System.Drawing.Point(45, 44);
            label2.Text = "$0.00";
            label2.Name = "label2";

            BackupButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            BackupButton.Location = new System.Drawing.Point(13, 330);
            BackupButton.Size = new System.Drawing.Size(150, 32);
            BackupButton.Text = "Backup Database";
            BackupButton.Name = "BackupButton";
            BackupButton.UseVisualStyleBackColor = true;
            BackupButton.Click += BackupButton_Click;

            RestoreButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            RestoreButton.Location = new System.Drawing.Point(180, 330);
            RestoreButton.Size = new System.Drawing.Size(150, 32);
            RestoreButton.Text = "Restore Database";
            RestoreButton.Name = "RestoreButton";
            RestoreButton.UseVisualStyleBackColor = true;
            RestoreButton.Click += RestoreButton_Click;

            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(824, 440);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdministratorForm";
            Text = "Administrator Panel";
            Load += AdministratorForm_Load;

            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            groupBoxLowStock.ResumeLayout(false);
            groupBoxLowStock.PerformLayout();
            groupBoxActiveOrders.ResumeLayout(false);
            groupBoxActiveOrders.PerformLayout();
            groupBoxTotalRevenue.ResumeLayout(false);
            groupBoxTotalRevenue.PerformLayout();
            ResumeLayout(false);
        }

        private Panel panel1;
        private Button DashboardButton;
        private Button UserButton;
        private Button ProductsButton;
        private Button OrderButton;
        private Button PaymentButton;
        private Button ReportButton;
        private Button NotificationButton;
        private Label label1;
        private Panel panel2;
        private GroupBox groupBoxTotalRevenue;
        private GroupBox groupBoxLowStock;
        private GroupBox groupBoxActiveOrders;
        private DataGridView dataGridViewOrders;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button logoutButton;
        private Button BackupButton;
        private Button RestoreButton;
    }
}
