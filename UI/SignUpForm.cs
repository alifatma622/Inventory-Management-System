using System;
using System.Linq;
using System.Windows.Forms;
using InventoryManagementSystem.Services;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.UI
{
    public partial class SignUpForm : Form
    {
        private readonly UserService _userService;

        public SignUpForm()
        {
            InitializeComponent();
            _userService = new UserService();

            cmbRole.Items.AddRange(new string[] { "Admin", "Manager", "Staff" });
            // Ensure password fields are hidden by default
            txtPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.UseSystemPasswordChar = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;



        }



        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;  // Disable hiding
                txtConfirmPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;   // Enable hiding
                txtConfirmPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnSignUp_Click_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
    string.IsNullOrWhiteSpace(txtPassword.Text) ||
    string.IsNullOrWhiteSpace(txtConfirmPassword.Text) ||
    cmbRole.SelectedItem == null)
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_userService.getAllUsers().Any(u => u.Username == txtUsername.Text))
            {
                MessageBox.Show("Username already exists.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            User newUser = new User
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                Role = cmbRole.SelectedItem.ToString(),
                Age = (int)numAge.Value,
                Address = txtAddress.Text,
                Email = txtEmail.Text
            };

            _userService.addUser(newUser);
            MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void lblLogin_Click_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btnExit_Click_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

      
    }
}
