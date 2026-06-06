namespace UI
{
    partial class AdministratorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            DashboardButton = new Button();
            UserButton = new Button();
            ProductsButton = new Button();
            OrderButton = new Button();
            PaymentButton = new Button();
            ReportButton = new Button();
            NotificationButton = new Button();
            label1 = new Label();
            panel2 = new Panel();
            groupBoxTotalRevenue = new GroupBox();
            groupBoxActiveOrders = new GroupBox();
            groupBoxLowStock = new GroupBox();
            dataGridViewOrders = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBoxTotalRevenue.SuspendLayout();
            groupBoxActiveOrders.SuspendLayout();
            groupBoxLowStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(NotificationButton);
            panel1.Controls.Add(ReportButton);
            panel1.Controls.Add(PaymentButton);
            panel1.Controls.Add(UserButton);
            panel1.Controls.Add(OrderButton);
            panel1.Controls.Add(ProductsButton);
            panel1.Controls.Add(DashboardButton);
            panel1.Location = new Point(-2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(162, 470);
            panel1.TabIndex = 0;
            // 
            // DashboardButton
            // 
            DashboardButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            DashboardButton.Location = new Point(14, 34);
            DashboardButton.Name = "DashboardButton";
            DashboardButton.Size = new Size(123, 42);
            DashboardButton.TabIndex = 0;
            DashboardButton.Text = "Dashboard";
            DashboardButton.UseVisualStyleBackColor = true;
            // 
            // UserButton
            // 
            UserButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            UserButton.Location = new Point(14, 95);
            UserButton.Name = "UserButton";
            UserButton.Size = new Size(123, 42);
            UserButton.TabIndex = 1;
            UserButton.Text = "Users";
            UserButton.UseVisualStyleBackColor = true;
            // 
            // ProductsButton
            // 
            ProductsButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ProductsButton.Location = new Point(14, 156);
            ProductsButton.Name = "ProductsButton";
            ProductsButton.Size = new Size(123, 43);
            ProductsButton.TabIndex = 2;
            ProductsButton.Text = "Products";
            ProductsButton.UseVisualStyleBackColor = true;
            // 
            // OrderButton
            // 
            OrderButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            OrderButton.Location = new Point(14, 218);
            OrderButton.Name = "OrderButton";
            OrderButton.Size = new Size(123, 42);
            OrderButton.TabIndex = 3;
            OrderButton.Text = "Orders";
            OrderButton.UseVisualStyleBackColor = true;
            OrderButton.Click += OrderButton_Click;
            // 
            // PaymentButton
            // 
            PaymentButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            PaymentButton.Location = new Point(14, 279);
            PaymentButton.Name = "PaymentButton";
            PaymentButton.Size = new Size(123, 42);
            PaymentButton.TabIndex = 4;
            PaymentButton.Text = "Payment";
            PaymentButton.UseVisualStyleBackColor = true;
            PaymentButton.Click += PaymentButton_Click;
            // 
            // ReportButton
            // 
            ReportButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ReportButton.Location = new Point(14, 340);
            ReportButton.Name = "ReportButton";
            ReportButton.Size = new Size(123, 42);
            ReportButton.TabIndex = 5;
            ReportButton.Text = "Report";
            ReportButton.UseVisualStyleBackColor = true;
            // 
            // NotificationButton
            // 
            NotificationButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            NotificationButton.Location = new Point(14, 401);
            NotificationButton.Name = "NotificationButton";
            NotificationButton.Size = new Size(123, 42);
            NotificationButton.TabIndex = 6;
            NotificationButton.Text = "Notifications";
            NotificationButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 0);
            label1.Name = "label1";
            label1.Size = new Size(65, 26);
            label1.TabIndex = 7;
            label1.Text = "Menu";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(dataGridViewOrders);
            panel2.Controls.Add(groupBoxLowStock);
            panel2.Controls.Add(groupBoxActiveOrders);
            panel2.Controls.Add(groupBoxTotalRevenue);
            panel2.Location = new Point(175, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(743, 457);
            panel2.TabIndex = 1;
            // 
            // groupBoxTotalRevenue
            // 
            groupBoxTotalRevenue.Controls.Add(label2);
            groupBoxTotalRevenue.Location = new Point(15, 35);
            groupBoxTotalRevenue.Name = "groupBoxTotalRevenue";
            groupBoxTotalRevenue.Size = new Size(217, 131);
            groupBoxTotalRevenue.TabIndex = 0;
            groupBoxTotalRevenue.TabStop = false;
            groupBoxTotalRevenue.Text = "groupBox1";
            // 
            // groupBoxActiveOrders
            // 
            groupBoxActiveOrders.Controls.Add(label3);
            groupBoxActiveOrders.Location = new Point(249, 35);
            groupBoxActiveOrders.Name = "groupBoxActiveOrders";
            groupBoxActiveOrders.Size = new Size(229, 131);
            groupBoxActiveOrders.TabIndex = 1;
            groupBoxActiveOrders.TabStop = false;
            groupBoxActiveOrders.Text = "groupBox1";
            // 
            // groupBoxLowStock
            // 
            groupBoxLowStock.Controls.Add(label4);
            groupBoxLowStock.Location = new Point(495, 35);
            groupBoxLowStock.Name = "groupBoxLowStock";
            groupBoxLowStock.Size = new Size(223, 131);
            groupBoxLowStock.TabIndex = 2;
            groupBoxLowStock.TabStop = false;
            groupBoxLowStock.Text = "groupBox1";
            // 
            // dataGridViewOrders
            // 
            dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrders.Location = new Point(192, 242);
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.RowHeadersWidth = 51;
            dataGridViewOrders.Size = new Size(300, 188);
            dataGridViewOrders.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 58);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 0;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 58);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 0;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(80, 58);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 0;
            label4.Text = "label4";
            // 
            // AdministratorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 470);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdministratorForm";
            Text = "AdministratorForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            groupBoxTotalRevenue.ResumeLayout(false);
            groupBoxTotalRevenue.PerformLayout();
            groupBoxActiveOrders.ResumeLayout(false);
            groupBoxActiveOrders.PerformLayout();
            groupBoxLowStock.ResumeLayout(false);
            groupBoxLowStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            ResumeLayout(false);
        }

        #endregion

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
    }
}