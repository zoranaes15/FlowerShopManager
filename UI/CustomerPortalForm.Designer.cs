namespace UI
{
    partial class CustomerPortalForm
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
            LogoutButton = new Button();
            ProfileButton = new Button();
            NotificationsButton = new Button();
            PlaceOrderButton = new Button();
            OrderButton = new Button();
            ProductsButton = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();

            panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(LogoutButton);
            panel1.Controls.Add(ProfileButton);
            panel1.Controls.Add(NotificationsButton);
            panel1.Controls.Add(PlaceOrderButton);
            panel1.Controls.Add(OrderButton);
            panel1.Controls.Add(ProductsButton);
            panel1.Location = new System.Drawing.Point(2, 1);
            panel1.Size = new System.Drawing.Size(178, 390);
            panel1.Name = "panel1";

            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(50, 14);
            label1.Text = "Menu";
            label1.Name = "label1";

            ProductsButton.Location = new System.Drawing.Point(28, 50);
            ProductsButton.Size = new System.Drawing.Size(122, 39);
            ProductsButton.Text = "Products";
            ProductsButton.Name = "ProductsButton";
            ProductsButton.UseVisualStyleBackColor = true;
            ProductsButton.Click += ProductsButton_Click;

            OrderButton.Location = new System.Drawing.Point(28, 101);
            OrderButton.Size = new System.Drawing.Size(122, 39);
            OrderButton.Text = "My Orders";
            OrderButton.Name = "OrderButton";
            OrderButton.UseVisualStyleBackColor = true;
            OrderButton.Click += OrderButton_Click;

            PlaceOrderButton.Location = new System.Drawing.Point(28, 152);
            PlaceOrderButton.Size = new System.Drawing.Size(122, 39);
            PlaceOrderButton.Text = "Place Order";
            PlaceOrderButton.Name = "PlaceOrderButton";
            PlaceOrderButton.UseVisualStyleBackColor = true;
            PlaceOrderButton.Click += PlaceOrderButton_Click;

            NotificationsButton.Location = new System.Drawing.Point(28, 203);
            NotificationsButton.Size = new System.Drawing.Size(122, 39);
            NotificationsButton.Text = "Notifications";
            NotificationsButton.Name = "NotificationsButton";
            NotificationsButton.UseVisualStyleBackColor = true;
            NotificationsButton.Click += NotificationsButton_Click;

            ProfileButton.Location = new System.Drawing.Point(28, 254);
            ProfileButton.Size = new System.Drawing.Size(122, 39);
            ProfileButton.Text = "Profile";
            ProfileButton.Name = "ProfileButton";
            ProfileButton.UseVisualStyleBackColor = true;
            ProfileButton.Click += ProfileButton_Click;

            LogoutButton.Location = new System.Drawing.Point(28, 330);
            LogoutButton.Size = new System.Drawing.Size(122, 39);
            LogoutButton.Text = "Log Out";
            LogoutButton.Name = "LogoutButton";
            LogoutButton.UseVisualStyleBackColor = true;
            LogoutButton.Click += LogoutButton_Click;

            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(198, 109);
            dataGridView1.Size = new System.Drawing.Size(362, 141);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;

            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(580, 400);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "CustomerPortalForm";
            Text = "Customer Portal";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        private Panel panel1;
        private Button ProfileButton;
        private Button NotificationsButton;
        private Button PlaceOrderButton;
        private Button OrderButton;
        private Button ProductsButton;
        private Button LogoutButton;
        private Label label1;
        private DataGridView dataGridView1;
    }
}
