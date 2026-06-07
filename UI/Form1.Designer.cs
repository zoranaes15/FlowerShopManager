namespace UI
{
    partial class Form1
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
            UsernametextBox1 = new TextBox();
            PasswordtextBox2 = new TextBox();
            checkBox1 = new CheckBox();
            LoginButton = new Button();
            Registerbutton = new Button();
            label3 = new Label();
            panel1 = new Panel();
            SuspendLayout();

            // label3 - Welcome title
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(60, 30);
            label3.Name = "label3";
            label3.TabIndex = 10;
            label3.Text = "Welcome";

            // label1 - Email
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.5F);
            label1.Location = new Point(30, 85);
            label1.Name = "label1";
            label1.TabIndex = 1;
            label1.Text = "Email:";

            // UsernametextBox1
            UsernametextBox1.Location = new Point(120, 82);
            UsernametextBox1.Name = "UsernametextBox1";
            UsernametextBox1.Size = new Size(170, 24);
            UsernametextBox1.TabIndex = 3;

            // label2 - Password
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.5F);
            label2.Location = new Point(30, 125);
            label2.Name = "label2";
            label2.TabIndex = 2;
            label2.Text = "Password:";

            // PasswordtextBox2
            PasswordtextBox2.Location = new Point(120, 122);
            PasswordtextBox2.Name = "PasswordtextBox2";
            PasswordtextBox2.Size = new Size(170, 24);
            PasswordtextBox2.TabIndex = 4;

            // checkBox1
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Location = new Point(120, 155);
            checkBox1.Name = "checkBox1";
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Show password";
            checkBox1.UseVisualStyleBackColor = false;

            // LoginButton
            LoginButton.BackColor = SystemColors.ActiveCaption;
            LoginButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LoginButton.ForeColor = Color.Black;
            LoginButton.Location = new Point(30, 195);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(120, 36);
            LoginButton.TabIndex = 7;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;

            // Registerbutton
            Registerbutton.BackColor = SystemColors.ActiveCaption;
            Registerbutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Registerbutton.ForeColor = SystemColors.Desktop;
            Registerbutton.Location = new Point(170, 195);
            Registerbutton.Name = "Registerbutton";
            Registerbutton.Size = new Size(120, 36);
            Registerbutton.TabIndex = 9;
            Registerbutton.Text = "Register";
            Registerbutton.UseVisualStyleBackColor = false;
            Registerbutton.Click += Registerbutton_Click;

            // panel1 - image
            panel1.BackgroundImage = Properties.Resources.Screenshot_4;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(323, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(279, 280);
            panel1.TabIndex = 11;

            // Form1
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 280);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(Registerbutton);
            Controls.Add(label2);
            Controls.Add(checkBox1);
            Controls.Add(LoginButton);
            Controls.Add(UsernametextBox1);
            Controls.Add(PasswordtextBox2);
            Name = "Form1";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UsernametextBox1;
        private System.Windows.Forms.TextBox PasswordtextBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button Registerbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}
