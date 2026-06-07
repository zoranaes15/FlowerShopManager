namespace UI
{
    partial class PaymentForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            paymentsGridView = new DataGridView();
            addPaymentButton = new Button();
            ((System.ComponentModel.ISupportInitialize)paymentsGridView).BeginInit();
            SuspendLayout();

            paymentsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            paymentsGridView.Location = new System.Drawing.Point(12, 50);
            paymentsGridView.Size = new System.Drawing.Size(760, 320);
            paymentsGridView.Name = "paymentsGridView";
            paymentsGridView.RowHeadersWidth = 51;

            addPaymentButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            addPaymentButton.Location = new System.Drawing.Point(12, 10);
            addPaymentButton.Size = new System.Drawing.Size(130, 30);
            addPaymentButton.Text = "Add Payment";
            addPaymentButton.Name = "addPaymentButton";
            addPaymentButton.UseVisualStyleBackColor = true;
            addPaymentButton.Click += AddPaymentButton_Click;

            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(790, 385);
            Controls.Add(paymentsGridView);
            Controls.Add(addPaymentButton);
            Name = "PaymentForm";
            Text = "Payments";
            Load += PaymentForm_Load;
            ((System.ComponentModel.ISupportInitialize)paymentsGridView).EndInit();
            ResumeLayout(false);
        }

        private DataGridView paymentsGridView;
        private Button addPaymentButton;
    }
}
