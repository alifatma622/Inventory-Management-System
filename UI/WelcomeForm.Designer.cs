namespace InventoryManagementSystem
{
    partial class WelcomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            btnLogin_Click = new Button();
            btnSignUp_Click = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLogin_Click
            // 
            btnLogin_Click.BackColor = Color.FromArgb(255, 192, 192);
            btnLogin_Click.FlatStyle = FlatStyle.Flat;
            btnLogin_Click.Font = new Font("Lucida Fax", 16.2F, FontStyle.Bold);
            btnLogin_Click.ForeColor = Color.Black;
            btnLogin_Click.Location = new Point(689, 391);
            btnLogin_Click.Name = "btnLogin_Click";
            btnLogin_Click.Size = new Size(170, 61);
            btnLogin_Click.TabIndex = 1;
            btnLogin_Click.Text = "Login";
            btnLogin_Click.UseVisualStyleBackColor = false;
            btnLogin_Click.Click += btnLogin_Click_Click;
            // 
            // btnSignUp_Click
            // 
            btnSignUp_Click.BackColor = Color.FromArgb(255, 192, 192);
            btnSignUp_Click.FlatStyle = FlatStyle.Flat;
            btnSignUp_Click.Font = new Font("Lucida Fax", 16.2F, FontStyle.Bold);
            btnSignUp_Click.ForeColor = Color.Black;
            btnSignUp_Click.Location = new Point(956, 391);
            btnSignUp_Click.Name = "btnSignUp_Click";
            btnSignUp_Click.Size = new Size(174, 61);
            btnSignUp_Click.TabIndex = 2;
            btnSignUp_Click.Text = "SignUp";
            btnSignUp_Click.UseVisualStyleBackColor = false;
            btnSignUp_Click.Click += btnSignUp_Click_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(1218, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Lucida Fax", 34.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 0, 0);
            label3.Location = new Point(166, 113);
            label3.Name = "label3";
            label3.Size = new Size(976, 67);
            label3.TabIndex = 6;
            label3.Text = "Welcome to our Inventory App";
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1269, 752);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(btnSignUp_Click);
            Controls.Add(btnLogin_Click);
            DoubleBuffered = true;
            Name = "WelcomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WelcomeForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLogin_Click;
        private Button btnSignUp_Click;
        private PictureBox pictureBox1;
        private Label label3;
    }
}
