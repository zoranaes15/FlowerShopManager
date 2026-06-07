namespace UI
{
    partial class AddPaymentForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            orderIdLabel = new Label();
            orderIdNumeric = new NumericUpDown();
            amountLabel = new Label();
            amountNumeric = new NumericUpDown();
            statusLabel = new Label();
            statusComboBox = new ComboBox();
            saveButton = new Button();
            cancelButton = new Button();
            ((System.ComponentModel.ISupportInitialize)orderIdNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)amountNumeric).BeginInit();
            SuspendLayout();

            orderIdLabel.AutoSize = true;
            orderIdLabel.Location = new System.Drawing.Point(20, 20);
            orderIdLabel.Text = "Order ID:";
            orderIdLabel.Name = "orderIdLabel";

            orderIdNumeric.Location = new System.Drawing.Point(120, 18);
            orderIdNumeric.Minimum = 1;
            orderIdNumeric.Maximum = 999999;
            orderIdNumeric.Size = new System.Drawing.Size(200, 27);
            orderIdNumeric.Name = "orderIdNumeric";

            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(20, 60);
            amountLabel.Text = "Amount:";
            amountLabel.Name = "amountLabel";

            amountNumeric.Location = new System.Drawing.Point(120, 58);
            amountNumeric.Minimum = 0;
            amountNumeric.Maximum = 999999;
            amountNumeric.DecimalPlaces = 2;
            amountNumeric.Size = new System.Drawing.Size(200, 27);
            amountNumeric.Name = "amountNumeric";

            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(20, 100);
            statusLabel.Text = "Status:";
            statusLabel.Name = "statusLabel";

            statusComboBox.Location = new System.Drawing.Point(120, 98);
            statusComboBox.Size = new System.Drawing.Size(200, 27);
            statusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            statusComboBox.Name = "statusComboBox";

            saveButton.Location = new System.Drawing.Point(120, 145);
            saveButton.Size = new System.Drawing.Size(90, 30);
            saveButton.Text = "Save";
            saveButton.Name = "saveButton";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += SaveButton_Click;

            cancelButton.Location = new System.Drawing.Point(230, 145);
            cancelButton.Size = new System.Drawing.Size(90, 30);
            cancelButton.Text = "Cancel";
            cancelButton.Name = "cancelButton";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += CancelButton_Click;

            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(360, 200);
            Controls.Add(orderIdLabel);
            Controls.Add(orderIdNumeric);
            Controls.Add(amountLabel);
            Controls.Add(amountNumeric);
            Controls.Add(statusLabel);
            Controls.Add(statusComboBox);
            Controls.Add(saveButton);
            Controls.Add(cancelButton);
            Name = "AddPaymentForm";
            Text = "Add Payment";
            ((System.ComponentModel.ISupportInitialize)orderIdNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)amountNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label orderIdLabel;
        private NumericUpDown orderIdNumeric;
        private Label amountLabel;
        private NumericUpDown amountNumeric;
        private Label statusLabel;
        private ComboBox statusComboBox;
        private Button saveButton;
        private Button cancelButton;
    }
}
