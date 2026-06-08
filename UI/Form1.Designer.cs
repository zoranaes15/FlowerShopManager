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
            LoginButton = new Button();
            Registerbutton = new Button();
            label3 = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.5F);
            label1.Location = new Point(34, 113);
            label1.Name = "label1";
            label1.Size = new Size(51, 21);
            label1.TabIndex = 1;
            label1.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.5F);
            label2.Location = new Point(34, 167);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            // 
            // UsernametextBox1
            // 
            UsernametextBox1.Location = new Point(137, 109);
            UsernametextBox1.Margin = new Padding(3, 4, 3, 4);
            UsernametextBox1.Name = "UsernametextBox1";
            UsernametextBox1.Size = new Size(194, 27);
            UsernametextBox1.TabIndex = 3;
            // 
            // PasswordtextBox2
            // 
            PasswordtextBox2.Location = new Point(137, 163);
            PasswordtextBox2.Margin = new Padding(3, 4, 3, 4);
            PasswordtextBox2.Name = "PasswordtextBox2";
            PasswordtextBox2.Size = new Size(194, 27);
            PasswordtextBox2.TabIndex = 4;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = SystemColors.ActiveCaption;
            LoginButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LoginButton.ForeColor = Color.Black;
            LoginButton.Location = new Point(34, 260);
            LoginButton.Margin = new Padding(3, 4, 3, 4);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(137, 48);
            LoginButton.TabIndex = 7;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // Registerbutton
            // 
            Registerbutton.BackColor = SystemColors.ActiveCaption;
            Registerbutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Registerbutton.ForeColor = SystemColors.Desktop;
            Registerbutton.Location = new Point(194, 260);
            Registerbutton.Margin = new Padding(3, 4, 3, 4);
            Registerbutton.Name = "Registerbutton";
            Registerbutton.Size = new Size(137, 48);
            Registerbutton.TabIndex = 9;
            Registerbutton.Text = "Register";
            Registerbutton.UseVisualStyleBackColor = false;
            Registerbutton.Click += Registerbutton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(69, 40);
            label3.Name = "label3";
            label3.Size = new Size(119, 32);
            label3.TabIndex = 10;
            label3.Text = "Welcome";
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Screenshot_4;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(369, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(319, 373);
            panel1.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 373);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(Registerbutton);
            Controls.Add(label2);
            Controls.Add(LoginButton);
            Controls.Add(UsernametextBox1);
            Controls.Add(PasswordtextBox2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UsernametextBox1;
        private System.Windows.Forms.TextBox PasswordtextBox2;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button Registerbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}
