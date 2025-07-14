using InventoryManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagementSystem.UI;
using InventoryManagementSystem.Models;
using InventoryManagementSystem.Data;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagementSystem.Admin_Controls
{
    public partial class UserManagement : UserControl
    {
        private UserService _service;
        private string _role;
        private int _selectedUserId;

        public UserManagement(string role)
        {
            InitializeComponent();
            this._role = role;
            _service = new UserService();
            LoadUsers();
            cb_role.Items.AddRange(new string[] { "Admin", "Manager", "Staff" });

        }
        private void LoadUsers()
        {
            dgv_ShowData.DataSource = null;
            var users = _service.getAllUsers();
            dgv_ShowData.DataSource = users;
            ApplyGridViewStyle();
        }

        private void btn_adduser_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInputs()) return;

                var user = new User
                {
                    Username = txt_name.Text,
                    Password = txt_pass.Text,
                    Age = int.Parse(age.Text),
                    Email = txt_email.Text,
                    Address = txt_address.Text,
                    Role = cb_role.SelectedItem?.ToString()
                };


                _service.addUser(user);
                MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadUsers();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_updateUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedUserId == -1)
                {
                    MessageBox.Show("Please select a user to edit!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validation: Ensure all required fields are filled
                if (string.IsNullOrWhiteSpace(txt_name.Text) || string.IsNullOrWhiteSpace(txt_pass.Text) ||
                    string.IsNullOrWhiteSpace(txt_address.Text) || string.IsNullOrWhiteSpace(txt_email.Text) ||
                    cb_role.SelectedItem == null || age.Value <= 0)
                {
                    MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var updatedUser = new User
                {
                    Id = _selectedUserId,
                    Username = txt_name.Text,
                    Password = txt_pass.Text,
                    Address = txt_address.Text,
                    Email = txt_email.Text,
                    Age = (int)age.Value, // Convert NumericUpDown to int
                    Role = cb_role.SelectedItem.ToString()
                };

                _service.updateUser(updatedUser);

                MessageBox.Show("User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadUsers();
                ClearFields();
                _selectedUserId = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txt_name.Text))
            {
                MessageBox.Show("User Name is required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_email.Text))
            {
                MessageBox.Show(" Email is required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_pass.Text))
            {
                MessageBox.Show("Password is required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_address.Text))
            {
                MessageBox.Show("Please enter a valid Address!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (age.Value <= 0)
            {
                MessageBox.Show("Age is required and must be greater than 0!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cb_role.SelectedItem == null || string.IsNullOrWhiteSpace(cb_role.SelectedItem.ToString()))
            {
                MessageBox.Show("Role is required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            return true;
        }
        private void ClearFields()
        {
            txt_name.Clear();
            txt_address.Clear();
            age.Value = 0;
            cb_role.SelectedIndex = -1;
            txt_pass.Clear();
            txt_email.Clear();

        }
        private void ApplyGridViewStyle()
        {

            dgv_ShowData.Font = new Font("Segoe UI", 8);


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


        }


        private void dgv_ShowData_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgv_ShowData.Rows[e.RowIndex];
                _selectedUserId = Convert.ToInt32(row.Cells["Id"].Value);

                using (var context = new InventoryDbContext())
                {
                    var user = context.Users.AsNoTracking()
                                      .FirstOrDefault(u => u.Id == _selectedUserId);

                    if (user != null)
                    {
                        txt_name.Text = user.Username ?? string.Empty;
                        txt_pass.Text = user.Password ?? string.Empty;
                        txt_address.Text = user.Address ?? string.Empty;
                        txt_email.Text = user.Email ?? string.Empty;

                        // Ensure age is within a valid range
                        age.Value = user.Age >= age.Minimum && user.Age <= age.Maximum ? user.Age : age.Minimum;

                        // Ensure role exists in ComboBox before setting it
                        if (cb_role.Items.Contains(user.Role))
                        {
                            cb_role.SelectedItem = user.Role;
                        }
                        else
                        {
                            cb_role.SelectedIndex = -1; // Reset selection if role is invalid
                        }
                    }
                }
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedUserId == -1)
                {
                    MessageBox.Show("Please select a user to delete!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var result = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Deletion",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    var user = _service.getUserByID(_selectedUserId);
                    if (user != null)
                    {
                        _service.deleteUser(user);

                        MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadUsers();  // Refresh DataGridView
                        ClearFields();
                        _selectedUserId = -1; // Reset selection
                    }
                    else
                    {
                        MessageBox.Show("User not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
