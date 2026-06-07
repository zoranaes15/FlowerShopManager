namespace UI
{
    partial class OrdersForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            ordersGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ordersGridView).BeginInit();
            SuspendLayout();

            ordersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ordersGridView.Location = new Point(12, 12);
            ordersGridView.Name = "ordersGridView";
            ordersGridView.RowHeadersWidth = 51;
            ordersGridView.Size = new Size(700, 250);
            ordersGridView.TabIndex = 2;
            ordersGridView.CellContentClick += ordersGridView_CellContentClick;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 275);
            Controls.Add(ordersGridView);
            Name = "OrdersForm";
            Text = "Orders";
            Load += OrdersForm_Load;
            ((System.ComponentModel.ISupportInitialize)ordersGridView).EndInit();
            ResumeLayout(false);
        }

        private DataGridView ordersGridView;
    }
}
