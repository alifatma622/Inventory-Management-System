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

namespace InventoryManagementSystem.UI
{
    public partial class LoginForm : Form
    {
        private readonly UserService _userService;
        public LoginForm()
        {
            InitializeComponent();
            _userService = new UserService();
            // Ensure password fields are hidden by default
            txt_Pass.UseSystemPasswordChar = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string userName = txt_userName.Text;
            string password = txt_Pass.Text;
            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please Enter username and password", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var user = _userService.getAllUsers()
                     .FirstOrDefault(u => u.Username == txt_userName.Text && u.Password == txt_Pass.Text);

            if (user != null)
            {
                MessageBox.Show($"Welcome, {user.Username}! You are logged in as {user.Role}.",
                 "Success",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
                if (user.Role != null && user.Role.ToString() == "Admin")
                {
                    AdminMainForm mainForm = new AdminMainForm(user.Role);
                    mainForm.Show();
                    this.Hide();
                }
                else if (user.Role != null && user.Role.ToString() == "Manager")
                {
                    ManagerMainForm mainForm = new ManagerMainForm(user.Role);
                    mainForm.Show();
                    this.Hide();
                }
                else if (user.Role != null && user.Role.ToString() == "Staff")
                {
                    StaffMainForm mainForm = new StaffMainForm(user.Role);
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Invalid Username or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
       

        private void btnExit_Click_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txt_Pass.UseSystemPasswordChar = false;  // Disable hiding

            }
            else
            {
                txt_Pass.UseSystemPasswordChar = true;   // Enable hiding

            }

        }
        private void lblSignUp_Click_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
            this.Hide();

        }


    }
}
