namespace InventoryManagementSystem
{
    partial class Ucontrol_Products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ucontrol_Products));
            dgv_ShowData = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            la = new Label();
            label6 = new Label();
            label7 = new Label();
            panel3 = new Panel();
            txt_category = new TextBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            txt_name_search = new TextBox();
            search_picture = new PictureBox();
            cb_supplier = new ComboBox();
            btn_Edit = new Button();
            btn_remove = new Button();
            btn_save = new Button();
            txt_quantity = new TextBox();
            txt_price = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_ShowData).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)search_picture).BeginInit();
            SuspendLayout();
            // 
            // dgv_ShowData
            // 
            dgv_ShowData.BackgroundColor = Color.RosyBrown;
            dgv_ShowData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ShowData.Location = new Point(3, 343);
            dgv_ShowData.Name = "dgv_ShowData";
            dgv_ShowData.RowHeadersWidth = 51;
            dgv_ShowData.Size = new Size(1115, 319);
            dgv_ShowData.TabIndex = 0;
            dgv_ShowData.RowHeaderMouseDoubleClick += dgv_ShowData_RowHeaderMouseDoubleClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.ForeColor = Color.FromArgb(9, 111, 187);
            label3.Location = new Point(58, 124);
            label3.Name = "label3";
            label3.Size = new Size(129, 25);
            label3.TabIndex = 2;
            label3.Text = "Product Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.ForeColor = Color.FromArgb(9, 111, 187);
            label4.Location = new Point(481, 243);
            label4.Name = "label4";
            label4.Size = new Size(157, 25);
            label4.TabIndex = 3;
            label4.Text = "Product Supplier:";
            // 
            // la
            // 
            la.AutoSize = true;
            la.Font = new Font("Segoe UI", 11F);
            la.ForeColor = Color.FromArgb(9, 111, 187);
            la.Location = new Point(481, 124);
            la.Name = "la";
            la.Size = new Size(159, 25);
            la.TabIndex = 4;
            la.Text = "Product Quantity:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.ForeColor = Color.FromArgb(9, 111, 187);
            label6.Location = new Point(58, 233);
            label6.Name = "label6";
            label6.Size = new Size(163, 25);
            label6.TabIndex = 5;
            label6.Text = "Product Category:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.ForeColor = Color.FromArgb(9, 111, 187);
            label7.Location = new Point(388, 12);
            label7.Name = "label7";
            label7.Size = new Size(137, 25);
            label7.TabIndex = 6;
            label7.Text = "Product Name:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(txt_category);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(cb_supplier);
            panel3.Controls.Add(btn_Edit);
            panel3.Controls.Add(btn_remove);
            panel3.Controls.Add(btn_save);
            panel3.Controls.Add(txt_quantity);
            panel3.Controls.Add(txt_price);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(la);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(dgv_ShowData);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1121, 668);
            panel3.TabIndex = 2;
            // 
            // txt_category
            // 
            txt_category.Location = new Point(58, 268);
            txt_category.Multiline = true;
            txt_category.Name = "txt_category";
            txt_category.Size = new Size(335, 46);
            txt_category.TabIndex = 32;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(1067, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 25);
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txt_name_search);
            panel1.Controls.Add(search_picture);
            panel1.Location = new Point(319, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(335, 43);
            panel1.TabIndex = 30;
            // 
            // txt_name_search
            // 
            txt_name_search.Dock = DockStyle.Top;
            txt_name_search.Font = new Font("Segoe UI", 12F);
            txt_name_search.Location = new Point(0, 0);
            txt_name_search.Multiline = true;
            txt_name_search.Name = "txt_name_search";
            txt_name_search.PlaceholderText = "Search Product By name";
            txt_name_search.Size = new Size(287, 46);
            txt_name_search.TabIndex = 12;
            // 
            // search_picture
            // 
            search_picture.BackColor = Color.Transparent;
            search_picture.BackgroundImageLayout = ImageLayout.Zoom;
            search_picture.BorderStyle = BorderStyle.Fixed3D;
            search_picture.Dock = DockStyle.Right;
            search_picture.Image = (Image)resources.GetObject("search_picture.Image");
            search_picture.Location = new Point(287, 0);
            search_picture.Name = "search_picture";
            search_picture.Size = new Size(48, 43);
            search_picture.SizeMode = PictureBoxSizeMode.Zoom;
            search_picture.TabIndex = 16;
            search_picture.TabStop = false;
            search_picture.Click += search_picture_Click;
            // 
            // cb_supplier
            // 
            cb_supplier.FormattingEnabled = true;
            cb_supplier.Location = new Point(481, 286);
            cb_supplier.Name = "cb_supplier";
            cb_supplier.Size = new Size(319, 28);
            cb_supplier.TabIndex = 28;
            // 
            // btn_Edit
            // 
            btn_Edit.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Edit.ForeColor = Color.FromArgb(9, 111, 187);
            btn_Edit.Location = new Point(898, 174);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(157, 58);
            btn_Edit.TabIndex = 26;
            btn_Edit.Text = "Edit";
            btn_Edit.UseVisualStyleBackColor = true;
            btn_Edit.Click += btn_Edit_Click_1;
            // 
            // btn_remove
            // 
            btn_remove.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_remove.ForeColor = Color.FromArgb(9, 111, 187);
            btn_remove.Location = new Point(898, 256);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new Size(157, 58);
            btn_remove.TabIndex = 25;
            btn_remove.Text = "remove";
            btn_remove.UseVisualStyleBackColor = true;
            btn_remove.Click += btn_remove_Click;
            // 
            // btn_save
            // 
            btn_save.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_save.ForeColor = Color.FromArgb(9, 111, 187);
            btn_save.Location = new Point(898, 91);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(157, 58);
            btn_save.TabIndex = 24;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // txt_quantity
            // 
            txt_quantity.Location = new Point(481, 174);
            txt_quantity.Multiline = true;
            txt_quantity.Name = "txt_quantity";
            txt_quantity.Size = new Size(319, 46);
            txt_quantity.TabIndex = 23;
            // 
            // txt_price
            // 
            txt_price.Location = new Point(58, 174);
            txt_price.Multiline = true;
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(335, 46);
            txt_price.TabIndex = 21;
            // 
            // Ucontrol_Products
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Name = "Ucontrol_Products";
            Size = new Size(1121, 668);
            ((System.ComponentModel.ISupportInitialize)dgv_ShowData).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)search_picture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_ShowData;
        private Label label3;
        private Label label4;
        private Label la;
        private Label label6;
        private Label label7;
        private Panel panel3;
        private TextBox txt_price;
        private TextBox txt_quantity;
        private Button btn_Edit;
        private Button btn_remove;
        private Button btn_save;
        private ComboBox cb_supplier;
        private Panel panel1;
        private TextBox txt_name_search;
        private PictureBox search_picture;
        private PictureBox pictureBox1;
        private TextBox txt_category;
    } }
