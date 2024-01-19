using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Project__PMS_
{
    public partial class Login : Form
    {
        Functions fn = new Functions();
        string query;
        DataSet ds;

        public Login()
        {
            InitializeComponent();   
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            usernametxt.Clear();
            passwordtxt.Clear();
        }

        private void signinbtn_Click(object sender, EventArgs e)
        {
            query = "select * from users";
            ds = fn .getdata(query);

            if (ds.Tables[0].Rows.Count == 0)
            {
                if(usernametxt.Text == "root" && passwordtxt.Text == "root")
                {
                    Admin admin = new Admin(usernametxt.Text);
                    this.Hide();
                    admin.Show();
                }
            }
            else
            {
                query = "Select * from users where username = '"+usernametxt.Text+"' and password = '"+passwordtxt.Text+"'";
                ds = fn.getdata(query);

                if (ds.Tables[0].Rows.Count !=0 )
                {
                    string role = ds.Tables[0].Rows[0][1].ToString();
                    if (role == "Admin")
                    {
                        Admin admin = new Admin(usernametxt.Text);
                        this.Hide();
                        admin.Show();
                    }
                    else if (role == "Pharmacist")
                    {
                        Pharmacist ph = new Pharmacist(usernametxt.Text,role);
                        this.Hide();
                        ph.Show();
                    }
                   
                }
                else
                {
                    MessageBox.Show("Invalid username or password..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usernametxt.Clear();
                    passwordtxt.Clear();
                    usernametxt.Focus();
                }
            }

        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            Security_Questions sq = new Security_Questions();
            this.Hide();
            sq.Show();
        }
    }
}
