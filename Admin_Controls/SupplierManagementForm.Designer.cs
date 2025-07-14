namespace InventoryManagementSystem.Admin_Controls
{
    partial class SupplierManagementForm
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
            txt_name = new TextBox();
            txt_contact = new TextBox();
            txt_address = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lbl_GoBack = new Label();
            dgv_ShowData = new DataGridView();
            btn_save = new Button();
            btn_edit = new Button();
            btn_delete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_ShowData).BeginInit();
            SuspendLayout();
            // 
            // txt_name
            // 
            txt_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_name.Location = new Point(211, 66);
            txt_name.Multiline = true;
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(246, 42);
            txt_name.TabIndex = 0;
            // 
            // txt_contact
            // 
            txt_contact.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_contact.Location = new Point(211, 152);
            txt_contact.Multiline = true;
            txt_contact.Name = "txt_contact";
            txt_contact.Size = new Size(246, 42);
            txt_contact.TabIndex = 1;
            // 
            // txt_address
            // 
            txt_address.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_address.Location = new Point(211, 241);
            txt_address.Multiline = true;
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(246, 42);
            txt_address.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(63, 69);
            label1.Name = "label1";
            label1.Size = new Size(142, 28);
            label1.TabIndex = 3;
            label1.Text = "Supplier Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(73, 155);
            label2.Name = "label2";
            label2.Size = new Size(119, 28);
            label2.TabIndex = 4;
            label2.Text = "Contact Info";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(101, 244);
            label3.Name = "label3";
            label3.Size = new Size(82, 28);
            label3.TabIndex = 5;
            label3.Text = "Address";
            // 
            // lbl_GoBack
            // 
            lbl_GoBack.AutoSize = true;
            lbl_GoBack.BackColor = Color.Transparent;
            lbl_GoBack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_GoBack.ForeColor = SystemColors.HotTrack;
            lbl_GoBack.Location = new Point(912, 318);
            lbl_GoBack.Name = "lbl_GoBack";
            lbl_GoBack.Size = new Size(83, 28);
            lbl_GoBack.TabIndex = 6;
            lbl_GoBack.Text = "Go Back";
            lbl_GoBack.Click += lbl_GoBack_Click;
            // 
            // dgv_ShowData
            // 
            dgv_ShowData.BackgroundColor = Color.RosyBrown;
            dgv_ShowData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ShowData.Location = new Point(3, 363);
            dgv_ShowData.Name = "dgv_ShowData";
            dgv_ShowData.RowHeadersWidth = 51;
            dgv_ShowData.Size = new Size(1015, 302);
            dgv_ShowData.TabIndex = 7;
            dgv_ShowData.RowHeaderMouseDoubleClick += dgv_ShowData_RowHeaderMouseDoubleClick;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.Green;
            btn_save.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_save.ForeColor = SystemColors.ButtonHighlight;
            btn_save.Location = new Point(534, 66);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(120, 42);
            btn_save.TabIndex = 8;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // btn_edit
            // 
            btn_edit.BackColor = Color.Chocolate;
            btn_edit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_edit.ForeColor = SystemColors.ButtonHighlight;
            btn_edit.Location = new Point(534, 147);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(120, 42);
            btn_edit.TabIndex = 9;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = false;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.DarkRed;
            btn_delete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_delete.ForeColor = SystemColors.ButtonHighlight;
            btn_delete.Location = new Point(534, 236);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(120, 42);
            btn_delete.TabIndex = 10;
            btn_delete.Text = "Remove";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // SupplierManagementFormcs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_delete);
            Controls.Add(btn_edit);
            Controls.Add(btn_save);
            Controls.Add(dgv_ShowData);
            Controls.Add(lbl_GoBack);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_address);
            Controls.Add(txt_contact);
            Controls.Add(txt_name);
            Name = "SupplierManagementFormcs";
            Size = new Size(1021, 668);
            ((System.ComponentModel.ISupportInitialize)dgv_ShowData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_name;
        private TextBox txt_contact;
        private TextBox txt_address;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lbl_GoBack;
        private DataGridView dgv_ShowData;
        private Button btn_save;
        private Button btn_edit;
        private Button btn_delete;
    }
}
