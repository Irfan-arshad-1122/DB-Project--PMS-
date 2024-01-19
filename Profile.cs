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
    public partial class Profile : Form
    {
        string user = "";

        public string ID
        {
            get { return user.ToString(); }
        }
        public Profile( string username)
        {
            InitializeComponent();
            user = username;
            usernamelbl.Text = username;
            viewuser_UC1.ID = ID;
            profile_UC1.ID = ID;
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            viewuser_UC1.Visible = false;
            viewuserbtn.PerformClick();
            adduser_UC1.Visible=false;
            profile_UC1.Visible = false;
            profileupdate_UC1.Visible = false;

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            viewuser_UC1.Visible = true;
            viewuser_UC1.BringToFront();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            profile_UC1.Visible=true;
            profile_UC1.BringToFront();
        }

        private void adduserbtn_Click(object sender, EventArgs e)
        {
            adduser_UC1.Visible = true;
            adduser_UC1.BringToFront();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin(user);
            this.Hide();
            admin.Show();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            profileupdate_UC1.Visible = true;
            profileupdate_UC1.BringToFront();
        }
    }
}
