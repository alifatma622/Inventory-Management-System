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
    public partial class StaffMainForm : Form
    {
        private string _role;
        public StaffMainForm(string role)
        {
            InitializeComponent();
            _role = role;
        }
    }
}
