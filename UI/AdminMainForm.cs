using InventoryManagementSystem.Admin_Controls;
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
    public partial class AdminMainForm : Form
    {
        private string _role;
        private UserService _user;
        public AdminMainForm(string role)
        {
            InitializeComponent();
            this._role = role;
            _user = new UserService();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("MMMM dd, yyyy, h:mm tt");
            //// Assuming getUserByID() returns a User object
            //UserService user = _user.getUserByID();

            //if (user != null)
            //{
            //    lblUsername.Text = user.UserName; // Assuming User class has a Username property
            //}
            //else
            //{
            //    lblUsername.Text = "Unknown User"; // Fallback text if user is null
            //}

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void btn_ProductManagment_Click(object sender, EventArgs e)
        {
            Admin_pannel.Controls.Clear();
            Ucontrol_Products productsControl = new Ucontrol_Products();
            Admin_pannel.Controls.Add(productsControl);
        }

        private void btn_UserManagment_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Admin_pannel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblDateTime_Click(object sender, EventArgs e)
        {

        }

        private void btn_Suppliers_Click(object sender, EventArgs e)
        {
            Admin_pannel.Controls.Clear();
            SupplierManagementForm supplierControl = new SupplierManagementForm();
            Admin_pannel.Controls.Add(supplierControl);
        }
    }
}

