namespace UI
{
    partial class AddProductForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            nameTextbox = new TextBox();
            DescriptionTextBox = new TextBox();
            label2 = new Label();
            stockNumericUpDown = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            priceNumericUpDown = new NumericUpDown();
            cancelButton = new Button();
            addButton = new Button();
            ((System.ComponentModel.ISupportInitialize)stockNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)priceNumericUpDown).BeginInit();
            SuspendLayout();

            int labelX = 30;
            int inputX = 140;
            int inputW = 200;
            int rowH = 40;
            int startY = 25;

            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(labelX, startY + 5);
            label1.Name = "label1";
            label1.TabIndex = 0;
            label1.Text = "Name:";

            nameTextbox.Location = new Point(inputX, startY);
            nameTextbox.Name = "nameTextbox";
            nameTextbox.Size = new Size(inputW, 24);
            nameTextbox.TabIndex = 1;

            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(labelX, startY + rowH + 5);
            label2.Name = "label2";
            label2.TabIndex = 2;
            label2.Text = "Description:";

            DescriptionTextBox.Location = new Point(inputX, startY + rowH);
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(inputW, 24);
            DescriptionTextBox.TabIndex = 3;

            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(labelX, startY + rowH * 2 + 5);
            label3.Name = "label3";
            label3.TabIndex = 5;
            label3.Text = "Stock:";

            stockNumericUpDown.Location = new Point(inputX, startY + rowH * 2);
            stockNumericUpDown.Name = "stockNumericUpDown";
            stockNumericUpDown.Size = new Size(inputW, 24);
            stockNumericUpDown.TabIndex = 4;

            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(labelX, startY + rowH * 3 + 5);
            label4.Name = "label4";
            label4.TabIndex = 7;
            label4.Text = "Price:";

            priceNumericUpDown.Location = new Point(inputX, startY + rowH * 3);
            priceNumericUpDown.Name = "priceNumericUpDown";
            priceNumericUpDown.Size = new Size(inputW, 24);
            priceNumericUpDown.TabIndex = 6;

            int btnY = startY + rowH * 4 + 15;
            cancelButton.Location = new Point(labelX, btnY);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(90, 30);
            cancelButton.TabIndex = 8;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;

            addButton.Location = new Point(inputX, btnY);
            addButton.Name = "addButton";
            addButton.Size = new Size(90, 30);
            addButton.TabIndex = 9;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, btnY + 55);
            Controls.Add(addButton);
            Controls.Add(cancelButton);
            Controls.Add(label4);
            Controls.Add(priceNumericUpDown);
            Controls.Add(label3);
            Controls.Add(stockNumericUpDown);
            Controls.Add(DescriptionTextBox);
            Controls.Add(label2);
            Controls.Add(nameTextbox);
            Controls.Add(label1);
            Name = "AddProductForm";
            Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize)stockNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)priceNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private TextBox nameTextbox;
        private TextBox DescriptionTextBox;
        private Label label2;
        private NumericUpDown stockNumericUpDown;
        private Label label3;
        private Label label4;
        private NumericUpDown priceNumericUpDown;
        private Button cancelButton;
        private Button addButton;
    }
}
