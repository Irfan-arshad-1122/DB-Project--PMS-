using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Project__PMS_
{
    public partial class Supplier : Form
    {
        string user = "";

        public Supplier(string username)
        {
            InitializeComponent();
            user = username;
            usernamelbl.Text = username;
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            viewsupp_UC1.Visible = false;
            viewsupbtn.PerformClick();
            addsup_UC1.Visible =false;
            updatesup_UC1.Visible=false;

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            viewsupp_UC1.Visible= true;
            viewsupp_UC1.BringToFront();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin(usernamelbl.Text);
            this.Hide();
            admin.Show();
        }

        private void addsupbtn_Click(object sender, EventArgs e)
        {
            addsup_UC1.Visible = true;
            addsup_UC1.BringToFront();
        }

        private void updatesupbtn_Click(object sender, EventArgs e)
        {
            updatesup_UC1.Visible = true;
            updatesup_UC1.BringToFront();
        }
    }
}
