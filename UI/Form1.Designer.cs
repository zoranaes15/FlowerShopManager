namespace UI
{
    partial class Form1
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
            UsernametextBox1 = new TextBox();
            PasswordtextBox2 = new TextBox();
            checkBox1 = new CheckBox();
            LoginButton = new Button();
            Registerbutton = new Button();
            label3 = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Lucida Fax", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 95);
            label1.Name = "label1";
            label1.Size = new Size(129, 39);
            label1.TabIndex = 1;
            label1.Text = "Username\r\n\r\n";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Fax", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 160);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 2;
            label2.Text = "Password :";
            // 
            // UsernametextBox1
            // 
            UsernametextBox1.Location = new Point(147, 94);
            UsernametextBox1.Margin = new Padding(3, 4, 3, 4);
            UsernametextBox1.Name = "UsernametextBox1";
            UsernametextBox1.Size = new Size(176, 27);
            UsernametextBox1.TabIndex = 3;
            // 
            // PasswordtextBox2
            // 
            PasswordtextBox2.Location = new Point(147, 160);
            PasswordtextBox2.Margin = new Padding(3, 4, 3, 4);
            PasswordtextBox2.Name = "PasswordtextBox2";
            PasswordtextBox2.Size = new Size(176, 27);
            PasswordtextBox2.TabIndex = 4;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Location = new Point(201, 195);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(132, 24);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "show password";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = SystemColors.ActiveCaption;
            LoginButton.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginButton.ForeColor = Color.Black;
            LoginButton.Location = new Point(32, 268);
            LoginButton.Margin = new Padding(3, 4, 3, 4);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(125, 86);
            LoginButton.TabIndex = 7;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // Registerbutton
            // 
            Registerbutton.BackColor = SystemColors.ActiveCaption;
            Registerbutton.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Registerbutton.ForeColor = SystemColors.Desktop;
            Registerbutton.Location = new Point(199, 268);
            Registerbutton.Margin = new Padding(3, 4, 3, 4);
            Registerbutton.Name = "Registerbutton";
            Registerbutton.Size = new Size(124, 86);
            Registerbutton.TabIndex = 9;
            Registerbutton.Text = "Register";
            Registerbutton.UseVisualStyleBackColor = false;
            Registerbutton.Click += Registerbutton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Myanmar Text", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(109, 24);
            label3.Name = "label3";
            label3.Size = new Size(118, 41);
            label3.TabIndex = 10;
            label3.Text = "Welcome";
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Screenshot_4;
            panel1.Location = new Point(369, -1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(318, 441);
            panel1.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 438);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(Registerbutton);
            Controls.Add(label2);
            Controls.Add(checkBox1);
            Controls.Add(LoginButton);
            Controls.Add(UsernametextBox1);
            Controls.Add(PasswordtextBox2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
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

