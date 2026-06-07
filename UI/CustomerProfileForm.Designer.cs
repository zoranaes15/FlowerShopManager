namespace UI
{
    partial class CustomerProfileForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            // Info labels
            infoGroupBox = new GroupBox();
            firstNameInfoLabel = new Label();
            firstNameLabel = new Label();
            lastNameInfoLabel = new Label();
            lastNameLabel = new Label();
            emailInfoLabel = new Label();
            emailLabel = new Label();
            createdAtInfoLabel = new Label();
            createdAtLabel = new Label();

            // Edit section
            editGroupBox = new GroupBox();
            firstNameEditLabel = new Label();
            firstNameTextBox = new TextBox();
            lastNameEditLabel = new Label();
            lastNameTextBox = new TextBox();
            saveProfileButton = new Button();

            // Password section
            passwordGroupBox = new GroupBox();
            currentPasswordLabel = new Label();
            currentPasswordTextBox = new TextBox();
            newPasswordLabel = new Label();
            newPasswordTextBox = new TextBox();
            confirmPasswordLabel = new Label();
            confirmPasswordTextBox = new TextBox();
            changePasswordButton = new Button();

            infoGroupBox.SuspendLayout();
            editGroupBox.SuspendLayout();
            passwordGroupBox.SuspendLayout();
            SuspendLayout();

            // infoGroupBox
            infoGroupBox.Text = "Profile Info";
            infoGroupBox.Location = new System.Drawing.Point(12, 12);
            infoGroupBox.Size = new System.Drawing.Size(400, 140);
            infoGroupBox.Name = "infoGroupBox";
            infoGroupBox.Controls.AddRange(new Control[] { firstNameInfoLabel, firstNameLabel, lastNameInfoLabel, lastNameLabel, emailInfoLabel, emailLabel, createdAtInfoLabel, createdAtLabel });

            SetLabelPair(firstNameInfoLabel, "First Name:", firstNameLabel, 20);
            SetLabelPair(lastNameInfoLabel, "Last Name:", lastNameLabel, 50);
            SetLabelPair(emailInfoLabel, "Email:", emailLabel, 80);
            SetLabelPair(createdAtInfoLabel, "Member Since:", createdAtLabel, 110);

            // editGroupBox
            editGroupBox.Text = "Edit Profile";
            editGroupBox.Location = new System.Drawing.Point(12, 165);
            editGroupBox.Size = new System.Drawing.Size(400, 120);
            editGroupBox.Name = "editGroupBox";
            editGroupBox.Controls.AddRange(new Control[] { firstNameEditLabel, firstNameTextBox, lastNameEditLabel, lastNameTextBox, saveProfileButton });

            firstNameEditLabel.AutoSize = true;
            firstNameEditLabel.Location = new System.Drawing.Point(10, 28);
            firstNameEditLabel.Text = "First Name:";
            firstNameTextBox.Location = new System.Drawing.Point(100, 25);
            firstNameTextBox.Size = new System.Drawing.Size(200, 27);
            firstNameTextBox.Name = "firstNameTextBox";

            lastNameEditLabel.AutoSize = true;
            lastNameEditLabel.Location = new System.Drawing.Point(10, 65);
            lastNameEditLabel.Text = "Last Name:";
            lastNameTextBox.Location = new System.Drawing.Point(100, 62);
            lastNameTextBox.Size = new System.Drawing.Size(200, 27);
            lastNameTextBox.Name = "lastNameTextBox";

            saveProfileButton.Location = new System.Drawing.Point(310, 62);
            saveProfileButton.Size = new System.Drawing.Size(80, 30);
            saveProfileButton.Text = "Save";
            saveProfileButton.Name = "saveProfileButton";
            saveProfileButton.UseVisualStyleBackColor = true;
            saveProfileButton.Click += SaveProfileButton_Click;

            // passwordGroupBox
            passwordGroupBox.Text = "Change Password";
            passwordGroupBox.Location = new System.Drawing.Point(12, 300);
            passwordGroupBox.Size = new System.Drawing.Size(400, 160);
            passwordGroupBox.Name = "passwordGroupBox";
            passwordGroupBox.Controls.AddRange(new Control[] { currentPasswordLabel, currentPasswordTextBox, newPasswordLabel, newPasswordTextBox, confirmPasswordLabel, confirmPasswordTextBox, changePasswordButton });

            SetPasswordField(currentPasswordLabel, "Current:", currentPasswordTextBox, 25);
            SetPasswordField(newPasswordLabel, "New:", newPasswordTextBox, 62);
            SetPasswordField(confirmPasswordLabel, "Confirm:", confirmPasswordTextBox, 99);

            changePasswordButton.Location = new System.Drawing.Point(310, 99);
            changePasswordButton.Size = new System.Drawing.Size(80, 30);
            changePasswordButton.Text = "Change";
            changePasswordButton.Name = "changePasswordButton";
            changePasswordButton.UseVisualStyleBackColor = true;
            changePasswordButton.Click += ChangePasswordButton_Click;

            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(430, 480);
            Controls.Add(infoGroupBox);
            Controls.Add(editGroupBox);
            Controls.Add(passwordGroupBox);
            Name = "CustomerProfileForm";
            Text = "My Profile";
            Load += CustomerProfileForm_Load;

            infoGroupBox.ResumeLayout(false);
            infoGroupBox.PerformLayout();
            editGroupBox.ResumeLayout(false);
            editGroupBox.PerformLayout();
            passwordGroupBox.ResumeLayout(false);
            passwordGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        private void SetLabelPair(Label infoLbl, string text, Label valueLbl, int y)
        {
            infoLbl.AutoSize = true;
            infoLbl.Location = new System.Drawing.Point(10, y);
            infoLbl.Text = text;
            infoLbl.Name = infoLbl.GetHashCode().ToString();
            valueLbl.AutoSize = true;
            valueLbl.Location = new System.Drawing.Point(130, y);
            valueLbl.Text = "";
            valueLbl.Name = valueLbl.GetHashCode().ToString();
        }

        private void SetPasswordField(Label lbl, string text, TextBox tb, int y)
        {
            lbl.AutoSize = true;
            lbl.Location = new System.Drawing.Point(10, y + 3);
            lbl.Text = text;
            tb.Location = new System.Drawing.Point(100, y);
            tb.Size = new System.Drawing.Size(200, 27);
            tb.PasswordChar = '*';
            tb.Name = tb.GetHashCode().ToString();
        }

        private GroupBox infoGroupBox;
        private Label firstNameInfoLabel, firstNameLabel;
        private Label lastNameInfoLabel, lastNameLabel;
        private Label emailInfoLabel, emailLabel;
        private Label createdAtInfoLabel, createdAtLabel;
        private GroupBox editGroupBox;
        private Label firstNameEditLabel, lastNameEditLabel;
        private TextBox firstNameTextBox, lastNameTextBox;
        private Button saveProfileButton;
        private GroupBox passwordGroupBox;
        private Label currentPasswordLabel, newPasswordLabel, confirmPasswordLabel;
        private TextBox currentPasswordTextBox, newPasswordTextBox, confirmPasswordTextBox;
        private Button changePasswordButton;
    }
}
