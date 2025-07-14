namespace InventoryManagementSystem.UI
{
    partial class AdminMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainForm));
            panel1 = new Panel();
            Home = new Button();
            label1 = new Label();
            btn_Reports = new Button();
            btn_Suppliers = new Button();
            btn_StockTransaction = new Button();
            btn_Sale = new Button();
            btn_ProductManagment = new Button();
            btn_UserManagment = new Button();
            Admin_pannel = new Panel();
            pnlNavbar = new Panel();
            exit = new PictureBox();
            lblUsername = new Label();
            pictureBox1 = new PictureBox();
            lblDateTime = new Label();
            panel1.SuspendLayout();
            pnlNavbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)exit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(Home);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_Reports);
            panel1.Controls.Add(btn_Suppliers);
            panel1.Controls.Add(btn_StockTransaction);
            panel1.Controls.Add(btn_Sale);
            panel1.Controls.Add(btn_ProductManagment);
            panel1.Controls.Add(btn_UserManagment);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(333, 760);
            panel1.TabIndex = 0;
            // 
            // Home
            // 
            Home.Location = new Point(12, 104);
            Home.Name = "Home";
            Home.Size = new Size(302, 53);
            Home.TabIndex = 7;
            Home.Text = "Home";
            Home.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = Color.IndianRed;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 6);
            label1.Name = "label1";
            label1.Size = new Size(327, 88);
            label1.TabIndex = 6;
            label1.Text = "Welcome to Inventory Management System";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_Reports
            // 
            btn_Reports.Location = new Point(12, 624);
            btn_Reports.Name = "btn_Reports";
            btn_Reports.Size = new Size(302, 53);
            btn_Reports.TabIndex = 2;
            btn_Reports.Text = "Sales Reports";
            btn_Reports.UseVisualStyleBackColor = true;
            // 
            // btn_Suppliers
            // 
            btn_Suppliers.Location = new Point(12, 544);
            btn_Suppliers.Name = "btn_Suppliers";
            btn_Suppliers.Size = new Size(302, 53);
            btn_Suppliers.TabIndex = 5;
            btn_Suppliers.Text = "Suppliers";
            btn_Suppliers.UseVisualStyleBackColor = true;
            btn_Suppliers.Click += btn_Suppliers_Click;
            // 
            // btn_StockTransaction
            // 
            btn_StockTransaction.Location = new Point(12, 460);
            btn_StockTransaction.Name = "btn_StockTransaction";
            btn_StockTransaction.Size = new Size(302, 53);
            btn_StockTransaction.TabIndex = 4;
            btn_StockTransaction.Text = "Stock Transaction";
            btn_StockTransaction.UseVisualStyleBackColor = true;
            // 
            // btn_Sale
            // 
            btn_Sale.Location = new Point(18, 368);
            btn_Sale.Name = "btn_Sale";
            btn_Sale.Size = new Size(302, 53);
            btn_Sale.TabIndex = 3;
            btn_Sale.Text = "Sales";
            btn_Sale.UseVisualStyleBackColor = true;
            // 
            // btn_ProductManagment
            // 
            btn_ProductManagment.Location = new Point(18, 274);
            btn_ProductManagment.Name = "btn_ProductManagment";
            btn_ProductManagment.Size = new Size(302, 53);
            btn_ProductManagment.TabIndex = 2;
            btn_ProductManagment.Text = "Product Mangement";
            btn_ProductManagment.UseVisualStyleBackColor = true;
            btn_ProductManagment.Click += btn_ProductManagment_Click;
            // 
            // btn_UserManagment
            // 
            btn_UserManagment.Location = new Point(12, 177);
            btn_UserManagment.Name = "btn_UserManagment";
            btn_UserManagment.Size = new Size(302, 53);
            btn_UserManagment.TabIndex = 1;
            btn_UserManagment.Text = "User Management";
            btn_UserManagment.UseVisualStyleBackColor = true;
            btn_UserManagment.Click += btn_UserManagment_Click;
            // 
            // Admin_pannel
            // 
            Admin_pannel.Location = new Point(351, 81);
            Admin_pannel.Name = "Admin_pannel";
            Admin_pannel.Size = new Size(1121, 668);
            Admin_pannel.TabIndex = 1;
            Admin_pannel.Paint += Admin_pannel_Paint;
            // 
            // pnlNavbar
            // 
            pnlNavbar.Controls.Add(exit);
            pnlNavbar.Controls.Add(lblUsername);
            pnlNavbar.Controls.Add(pictureBox1);
            pnlNavbar.Controls.Add(lblDateTime);
            pnlNavbar.Dock = DockStyle.Top;
            pnlNavbar.Location = new Point(333, 0);
            pnlNavbar.Name = "pnlNavbar";
            pnlNavbar.Size = new Size(1158, 68);
            pnlNavbar.TabIndex = 2;
            // 
            // exit
            // 
            exit.BackgroundImage = (Image)resources.GetObject("exit.BackgroundImage");
            exit.BackgroundImageLayout = ImageLayout.Stretch;
            exit.Location = new Point(1095, 12);
            exit.Name = "exit";
            exit.Size = new Size(44, 35);
            exit.TabIndex = 0;
            exit.TabStop = false;
            exit.Click += exit_Click_1;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(569, 27);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(50, 20);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "label2";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(453, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblDateTime
            // 
            lblDateTime.AutoSize = true;
            lblDateTime.Location = new Point(44, 27);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(50, 20);
            lblDateTime.TabIndex = 0;
            lblDateTime.Text = "label2";
            lblDateTime.Click += lblDateTime_Click;
            // 
            // AdminMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1491, 760);
            Controls.Add(pnlNavbar);
            Controls.Add(Admin_pannel);
            Controls.Add(panel1);
            Name = "AdminMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += AdminMainForm_Load;
            panel1.ResumeLayout(false);
            pnlNavbar.ResumeLayout(false);
            pnlNavbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)exit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_UserManagment;
        private Label label1;
        private Button btn_Reports;
        private Button btn_Suppliers;
        private Button btn_StockTransaction;
        private Button btn_Sale;
        private Button btn_ProductManagment;
        private Panel Admin_pannel;
        private Panel pnlNavbar;
        private Label lblDateTime;
        private PictureBox pictureBox1;
        private Label lblUsername;
        private Button Home;
        private PictureBox exit;
    }
}