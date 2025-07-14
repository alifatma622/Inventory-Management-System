namespace InventoryManagementSystem.Admin_Controls
{
    partial class UserManagement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgv_ShowData = new DataGridView();
            btn_adduser = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txt_address = new TextBox();
            txt_name = new TextBox();
            age = new NumericUpDown();
            label4 = new Label();
            cb_role = new ComboBox();
            btn_updateUser = new Button();
            btn_remove = new Button();
            paas = new Label();
            txt_pass = new TextBox();
            txt_email = new TextBox();
            label5 = new Label();
            label6 = new Label();
            btn_clear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_ShowData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)age).BeginInit();
            SuspendLayout();
            // 
            // dgv_ShowData
            // 
            dgv_ShowData.BackgroundColor = Color.RosyBrown;
            dgv_ShowData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ShowData.Location = new Point(469, 67);
            dgv_ShowData.Name = "dgv_ShowData";
            dgv_ShowData.RowHeadersWidth = 51;
            dgv_ShowData.Size = new Size(801, 660);
            dgv_ShowData.TabIndex = 1;
            dgv_ShowData.RowHeaderMouseDoubleClick += dgv_ShowData_RowHeaderMouseDoubleClick;
            // 
            // btn_adduser
            // 
            btn_adduser.BackColor = SystemColors.ActiveCaption;
            btn_adduser.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_adduser.ForeColor = SystemColors.ActiveCaptionText;
            btn_adduser.Location = new Point(3, 630);
            btn_adduser.Name = "btn_adduser";
            btn_adduser.Size = new Size(131, 45);
            btn_adduser.TabIndex = 3;
            btn_adduser.Text = "Create User";
            btn_adduser.UseVisualStyleBackColor = false;
            btn_adduser.Click += btn_adduser_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(26, 309);
            label3.Name = "label3";
            label3.Size = new Size(82, 28);
            label3.TabIndex = 11;
            label3.Text = "Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(26, 423);
            label2.Name = "label2";
            label2.Size = new Size(47, 28);
            label2.TabIndex = 10;
            label2.Text = "Age";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(26, 0);
            label1.Name = "label1";
            label1.Size = new Size(108, 28);
            label1.TabIndex = 9;
            label1.Text = "User Name";
            // 
            // txt_address
            // 
            txt_address.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_address.Location = new Point(26, 362);
            txt_address.Multiline = true;
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(420, 42);
            txt_address.TabIndex = 8;
            // 
            // txt_name
            // 
            txt_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_name.Location = new Point(26, 44);
            txt_name.Multiline = true;
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(420, 42);
            txt_name.TabIndex = 6;
            // 
            // age
            // 
            age.Location = new Point(26, 474);
            age.Name = "age";
            age.Size = new Size(420, 27);
            age.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(26, 522);
            label4.Name = "label4";
            label4.Size = new Size(50, 28);
            label4.TabIndex = 13;
            label4.Text = "Role";
            // 
            // cb_role
            // 
            cb_role.FormattingEnabled = true;
            cb_role.Location = new Point(26, 572);
            cb_role.Name = "cb_role";
            cb_role.Size = new Size(420, 28);
            cb_role.TabIndex = 14;
            // 
            // btn_updateUser
            // 
            btn_updateUser.BackColor = SystemColors.ActiveCaption;
            btn_updateUser.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_updateUser.ForeColor = SystemColors.ActiveCaptionText;
            btn_updateUser.Location = new Point(157, 630);
            btn_updateUser.Name = "btn_updateUser";
            btn_updateUser.Size = new Size(131, 45);
            btn_updateUser.TabIndex = 15;
            btn_updateUser.Text = "Edit User";
            btn_updateUser.UseVisualStyleBackColor = false;
            btn_updateUser.Click += btn_updateUser_Click;
            // 
            // btn_remove
            // 
            btn_remove.BackColor = Color.Red;
            btn_remove.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_remove.ForeColor = SystemColors.ActiveCaptionText;
            btn_remove.Location = new Point(136, 707);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new Size(152, 45);
            btn_remove.TabIndex = 16;
            btn_remove.Text = "Remove User";
            btn_remove.UseVisualStyleBackColor = false;
            btn_remove.Click += btn_remove_Click;
            // 
            // paas
            // 
            paas.AutoSize = true;
            paas.BackColor = Color.Transparent;
            paas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            paas.ForeColor = SystemColors.HotTrack;
            paas.Location = new Point(26, 104);
            paas.Name = "paas";
            paas.Size = new Size(93, 28);
            paas.TabIndex = 17;
            paas.Text = "Password";
            // 
            // txt_pass
            // 
            txt_pass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_pass.Location = new Point(26, 150);
            txt_pass.Multiline = true;
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(420, 42);
            txt_pass.TabIndex = 18;
            // 
            // txt_email
            // 
            txt_email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_email.Location = new Point(26, 251);
            txt_email.Multiline = true;
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(420, 42);
            txt_email.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(26, 205);
            label5.Name = "label5";
            label5.Size = new Size(59, 28);
            label5.TabIndex = 19;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(773, 0);
            label6.Name = "label6";
            label6.Size = new Size(146, 46);
            label6.TabIndex = 21;
            label6.Text = "User List";
            // 
            // btn_clear
            // 
            btn_clear.BackColor = SystemColors.ActiveCaption;
            btn_clear.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_clear.ForeColor = SystemColors.ActiveCaptionText;
            btn_clear.Location = new Point(328, 630);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(135, 45);
            btn_clear.TabIndex = 22;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // UserManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_clear);
            Controls.Add(label6);
            Controls.Add(txt_email);
            Controls.Add(label5);
            Controls.Add(txt_pass);
            Controls.Add(paas);
            Controls.Add(btn_remove);
            Controls.Add(btn_updateUser);
            Controls.Add(cb_role);
            Controls.Add(label4);
            Controls.Add(age);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_address);
            Controls.Add(txt_name);
            Controls.Add(btn_adduser);
            Controls.Add(dgv_ShowData);
            Name = "UserManagement";
            Size = new Size(1273, 743);
            ((System.ComponentModel.ISupportInitialize)dgv_ShowData).EndInit();
            ((System.ComponentModel.ISupportInitialize)age).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_ShowData;
        private Button btn_adduser;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_address;
        private TextBox txt_name;
        private NumericUpDown age;
        private Label label4;
        private ComboBox cb_role;
        private Button btn_updateUser;
        private Button btn_remove;
        private Label label5;
        private Label paas;
        private TextBox txt_pass;
        private TextBox txt_email;
        private Label label6;
        private Button btn_clear;
    }
}
