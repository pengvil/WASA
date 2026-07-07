namespace WaterSewageManagementSystem.Forms.Common
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblGender = new System.Windows.Forms.Label();
            this.radioButton_Male = new System.Windows.Forms.RadioButton();
            this.radioButton_Female = new System.Windows.Forms.RadioButton();
            this.errorlblAdress = new System.Windows.Forms.Label();
            this.errorlblRole = new System.Windows.Forms.Label();
            this.errorlblPhone = new System.Windows.Forms.Label();
            this.errorlblConfPass = new System.Windows.Forms.Label();
            this.errorlblEmail = new System.Windows.Forms.Label();
            this.errorlblPass = new System.Windows.Forms.Label();
            this.errorlblName = new System.Windows.Forms.Label();
            this.errorlblGender = new System.Windows.Forms.Label();
            this.errorlblPassNotMatch = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.errorlblDOB = new System.Windows.Forms.Label();
            this.dateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.lblTitle.Location = new System.Drawing.Point(395, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(200, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Create Account";
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(36, 88);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(145, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Full Name *";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtName.Location = new System.Drawing.Point(219, 86);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(260, 25);
            this.txtName.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmail.Location = new System.Drawing.Point(36, 164);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(145, 20);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email *";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.Location = new System.Drawing.Point(219, 162);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(260, 25);
            this.txtEmail.TabIndex = 4;
            // 
            // lblPhone
            // 
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPhone.Location = new System.Drawing.Point(36, 236);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(145, 20);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "Phone *";
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPhone.Location = new System.Drawing.Point(219, 234);
            this.txtPhone.MaxLength = 11;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(260, 25);
            this.txtPhone.TabIndex = 6;
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPassword.Location = new System.Drawing.Point(523, 165);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(145, 20);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password *";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.Location = new System.Drawing.Point(706, 163);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(260, 25);
            this.txtPassword.TabIndex = 8;
            // 
            // lblConfirm
            // 
            this.lblConfirm.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblConfirm.Location = new System.Drawing.Point(523, 237);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(177, 27);
            this.lblConfirm.TabIndex = 9;
            this.lblConfirm.Text = "Confirm Password *";
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmPass.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtConfirmPass.Location = new System.Drawing.Point(706, 234);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.PasswordChar = '*';
            this.txtConfirmPass.Size = new System.Drawing.Size(260, 25);
            this.txtConfirmPass.TabIndex = 10;
            // 
            // lblRole
            // 
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRole.Location = new System.Drawing.Point(523, 315);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(145, 28);
            this.lblRole.TabIndex = 11;
            this.lblRole.Text = "Register As *";
            // 
            // cmbRole
            // 
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbRole.Items.AddRange(new object[] {
            "Customer",
            "ServiceOfficer",
            "MaintenanceEngineer"});
            this.cmbRole.Location = new System.Drawing.Point(706, 312);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(260, 25);
            this.cmbRole.TabIndex = 12;
            // 
            // lblAddress
            // 
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAddress.Location = new System.Drawing.Point(36, 389);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(145, 28);
            this.lblAddress.TabIndex = 13;
            this.lblAddress.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAddress.Location = new System.Drawing.Point(219, 387);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(260, 25);
            this.txtAddress.TabIndex = 14;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(40, 503);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(125, 38);
            this.btnRegister.TabIndex = 15;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightGray;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(841, 503);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 38);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblGender
            // 
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblGender.Location = new System.Drawing.Point(36, 312);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(145, 20);
            this.lblGender.TabIndex = 19;
            this.lblGender.Text = "Gender *";
            // 
            // radioButton_Male
            // 
            this.radioButton_Male.AutoSize = true;
            this.radioButton_Male.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.radioButton_Male.Location = new System.Drawing.Point(219, 310);
            this.radioButton_Male.Name = "radioButton_Male";
            this.radioButton_Male.Size = new System.Drawing.Size(60, 23);
            this.radioButton_Male.TabIndex = 20;
            this.radioButton_Male.TabStop = true;
            this.radioButton_Male.Text = "Male";
            this.radioButton_Male.UseVisualStyleBackColor = true;
            // 
            // radioButton_Female
            // 
            this.radioButton_Female.AutoSize = true;
            this.radioButton_Female.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.radioButton_Female.Location = new System.Drawing.Point(391, 312);
            this.radioButton_Female.Name = "radioButton_Female";
            this.radioButton_Female.Size = new System.Drawing.Size(75, 23);
            this.radioButton_Female.TabIndex = 21;
            this.radioButton_Female.TabStop = true;
            this.radioButton_Female.Text = "Female";
            this.radioButton_Female.UseVisualStyleBackColor = true;
            // 
            // errorlblAdress
            // 
            this.errorlblAdress.AutoSize = true;
            this.errorlblAdress.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.errorlblAdress.ForeColor = System.Drawing.Color.Red;
            this.errorlblAdress.Location = new System.Drawing.Point(215, 420);
            this.errorlblAdress.Name = "errorlblAdress";
            this.errorlblAdress.Size = new System.Drawing.Size(84, 15);
            this.errorlblAdress.TabIndex = 24;
            this.errorlblAdress.Text = "errorlblAdress";
            // 
            // errorlblRole
            // 
            this.errorlblRole.AutoSize = true;
            this.errorlblRole.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.errorlblRole.ForeColor = System.Drawing.Color.Red;
            this.errorlblRole.Location = new System.Drawing.Point(703, 346);
            this.errorlblRole.Name = "errorlblRole";
            this.errorlblRole.Size = new System.Drawing.Size(71, 15);
            this.errorlblRole.TabIndex = 27;
            this.errorlblRole.Text = "errorlblRole";
            // 
            // errorlblPhone
            // 
            this.errorlblPhone.AutoSize = true;
            this.errorlblPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.errorlblPhone.ForeColor = System.Drawing.Color.Red;
            this.errorlblPhone.Location = new System.Drawing.Point(215, 267);
            this.errorlblPhone.Name = "errorlblPhone";
            this.errorlblPhone.Size = new System.Drawing.Size(82, 15);
            this.errorlblPhone.TabIndex = 28;
            this.errorlblPhone.Text = "errorlblPhone";
            // 
            // errorlblConfPass
            // 
            this.errorlblConfPass.AutoSize = true;
            this.errorlblConfPass.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.errorlblConfPass.ForeColor = System.Drawing.Color.Red;
            this.errorlblConfPass.Location = new System.Drawing.Point(703, 267);
            this.errorlblConfPass.Name = "errorlblConfPass";
            this.errorlblConfPass.Size = new System.Drawing.Size(98, 15);
            this.errorlblConfPass.TabIndex = 29;
            this.errorlblConfPass.Text = "errorlblConfPass";
            // 
            // errorlblEmail
            // 
            this.errorlblEmail.AutoSize = true;
            this.errorlblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.errorlblEmail.ForeColor = System.Drawing.Color.Red;
            this.errorlblEmail.Location = new System.Drawing.Point(215, 194);
            this.errorlblEmail.Name = "errorlblEmail";
            this.errorlblEmail.Size = new System.Drawing.Size(78, 15);
            this.errorlblEmail.TabIndex = 30;
            this.errorlblEmail.Text = "errorlblEmail";
            // 
            // errorlblPass
            // 
            this.errorlblPass.AutoSize = true;
            this.errorlblPass.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.errorlblPass.ForeColor = System.Drawing.Color.Red;
            this.errorlblPass.Location = new System.Drawing.Point(703, 196);
            this.errorlblPass.Name = "errorlblPass";
            this.errorlblPass.Size = new System.Drawing.Size(72, 15);
            this.errorlblPass.TabIndex = 31;
            this.errorlblPass.Text = "errorlblPass";
            // 
            // errorlblName
            // 
            this.errorlblName.AutoSize = true;
            this.errorlblName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.errorlblName.ForeColor = System.Drawing.Color.Red;
            this.errorlblName.Location = new System.Drawing.Point(215, 119);
            this.errorlblName.Name = "errorlblName";
            this.errorlblName.Size = new System.Drawing.Size(81, 15);
            this.errorlblName.TabIndex = 32;
            this.errorlblName.Text = "errorlblName";
            // 
            // errorlblGender
            // 
            this.errorlblGender.AutoSize = true;
            this.errorlblGender.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.errorlblGender.ForeColor = System.Drawing.Color.Red;
            this.errorlblGender.Location = new System.Drawing.Point(215, 342);
            this.errorlblGender.Name = "errorlblGender";
            this.errorlblGender.Size = new System.Drawing.Size(87, 15);
            this.errorlblGender.TabIndex = 33;
            this.errorlblGender.Text = "errorlblGender";
            // 
            // errorlblPassNotMatch
            // 
            this.errorlblPassNotMatch.AutoSize = true;
            this.errorlblPassNotMatch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.errorlblPassNotMatch.ForeColor = System.Drawing.Color.Red;
            this.errorlblPassNotMatch.Location = new System.Drawing.Point(706, 267);
            this.errorlblPassNotMatch.Name = "errorlblPassNotMatch";
            this.errorlblPassNotMatch.Size = new System.Drawing.Size(125, 15);
            this.errorlblPassNotMatch.TabIndex = 34;
            this.errorlblPassNotMatch.Text = "errorlblPassNotMatch";
            // 
            // lblDOB
            // 
            this.lblDOB.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDOB.Location = new System.Drawing.Point(523, 86);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(165, 42);
            this.lblDOB.TabIndex = 35;
            this.lblDOB.Text = "Date of Birth *";
            // 
            // errorlblDOB
            // 
            this.errorlblDOB.AutoSize = true;
            this.errorlblDOB.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.errorlblDOB.ForeColor = System.Drawing.Color.Red;
            this.errorlblDOB.Location = new System.Drawing.Point(702, 111);
            this.errorlblDOB.Name = "errorlblDOB";
            this.errorlblDOB.Size = new System.Drawing.Size(73, 15);
            this.errorlblDOB.TabIndex = 36;
            this.errorlblDOB.Text = "errorlblDOB";
            // 
            // dateTimePickerDOB
            // 
            this.dateTimePickerDOB.CalendarFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDOB.Location = new System.Drawing.Point(706, 86);
            this.dateTimePickerDOB.Name = "dateTimePickerDOB";
            this.dateTimePickerDOB.ShowCheckBox = true;
            this.dateTimePickerDOB.Size = new System.Drawing.Size(260, 20);
            this.dateTimePickerDOB.TabIndex = 37;
            this.dateTimePickerDOB.Value = new System.DateTime(2026, 5, 19, 0, 0, 0, 0);
            // 
            // RegisterForm
            // 
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1015, 575);
            this.Controls.Add(this.dateTimePickerDOB);
            this.Controls.Add(this.errorlblDOB);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.errorlblPassNotMatch);
            this.Controls.Add(this.errorlblGender);
            this.Controls.Add(this.errorlblName);
            this.Controls.Add(this.errorlblPass);
            this.Controls.Add(this.errorlblEmail);
            this.Controls.Add(this.errorlblConfPass);
            this.Controls.Add(this.errorlblPhone);
            this.Controls.Add(this.errorlblRole);
            this.Controls.Add(this.errorlblAdress);
            this.Controls.Add(this.radioButton_Female);
            this.Controls.Add(this.radioButton_Male);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register New Account";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblAddress;

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.TextBox txtAddress;

        private System.Windows.Forms.ComboBox cmbRole;

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton radioButton_Male;
        private System.Windows.Forms.RadioButton radioButton_Female;
        private System.Windows.Forms.Label errorlblAdress;
        private System.Windows.Forms.Label errorlblRole;
        private System.Windows.Forms.Label errorlblPhone;
        private System.Windows.Forms.Label errorlblConfPass;
        private System.Windows.Forms.Label errorlblEmail;
        private System.Windows.Forms.Label errorlblPass;
        private System.Windows.Forms.Label errorlblName;
        private System.Windows.Forms.Label errorlblGender;
        private System.Windows.Forms.Label errorlblPassNotMatch;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label errorlblDOB;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOB;
    }
}