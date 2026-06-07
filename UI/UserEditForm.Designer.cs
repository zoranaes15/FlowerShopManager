namespace UI
{
    partial class UserEditForm
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
            SaveButton = new Button();
            CancelButton = new Button();
            FirstNameTextBox = new TextBox();
            LastNameTextBox = new TextBox();
            EmailTextBox = new TextBox();
            SuspendLayout();

            int labelX = 30;
            int inputX = 140;
            int inputW = 180;
            int rowH = 40;
            int startY = 25;

            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(labelX, startY + 5);
            label1.Name = "label1";
            label1.TabIndex = 0;
            label1.Text = "First Name";

            FirstNameTextBox.Location = new Point(inputX, startY);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(inputW, 24);
            FirstNameTextBox.TabIndex = 7;

            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(labelX, startY + rowH + 5);
            label2.Name = "label2";
            label2.TabIndex = 1;
            label2.Text = "Last Name";

            LastNameTextBox.Location = new Point(inputX, startY + rowH);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(inputW, 24);
            LastNameTextBox.TabIndex = 8;

            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(labelX, startY + rowH * 2 + 5);
            label3.Name = "label3";
            label3.TabIndex = 2;
            label3.Text = "Email";

            EmailTextBox.Location = new Point(inputX, startY + rowH * 2);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(inputW, 24);
            EmailTextBox.TabIndex = 9;

            int btnY = startY + rowH * 3 + 20;
            SaveButton.BackColor = SystemColors.ActiveCaption;
            SaveButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            SaveButton.Location = new Point(labelX, btnY);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(120, 32);
            SaveButton.TabIndex = 5;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;

            CancelButton.Font = new Font("Segoe UI", 9F);
            CancelButton.Location = new Point(inputX, btnY);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(120, 32);
            CancelButton.TabIndex = 6;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, btnY + 60);
            Controls.Add(EmailTextBox);
            Controls.Add(LastNameTextBox);
            Controls.Add(FirstNameTextBox);
            Controls.Add(CancelButton);
            Controls.Add(SaveButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserEditForm";
            Text = "Edit User";
            Load += UserEditForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Label label3;
        private Button SaveButton;
        private Button CancelButton;
        private TextBox FirstNameTextBox;
        private TextBox LastNameTextBox;
        private TextBox EmailTextBox;
    }
}
