using InventoryManagementSystem.Data;
using InventoryManagementSystem.Models;
using InventoryManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagementSystem
{
    public partial class Ucontrol_Products : UserControl
    {
        private readonly ProductService _service;
        private int _selectedProductId = -1;

        public Ucontrol_Products()
        {
            InitializeComponent();
            _service = new ProductService();
            LoadData();
        }

        private void LoadData()
        {
            LoadProducts();
            LoadSuppliers();
        }

        private void LoadProducts()
        {
            var products = _service.getAllProducts();
            var formattedProducts = FormatProducts(products);
            dgv_ShowData.DataSource = formattedProducts;
            ApplyGridViewStyle();
        }

        private List<object> FormatProducts(List<Product> products)
        {
            return products.Select(p => (object)new
            {
                p.Id,
                p.Name,
                Category = p.Category?.ToString(),
                p.Price,
                p.StockQuantity,
                p.SupplierId,
                Supplier = p.Supplier?.Name // Ensure the supplier's name is displayed
            }).ToList();
        }

        private void LoadSuppliers()
        {
            using (var context = new InventoryDbContext())
            {
                cb_supplier.DataSource = context.Suppliers
                                                .Select(s => new { s.Id, s.Name })
                                                .ToList();
                cb_supplier.DisplayMember = "Name";
                cb_supplier.ValueMember = "Id";
                cb_supplier.SelectedIndex = -1;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInputs()) return;

                var product = new Product
                {
                    Name = txt_name_search.Text,
                    Price = decimal.Parse(txt_price.Text),
                    StockQuantity = int.Parse(txt_quantity.Text),
                    SupplierId = (int)cb_supplier.SelectedValue,
                    Category = txt_category.Text // Use the text input for category
                };

                _service.addProduct(product);
                MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadProducts();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Edit_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Validate if a product is selected
                if (_selectedProductId == -1)
                {
                    MessageBox.Show("Please select a product to edit!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate input fields
                if (!ValidateInputs()) return;

                using (var context = new InventoryDbContext())
                {
                    // Find the existing product in the database
                    var existingProduct = context.Products.Find(_selectedProductId);

                    if (existingProduct == null)
                    {
                        MessageBox.Show("Product not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Update the existing product with new values
                    existingProduct.Name = txt_name_search.Text;
                    existingProduct.Price = decimal.Parse(txt_price.Text);
                    existingProduct.StockQuantity = int.Parse(txt_quantity.Text);
                    existingProduct.SupplierId = (int)cb_supplier.SelectedValue;
                    existingProduct.Category = txt_category.Text;

                    // Save changes to the database
                    context.SaveChanges();

                    MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh the DataGridView
                    LoadProducts();

                    // Clear the input fields
                    ClearFields();
                    _selectedProductId = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (_selectedProductId == -1)
            {
                MessageBox.Show("Please select a product to delete!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Deletion",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                _service.deleteProduct(new Product { Id = _selectedProductId });

                MessageBox.Show("Product deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProducts();
                ClearFields();
                _selectedProductId = -1;
            }
        }

        private void dgv_ShowData_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgv_ShowData.Rows[e.RowIndex];
                _selectedProductId = Convert.ToInt32(row.Cells["Id"].Value);

                using (var context = new InventoryDbContext())
                {
                    // Fetch the product without tracking
                    var product = context.Products
                                        .AsNoTracking()
                                        .Include(p => p.Supplier) 
                                        .FirstOrDefault(p => p.Id == _selectedProductId);

                    if (product != null)
                    {
                        txt_name_search.Text = product.Name;
                        txt_price.Text = product.Price.ToString();
                        txt_quantity.Text = product.StockQuantity.ToString();
                        cb_supplier.SelectedValue = product.SupplierId;
                        txt_category.Text = product.Category;
                    }
                }
            }
        }

        //refersh
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_name_search.Text))
            {
                LoadProducts();
            }
            else
            {
                SearchProducts();
            }
        }

        private void SearchProducts()
        {
            var searchValue = txt_name_search.Text.ToLower();
            var filteredData = _service.getAllProducts()
                                       .Where(p => p.Name.ToLower().Contains(searchValue))
                                       .ToList();
            dgv_ShowData.DataSource = FormatProducts(filteredData);
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txt_name_search.Text))
            {
                MessageBox.Show("Product Name is required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txt_price.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Please enter a valid price!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txt_quantity.Text, out int quantity) || quantity < 0)
            {
                MessageBox.Show("Please enter a valid stock quantity!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_category.Text)) // Validate category text input
            {
                MessageBox.Show("Category is required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ClearFields()
        {
            txt_name_search.Clear();
            txt_price.Clear();
            txt_quantity.Clear();
            cb_supplier.SelectedIndex = -1;
            txt_category.Clear(); // Clear the category text input
        }

        //search
        private void search_picture_Click(object sender, EventArgs e)
        {
            SearchProducts();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoadProducts();
            txt_name_search.Clear();
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
            dgv_ShowData.CellFormatting += (sender, e) =>
            {
                if (e.ColumnIndex == dgv_ShowData.Columns["StockQuantity"].Index && e.Value != null)
                {
                    if (int.TryParse(e.Value.ToString(), out int stockQuantity))
                    {
                        if (stockQuantity < 10) // Highlight rows with low stock
                        {
                            e.CellStyle.BackColor = Color.LightCoral;
                            e.CellStyle.ForeColor = Color.White;
                        }
                    }
                }
            };
        }
    }
}
