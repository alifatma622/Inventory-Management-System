using InventoryManagementSystem.Data;
using InventoryManagementSystem.Models;
using InventoryManagementSystem.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem.Admin_Controls
{
    public partial class SalesHistory : UserControl
    {
        private readonly SaleService _service;
        private readonly InventoryDbContext _context;
        public SalesHistory()
        {
            InitializeComponent();
            _service = new SaleService();
            _context = new InventoryDbContext();
            LoadData();
        }
        private void LoadData()
        {
            LoadSales();
        }

        private void LoadSales()
        {
            var products = _service.getAllSales();
            var formatSales = FormatSales(products);
            dgv_ShowData.DataSource = formatSales;
            ApplyGridViewStyle();
        }

        private List<object> FormatSales(List<Sale> sales)
        {
            return sales.Select(s => (object)new
            {
                s.Id,
                s.CustomerName,
                saleDate = s.SaleDate,
                s.ProductId,
                s.TotalPrice,
                s.UserId,
                Product = s.Product?.Name // Ensure the supplier's name is displayed
            }).ToList();
        }

        public async Task<List<Sale>> GetFilteredSales(string? customerName, DateTime? startDate, DateTime? endDate)
        {
            var query = _context.Sales.AsQueryable();

            if (!string.IsNullOrEmpty(customerName))
            {
                query = query.Where(s => EF.Functions.Like(s.CustomerName, $"%{customerName}%"));
            }

            if (startDate.HasValue)
            {
                query = query.Where(s => s.SaleDate >= startDate.Value);
            }

            if (endDate.HasValue)
            {
                query = query.Where(s => s.SaleDate <= endDate.Value);
            }

            return await query.ToListAsync();
        }


        private void ApplyGridViewStyle()
        {

            dgv_ShowData.Font = new Font("Segoe UI", 10);


            dgv_ShowData.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSteelBlue;
            dgv_ShowData.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;

            // Set the default row style
            dgv_ShowData.RowsDefaultCellStyle.BackColor = Color.White;
            dgv_ShowData.RowsDefaultCellStyle.ForeColor = Color.Black;

            // Set the header style
            dgv_ShowData.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            dgv_ShowData.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgv_ShowData.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_ShowData.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Set the selection style
            dgv_ShowData.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dgv_ShowData.DefaultCellStyle.SelectionForeColor = Color.White;

            // Customize grid lines
            dgv_ShowData.GridColor = Color.Gray;
            dgv_ShowData.BorderStyle = BorderStyle.None;

            // Enable row headers and customize their appearance
            dgv_ShowData.RowHeadersVisible = true;
            dgv_ShowData.RowHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgv_ShowData.RowHeadersDefaultCellStyle.ForeColor = Color.White;

            // Auto-size columns to fit the content
            dgv_ShowData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Disable user resizing of rows and columns
            dgv_ShowData.AllowUserToResizeRows = false;
            dgv_ShowData.AllowUserToResizeColumns = false;

            // Enable row selection by clicking anywhere on the row
            dgv_ShowData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Disable multi-row selection
            dgv_ShowData.MultiSelect = false;

            // Add padding to cells
            dgv_ShowData.DefaultCellStyle.Padding = new Padding(5);

            // Format specific columns (e.g., Price column as currency)
            if (dgv_ShowData.Columns["Price"] != null)
            {
                dgv_ShowData.Columns["Price"].DefaultCellStyle.Format = "C2"; // Currency format with 2 decimal places
                dgv_ShowData.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            // Conditional formatting for low stock quantity
            //dgv_ShowData.CellFormatting += (sender, e) =>
            //{
            //    if (e.ColumnIndex == dgv_ShowData.Columns["StockQuantity"].Index && e.Value != null)
            //    {
            //        if (int.TryParse(e.Value.ToString(), out int stockQuantity))
            //        {
            //            if (stockQuantity < 10) // Highlight rows with low stock
            //            {
            //                e.CellStyle.BackColor = Color.LightCoral;
            //                e.CellStyle.ForeColor = Color.White;
            //            }
            //        }
            //    }
            //};
        }

        private async void but_search_Click(object sender, EventArgs e)
        {
            string customerName = txt_nameSearch.Text;
            DateTime? startDate = dtpStartDate.Value.Date;
            DateTime? endDate = dtpEndDate.Value.Date;

            var query = _context.Sales.AsQueryable();

            if (!string.IsNullOrWhiteSpace(customerName))
            {
                query = query.Where(s => EF.Functions.Like(s.CustomerName, $"%{customerName}%"));
            }

            if (startDate.HasValue)
            {
                query = query.Where(s => s.SaleDate >= startDate.Value);
            }

            if (endDate.HasValue)
            {
                query = query.Where(s => s.SaleDate <= endDate.Value);
            }

            dgv_ShowData.DataSource = await query.ToListAsync();
        }

        private void lblnewSale_Click_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newsale = new NewSale();
            newsale.Show(); // Changed from ShowDialog to Show
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
