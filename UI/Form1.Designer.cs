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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UsernametextBox1 = new System.Windows.Forms.TextBox();
            this.PasswordtextBox2 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.Registerbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username\r\n\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password :";
            // 
            // UsernametextBox1
            // 
            this.UsernametextBox1.Location = new System.Drawing.Point(147, 75);
            this.UsernametextBox1.Name = "UsernametextBox1";
            this.UsernametextBox1.Size = new System.Drawing.Size(176, 22);
            this.UsernametextBox1.TabIndex = 3;
            // 
            // PasswordtextBox2
            // 
            this.PasswordtextBox2.Location = new System.Drawing.Point(147, 128);
            this.PasswordtextBox2.Name = "PasswordtextBox2";
            this.PasswordtextBox2.Size = new System.Drawing.Size(176, 22);
            this.PasswordtextBox2.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Location = new System.Drawing.Point(201, 156);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(122, 20);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "show password";
            this.checkBox1.UseVisualStyleBackColor = false;
            
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.Black;
            this.LoginButton.Location = new System.Drawing.Point(32, 214);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(125, 69);
            this.LoginButton.TabIndex = 7;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // Registerbutton
            // 
            this.Registerbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Registerbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registerbutton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Registerbutton.Location = new System.Drawing.Point(199, 214);
            this.Registerbutton.Name = "Registerbutton";
            this.Registerbutton.Size = new System.Drawing.Size(124, 69);
            this.Registerbutton.TabIndex = 9;
            this.Registerbutton.Text = "Register";
            this.Registerbutton.UseVisualStyleBackColor = false;
            this.Registerbutton.Click += new System.EventHandler(this.Registerbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(109, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 41);
            this.label3.TabIndex = 10;
            this.label3.Text = "Welcome";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::UI.Properties.Resources.Screenshot_4;
            this.panel1.Location = new System.Drawing.Point(369, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 353);
            this.panel1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 350);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Registerbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.UsernametextBox1);
            this.Controls.Add(this.PasswordtextBox2);
            this.Name = "Form1";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

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

