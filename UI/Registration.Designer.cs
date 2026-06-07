namespace UI
{
    partial class RegistrationForm
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            FirstNameTextBox = new TextBox();
            LastNameTextBox = new TextBox();
            EmailTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            ConfirmPasswordTextBox = new TextBox();
            RegisterButton = new Button();
            comboBox1 = new ComboBox();
            CancelButton = new Button();
            SuspendLayout();

            int labelX = 30;
            int inputX = 160;
            int inputW = 210;
            int rowH = 42;
            int startY = 75;

            // Title
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(130, 20);
            label1.Name = "label1";
            label1.TabIndex = 0;
            label1.Text = "Register";

            // Row 1 - First Name
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(labelX, startY + 5);
            label2.Name = "label2";
            label2.TabIndex = 1;
            label2.Text = "First Name";

            FirstNameTextBox.Font = new Font("Segoe UI", 9F);
            FirstNameTextBox.Location = new Point(inputX, startY);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(inputW, 24);
            FirstNameTextBox.TabIndex = 7;

            // Row 2 - Last Name
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(labelX, startY + rowH + 5);
            label4.Name = "label4";
            label4.TabIndex = 3;
            label4.Text = "Last Name";

            LastNameTextBox.Font = new Font("Segoe UI", 9F);
            LastNameTextBox.Location = new Point(inputX, startY + rowH);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(inputW, 24);
            LastNameTextBox.TabIndex = 8;

            // Row 3 - Email
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(labelX, startY + rowH * 2 + 5);
            label3.Name = "label3";
            label3.TabIndex = 2;
            label3.Text = "Email";

            EmailTextBox.Font = new Font("Segoe UI", 9F);
            EmailTextBox.Location = new Point(inputX, startY + rowH * 2);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(inputW, 24);
            EmailTextBox.TabIndex = 9;

            // Row 4 - Password
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(labelX, startY + rowH * 3 + 5);
            label5.Name = "label5";
            label5.TabIndex = 4;
            label5.Text = "Password";

            PasswordTextBox.Font = new Font("Segoe UI", 9F);
            PasswordTextBox.Location = new Point(inputX, startY + rowH * 3);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(inputW, 24);
            PasswordTextBox.TabIndex = 10;

            // Row 5 - Confirm Password
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(labelX, startY + rowH * 4 + 5);
            label6.Name = "label6";
            label6.TabIndex = 5;
            label6.Text = "Confirm Password";

            ConfirmPasswordTextBox.Font = new Font("Segoe UI", 9F);
            ConfirmPasswordTextBox.Location = new Point(inputX, startY + rowH * 4);
            ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            ConfirmPasswordTextBox.Size = new Size(inputW, 24);
            ConfirmPasswordTextBox.TabIndex = 11;

            // Row 6 - Role
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F);
            label7.Location = new Point(labelX, startY + rowH * 5 + 5);
            label7.Name = "label7";
            label7.TabIndex = 6;
            label7.Text = "Role";

            comboBox1.Font = new Font("Segoe UI", 9F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(inputX, startY + rowH * 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(inputW, 24);
            comboBox1.TabIndex = 14;

            // Buttons
            int btnY = startY + rowH * 6 + 15;
            RegisterButton.BackColor = SystemColors.ActiveCaption;
            RegisterButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            RegisterButton.ForeColor = SystemColors.ActiveCaptionText;
            RegisterButton.Location = new Point(60, btnY);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(130, 36);
            RegisterButton.TabIndex = 13;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = false;
            RegisterButton.Click += RegisterButton_Click;

            CancelButton.Font = new Font("Segoe UI", 9F);
            CancelButton.Location = new Point(210, btnY);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(130, 36);
            CancelButton.TabIndex = 15;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(400, btnY + 65);
            Controls.Add(CancelButton);
            Controls.Add(comboBox1);
            Controls.Add(RegisterButton);
            Controls.Add(ConfirmPasswordTextBox);
            Controls.Add(PasswordTextBox);
            Controls.Add(EmailTextBox);
            Controls.Add(LastNameTextBox);
            Controls.Add(FirstNameTextBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegistrationForm";
            Text = "Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox ConfirmPasswordTextBox;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button CancelButton;
    }
}
