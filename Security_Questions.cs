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
    public partial class Security_Questions : Form
    {
        Functions fn = new Functions();
        string query;
        public Security_Questions()
        {
            InitializeComponent();
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            childhoodfriendtxt.Clear();
            schoolnametxt.Clear();
            petnametxt.Clear();
        }

        private void signinbtn_Click(object sender, EventArgs e)
        {
            if (childhoodfriendtxt.Text != "" && schoolnametxt.Text != "" && petnametxt.Text != "")
            {
                string childhoodfriend = childhoodfriendtxt.Text;
                string schoolname = schoolnametxt.Text;
                string petname = petnametxt.Text;

                query = " select * from users where Childhood_Friend = '" + childhoodfriend + "' and First_Attended_School = '" + schoolname + "' and Favourite_Pet = '" + petname + "'";
                DataSet ds = fn.getdata(query);

                if (ds.Tables[0].Rows.Count != 0)
                {
                    string role = ds.Tables[0].Rows[0][1].ToString();
                    string username = ds.Tables[0].Rows[0][6].ToString();
                    if (role == "Admin")
                    {
                        Admin admin = new Admin(username);
                        this.Hide();
                        admin.Show();
                    }
                    else if (role == "Pharmacist")
                    {
                        Pharmacist ph = new Pharmacist(username, role);
                        this.Hide();
                        ph.Show();
                    }

                }
                else
                {
                    MessageBox.Show("No Record Matched..!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Fill All Feilds..!","Information",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void resetbtn_Click_1(object sender, EventArgs e)
        {
            childhoodfriendtxt.Clear();
            schoolnametxt.Clear();
            petnametxt.Clear();
        }
    }
}
