namespace UI
{
    partial class UserEditForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SaveButton = new Button();
            CancelButton = new Button();
            NametextBox = new TextBox();
            LastNametextBox = new TextBox();
            EmailtextBox = new TextBox();
            PasswordtextBox = new TextBox();
            RolcomboBox = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 38);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 89);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 135);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 185);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 238);
            label5.Name = "label5";
            label5.Size = new Size(31, 20);
            label5.TabIndex = 4;
            label5.Text = "Rol";
            // 
            // SaveButton
            // 
            SaveButton.BackColor = SystemColors.ActiveCaption;
            SaveButton.Location = new Point(24, 296);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(126, 57);
            SaveButton.TabIndex = 5;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(191, 296);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(126, 57);
            CancelButton.TabIndex = 6;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            // 
            // NametextBox
            // 
            NametextBox.Location = new Point(169, 45);
            NametextBox.Name = "NametextBox";
            NametextBox.Size = new Size(148, 27);
            NametextBox.TabIndex = 7;
            // 
            // LastNametextBox
            // 
            LastNametextBox.Location = new Point(169, 89);
            LastNametextBox.Name = "LastNametextBox";
            LastNametextBox.Size = new Size(148, 27);
            LastNametextBox.TabIndex = 8;
            // 
            // EmailtextBox
            // 
            EmailtextBox.Location = new Point(169, 135);
            EmailtextBox.Name = "EmailtextBox";
            EmailtextBox.Size = new Size(148, 27);
            EmailtextBox.TabIndex = 9;
            // 
            // PasswordtextBox
            // 
            PasswordtextBox.Location = new Point(169, 185);
            PasswordtextBox.Name = "PasswordtextBox";
            PasswordtextBox.Size = new Size(148, 27);
            PasswordtextBox.TabIndex = 10;
            // 
            // RolcomboBox
            // 
            RolcomboBox.FormattingEnabled = true;
            RolcomboBox.Location = new Point(169, 238);
            RolcomboBox.Name = "RolcomboBox";
            RolcomboBox.Size = new Size(148, 28);
            RolcomboBox.TabIndex = 11;
            RolcomboBox.Text = "Rol";
            // 
            // UserEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 390);
            Controls.Add(RolcomboBox);
            Controls.Add(PasswordtextBox);
            Controls.Add(EmailtextBox);
            Controls.Add(LastNametextBox);
            Controls.Add(NametextBox);
            Controls.Add(CancelButton);
            Controls.Add(SaveButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserEditForm";
            Text = "UserEditForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button SaveButton;
        private Button CancelButton;
        private TextBox NametextBox;
        private TextBox LastNametextBox;
        private TextBox EmailtextBox;
        private TextBox PasswordtextBox;
        private ComboBox RolcomboBox;
    }
}