using System;
using System.Linq;
using System.Windows.Forms;
using InventoryManagementSystem.Services;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Admin_Controls
{
    public partial class SupplierManagementForm : UserControl
    {
        private readonly SupplierService _supplierService;
        private int _selectedSupplierId = -1;

        public SupplierManagementForm()
        {
            InitializeComponent();
            _supplierService = new SupplierService();
            LoadSuppliers();
            SetupInitialState();
        }

        private void LoadSuppliers()
        {
            dgv_ShowData.DataSource = _supplierService.getAllSuppliers()
                .Select(s => new { s.Id, s.Name, s.ContactInfo, s.Address })
                .ToList();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_name.Text) || string.IsNullOrWhiteSpace(txt_contact.Text) || string.IsNullOrWhiteSpace(txt_address.Text))
                {
                    MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var supplier = new Supplier
                {
                    Name = txt_name.Text,
                    ContactInfo = txt_contact.Text,
                    Address = txt_address.Text
                };

                _supplierService.addSupplier(supplier);
                MessageBox.Show("Supplier added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadSuppliers();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (_selectedSupplierId == -1)
            {
                MessageBox.Show("Please select a supplier to edit!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_name.Text) || string.IsNullOrWhiteSpace(txt_contact.Text) || string.IsNullOrWhiteSpace(txt_address.Text))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var updatedSupplier = new Supplier
            {
                Id = _selectedSupplierId,
                Name = txt_name.Text,
                ContactInfo = txt_contact.Text,
                Address = txt_address.Text
            };

            _supplierService.updateSupplier(updatedSupplier);
            MessageBox.Show("Supplier updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadSuppliers();
            ClearFields();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (_selectedSupplierId == -1)
            {
                MessageBox.Show("Please select a supplier to delete!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this supplier?", "Confirm Deletion",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                _supplierService.deleteSupplier(_selectedSupplierId);

                MessageBox.Show("Supplier deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSuppliers();
                ClearFields();
            }
        }

        private void dgv_ShowData_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgv_ShowData.Rows[e.RowIndex];
                _selectedSupplierId = Convert.ToInt32(row.Cells["Id"].Value);
                txt_name.Text = row.Cells["Name"].Value.ToString();
                txt_contact.Text = row.Cells["ContactInfo"].Value.ToString();
                txt_address.Text = row.Cells["Address"].Value.ToString();

                btn_save.Visible = false;
                btn_edit.Visible = true;
                btn_delete.Visible = true;
                lbl_GoBack.Visible = true;
            }
        }

        private void lbl_GoBack_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txt_name.Clear();
            txt_contact.Clear();
            txt_address.Clear();
            _selectedSupplierId = -1;

            btn_save.Visible = true;
            btn_edit.Visible = false;
            btn_delete.Visible = false;
            lbl_GoBack.Visible = false;
        }

        private void SetupInitialState()
        {
            btn_save.Visible = true;
            btn_edit.Visible = false;
            btn_delete.Visible = false;
            lbl_GoBack.Visible = false;
        }
    }
}
