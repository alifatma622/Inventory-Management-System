namespace InventoryManagementSystem.Admin_Controls
{
    partial class SalesHistory
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
            dgv_ShowData = new DataGridView();
            txt_nameSearch = new TextBox();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            but_search = new Button();
            lblnewSale_Click = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_ShowData).BeginInit();
            SuspendLayout();
            // 
            // dgv_ShowData
            // 
            dgv_ShowData.BackgroundColor = Color.RosyBrown;
            dgv_ShowData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ShowData.Location = new Point(1, 108);
            dgv_ShowData.Margin = new Padding(3, 2, 3, 2);
            dgv_ShowData.Name = "dgv_ShowData";
            dgv_ShowData.RowHeadersWidth = 51;
            dgv_ShowData.Size = new Size(812, 347);
            dgv_ShowData.TabIndex = 1;
            // 
            // txt_nameSearch
            // 
            txt_nameSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_nameSearch.Location = new Point(182, 76);
            txt_nameSearch.Margin = new Padding(3, 2, 3, 2);
            txt_nameSearch.Multiline = true;
            txt_nameSearch.Name = "txt_nameSearch";
            txt_nameSearch.PlaceholderText = "Search by Name";
            txt_nameSearch.Size = new Size(152, 21);
            txt_nameSearch.TabIndex = 2;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(355, 76);
            dtpStartDate.Margin = new Padding(3, 2, 3, 2);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(165, 22);
            dtpStartDate.TabIndex = 3;
            dtpStartDate.ValueChanged += dtpStartDate_ValueChanged;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(556, 76);
            dtpEndDate.Margin = new Padding(3, 2, 3, 2);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(165, 22);
            dtpEndDate.TabIndex = 4;
            // 
            // but_search
            // 
            but_search.BackColor = SystemColors.Highlight;
            but_search.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            but_search.ForeColor = SystemColors.ButtonHighlight;
            but_search.Location = new Point(735, 67);
            but_search.Margin = new Padding(3, 2, 3, 2);
            but_search.Name = "but_search";
            but_search.Size = new Size(52, 30);
            but_search.TabIndex = 5;
            but_search.Text = "GO";
            but_search.UseVisualStyleBackColor = false;
            but_search.Click += but_search_Click;
            // 
            // lblnewSale_Click
            // 
            lblnewSale_Click.BackColor = SystemColors.Highlight;
            lblnewSale_Click.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblnewSale_Click.ForeColor = SystemColors.HighlightText;
            lblnewSale_Click.Location = new Point(39, 67);
            lblnewSale_Click.Name = "lblnewSale_Click";
            lblnewSale_Click.Size = new Size(89, 31);
            lblnewSale_Click.TabIndex = 22;
            lblnewSale_Click.Text = "New Sale";
            lblnewSale_Click.TextAlign = ContentAlignment.MiddleCenter;
            lblnewSale_Click.Click += lblnewSale_Click_Click;
            // 
            // SalesHistory
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblnewSale_Click);
            Controls.Add(but_search);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(txt_nameSearch);
            Controls.Add(dgv_ShowData);
            Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SalesHistory";
            Size = new Size(823, 486);
            ((System.ComponentModel.ISupportInitialize)dgv_ShowData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_ShowData;
        private TextBox txt_nameSearch;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private Button but_search;
        private Label lblnewSale_Click;
    }
}