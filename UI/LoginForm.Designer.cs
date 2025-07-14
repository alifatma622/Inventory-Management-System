namespace InventoryManagementSystem.UI
{
    partial class LoginForm
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
            txt_userName = new TextBox();
            txt_Pass = new TextBox();
            lbl1 = new Label();
            lbl2 = new Label();
            btn_login = new Button();
            label1 = new Label();
            btnExit_Click = new Button();
            chkShowPassword = new CheckBox();
            lblSignUp_Click = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txt_userName
            // 
            txt_userName.Location = new Point(1194, 292);
            txt_userName.Name = "txt_userName";
            txt_userName.PlaceholderText = "Your name";
            txt_userName.Size = new Size(180, 27);
            txt_userName.TabIndex = 0;
            // 
            // txt_Pass
            // 
            txt_Pass.Location = new Point(1194, 396);
            txt_Pass.Name = "txt_Pass";
            txt_Pass.PlaceholderText = "Password";
            txt_Pass.Size = new Size(180, 27);
            txt_Pass.TabIndex = 1;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(1020, 292);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(78, 20);
            lbl1.TabIndex = 2;
            lbl1.Text = "UserName";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(1028, 403);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(70, 20);
            lbl2.TabIndex = 3;
            lbl2.Text = "Password";
            // 
            // btn_login
            // 
            btn_login.Location = new Point(1152, 537);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(209, 29);
            btn_login.TabIndex = 4;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1055, 599);
            label1.Name = "label1";
            label1.Size = new Size(172, 20);
            label1.TabIndex = 6;
            label1.Text = "Don't Have an Account ?";
            // 
            // btnExit_Click
            // 
            btnExit_Click.Location = new Point(1378, 713);
            btnExit_Click.Name = "btnExit_Click";
            btnExit_Click.Size = new Size(94, 29);
            btnExit_Click.TabIndex = 19;
            btnExit_Click.Text = "Exit";
            btnExit_Click.UseVisualStyleBackColor = true;
            btnExit_Click.Click += btnExit_Click_Click;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.CheckAlign = ContentAlignment.MiddleRight;
            chkShowPassword.Location = new Point(1242, 464);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(132, 24);
            chkShowPassword.TabIndex = 20;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // lblSignUp_Click
            // 
            lblSignUp_Click.AutoSize = true;
            lblSignUp_Click.ForeColor = SystemColors.HotTrack;
            lblSignUp_Click.Location = new Point(1242, 599);
            lblSignUp_Click.Name = "lblSignUp_Click";
            lblSignUp_Click.Size = new Size(57, 20);
            lblSignUp_Click.TabIndex = 21;
            lblSignUp_Click.Text = "SignUp";
            lblSignUp_Click.Click += lblSignUp_Click_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(1028, 90);
            label2.Name = "label2";
            label2.Size = new Size(316, 57);
            label2.TabIndex = 23;
            label2.Text = "Welcome Back!";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1484, 752);
            Controls.Add(label2);
            Controls.Add(lblSignUp_Click);
            Controls.Add(chkShowPassword);
            Controls.Add(btnExit_Click);
            Controls.Add(label1);
            Controls.Add(btn_login);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(txt_Pass);
            Controls.Add(txt_userName);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_userName;
        private TextBox txt_Pass;
        private Label lbl1;
        private Label lbl2;
        private Button btn_login;
        private Label label1;
        private Button btnExit_Click;
        private CheckBox chkShowPassword;
        private Label lblSignUp_Click;
        private Label label2;
    }
}