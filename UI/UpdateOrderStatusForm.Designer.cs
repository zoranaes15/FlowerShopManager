namespace UI
{
    partial class UpdateOrderStatusForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            statusLabel = new Label();
            statusComboBox = new ComboBox();
            saveButton = new Button();
            cancelButton = new Button();
            SuspendLayout();

            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(20, 25);
            statusLabel.Text = "New Status:";
            statusLabel.Name = "statusLabel";

            statusComboBox.Location = new System.Drawing.Point(110, 22);
            statusComboBox.Size = new System.Drawing.Size(200, 27);
            statusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            statusComboBox.Name = "statusComboBox";

            saveButton.Location = new System.Drawing.Point(110, 70);
            saveButton.Size = new System.Drawing.Size(90, 30);
            saveButton.Text = "Save";
            saveButton.Name = "saveButton";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += SaveButton_Click;

            cancelButton.Location = new System.Drawing.Point(220, 70);
            cancelButton.Size = new System.Drawing.Size(90, 30);
            cancelButton.Text = "Cancel";
            cancelButton.Name = "cancelButton";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += CancelButton_Click;

            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(340, 130);
            Controls.Add(statusLabel);
            Controls.Add(statusComboBox);
            Controls.Add(saveButton);
            Controls.Add(cancelButton);
            Name = "UpdateOrderStatusForm";
            Text = "Update Order Status";
            Load += UpdateOrderStatusForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label statusLabel;
        private ComboBox statusComboBox;
        private Button saveButton;
        private Button cancelButton;
    }
}
