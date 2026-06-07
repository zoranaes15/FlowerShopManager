namespace UI
{
    partial class QuantityInputForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            promptLabel = new Label();
            quantityNumeric = new NumericUpDown();
            okButton = new Button();
            cancelButton = new Button();
            ((System.ComponentModel.ISupportInitialize)quantityNumeric).BeginInit();
            SuspendLayout();

            promptLabel.AutoSize = true;
            promptLabel.Location = new System.Drawing.Point(12, 15);
            promptLabel.Size = new System.Drawing.Size(300, 15);
            promptLabel.Name = "promptLabel";
            promptLabel.Text = "Enter quantity:";

            quantityNumeric.Location = new System.Drawing.Point(12, 40);
            quantityNumeric.Minimum = 1;
            quantityNumeric.Maximum = 9999;
            quantityNumeric.Value = 1;
            quantityNumeric.Size = new System.Drawing.Size(120, 27);
            quantityNumeric.Name = "quantityNumeric";

            okButton.Location = new System.Drawing.Point(12, 80);
            okButton.Size = new System.Drawing.Size(80, 30);
            okButton.Text = "OK";
            okButton.Name = "okButton";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += OkButton_Click;

            cancelButton.Location = new System.Drawing.Point(110, 80);
            cancelButton.Size = new System.Drawing.Size(80, 30);
            cancelButton.Text = "Cancel";
            cancelButton.Name = "cancelButton";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += CancelButton_Click;

            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(320, 130);
            Controls.Add(promptLabel);
            Controls.Add(quantityNumeric);
            Controls.Add(okButton);
            Controls.Add(cancelButton);
            Name = "QuantityInputForm";
            Text = "Add to Basket";
            ((System.ComponentModel.ISupportInitialize)quantityNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label promptLabel;
        private NumericUpDown quantityNumeric;
        private Button okButton;
        private Button cancelButton;
    }
}
