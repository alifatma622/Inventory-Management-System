namespace InventoryManagementSystem.UI
{
    partial class SignUpForm
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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            numAge = new NumericUpDown();
            txtAddress = new TextBox();
            txtEmail = new TextBox();
            cmbRole = new ComboBox();
            chkShowPassword = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnSignUp_Click = new Button();
            btnExit_Click = new Button();
            lblLogin_Click = new Label();
            ((System.ComponentModel.ISupportInitialize)numAge).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(356, 54);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(224, 34);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(356, 177);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(224, 34);
            txtPassword.TabIndex = 1;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPassword.Location = new Point(356, 254);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(224, 34);
            txtConfirmPassword.TabIndex = 2;
            // 
            // numAge
            // 
            numAge.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numAge.Location = new Point(356, 345);
            numAge.Name = "numAge";
            numAge.Size = new Size(224, 34);
            numAge.TabIndex = 3;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(356, 428);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(224, 34);
            txtAddress.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(356, 114);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(224, 34);
            txtEmail.TabIndex = 5;
            // 
            // cmbRole
            // 
            cmbRole.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(356, 488);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(224, 36);
            cmbRole.TabIndex = 6;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.CheckAlign = ContentAlignment.MiddleRight;
            chkShowPassword.Location = new Point(448, 294);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(132, 24);
            chkShowPassword.TabIndex = 7;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = true;
        
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(240, 64);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 8;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(245, 177);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 9;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(210, 254);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 10;
            label3.Text = "Confirm Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(240, 354);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 11;
            label4.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(229, 438);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 12;
            label5.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(245, 114);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 13;
            label6.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(229, 504);
            label7.Name = "label7";
            label7.Size = new Size(39, 20);
            label7.TabIndex = 14;
            label7.Text = "Role";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(476, 564);
            label8.Name = "label8";
            label8.Size = new Size(173, 20);
            label8.TabIndex = 16;
            label8.Text = "Already have an acoount";
            // 
            // btnSignUp_Click
            // 
            btnSignUp_Click.Location = new Point(365, 555);
            btnSignUp_Click.Name = "btnSignUp_Click";
            btnSignUp_Click.Size = new Size(94, 29);
            btnSignUp_Click.TabIndex = 17;
            btnSignUp_Click.Text = "SignUp";
            btnSignUp_Click.UseVisualStyleBackColor = true;
            btnSignUp_Click.Click += btnSignUp_Click_Click;
            // 
            // btnExit_Click
            // 
            btnExit_Click.Location = new Point(22, 658);
            btnExit_Click.Name = "btnExit_Click";
            btnExit_Click.Size = new Size(94, 29);
            btnExit_Click.TabIndex = 18;
            btnExit_Click.Text = "Exit";
            btnExit_Click.UseVisualStyleBackColor = true;
            btnExit_Click.Click += btnExit_Click_Click;
            // 
            // lblLogin_Click
            // 
            lblLogin_Click.AutoSize = true;
            lblLogin_Click.ForeColor = SystemColors.HotTrack;
            lblLogin_Click.Location = new Point(655, 564);
            lblLogin_Click.Name = "lblLogin_Click";
            lblLogin_Click.Size = new Size(46, 20);
            lblLogin_Click.TabIndex = 19;
            lblLogin_Click.Text = "Login";
            lblLogin_Click.Click += lblLogin_Click_Click;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1484, 752);
            Controls.Add(lblLogin_Click);
            Controls.Add(btnExit_Click);
            Controls.Add(btnSignUp_Click);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(chkShowPassword);
            Controls.Add(cmbRole);
            Controls.Add(txtEmail);
            Controls.Add(txtAddress);
            Controls.Add(numAge);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "SignUpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUpForm";
            ((System.ComponentModel.ISupportInitialize)numAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private NumericUpDown numAge;
        private TextBox txtAddress;
        private TextBox txtEmail;
        private ComboBox cmbRole;
        private CheckBox chkShowPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnSignUp_Click;
        private Button btnExit_Click;
        private Label lblLogin_Click;
    }
}