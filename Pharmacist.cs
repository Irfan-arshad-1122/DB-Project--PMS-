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
    public partial class Pharmacist : Form
    {
        string rolechecker,User;
        public Pharmacist(string user , string role)
        {
            InitializeComponent();
            usernamelbl.Text = user;
            User = user;
            rolechecker = role;

        }

        private void Pharmacist_Load(object sender, EventArgs e)
        {
            p_dashboard_UC1.Visible = false;
            dashboardbtn.PerformClick();
            addmed_UC1.Visible=false;
            viewmed_UC1.Visible = false;
            modifymed_UC1.Visible=false;
            medvalidity_UC1.Visible = false;
            sell_Med_UC1.Visible = false;
        }

        private void logouttn_Click(object sender, EventArgs e)
        {
            if (rolechecker == "Pharmacist")
            {
                Login login = new Login();
                this.Hide();
                login.Show();
            }
            else
            {
                Admin admin = new Admin(User);
                this.Hide();
                admin.Show();
            }
        }

        private void dashboardbtn_Click(object sender, EventArgs e)
        {
            p_dashboard_UC1.Visible = true;
            p_dashboard_UC1.BringToFront();
        }

        private void addmedbtn_Click(object sender, EventArgs e)
        {
            addmed_UC1.Visible = true;
            addmed_UC1.BringToFront();

        }

        private void viewmedbtn_Click(object sender, EventArgs e)
        {
            viewmed_UC1 .Visible = true;
            viewmed_UC1.BringToFront();
        }

        private void updatemedbtn_Click(object sender, EventArgs e)
        {
            modifymed_UC1.Visible = true;
            modifymed_UC1.BringToFront();
        }

        private void medvaliditybtn_Click(object sender, EventArgs e)
        {
            medvalidity_UC1 .Visible = true;
            medvalidity_UC1.BringToFront ();
        }
        private void sellmedbtn_Click(object sender, EventArgs e)
        {
            sell_Med_UC1.Visible = true;
            sell_Med_UC1.BringToFront();
        }
    }
}
