using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Admin : Form
    {
        Functions fn = new Functions();
        string query;
        string user;
        DataSet ds;

        public Admin(string username)
        {
            InitializeComponent();
            user = username;
            usernamelbl.Text = username;
            
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            view_Sales_UC1.Visible = false;
            query = "select count(user_role) from users where user_role = 'Admin'";
            ds = fn.getdata(query);
            setlabel(ds, adminnolbl);

            query = "select count(user_role) from users where user_role = 'Pharmacist'";
            ds = fn.getdata(query);
            setlabel(ds, pharmacistnolbl);

            query = "select count(Supplier_ID) from supplier";
            ds = fn.getdata(query);
            setlabel(ds, suppliernolbl);

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void adduserbtn_Click(object sender, EventArgs e)
        {
            Profile pf = new Profile(user);
            this.Hide();
            pf.Show();
        }

        private void viewuserbtn_Click(object sender, EventArgs e)
        {
            Pharmacist ph = new Pharmacist(user , "Admin");
            this.Hide();
            ph.Show();
        }

        private void profilebtn_Click(object sender, EventArgs e)
        {
            Supplier sp = new Supplier(user);
            this.Hide();
            sp.Show();
        }

        //setting total no of admins,pharmacist,suppliers
        private void setlabel( DataSet ds , Label lbl)
        {
            if (ds.Tables[0].Rows.Count != 0)
            {
                lbl.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            else
            {
                lbl.Text = "0";
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void dashboardbtn_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            view_Sales_UC1.Visible = true;
            view_Sales_UC1.BringToFront();
        }
    }
}
