using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Project__PMS_.NewFolder1
{
    public partial class Viewuser_UC : UserControl
    {
        Functions fn = new Functions();
        string query;
        DataSet ds;
        string current_user;

        public Viewuser_UC()
        {
            InitializeComponent();
        }

        public string ID
        {
            set {  current_user = value; }
        }

        private void Viewuser_UC_Load(object sender, EventArgs e)
        {
            query = "select * from users";
            ds = fn.getdata(query);

            userdatagridview.DataSource = ds.Tables[0];
        }

        private void usernametxt_TextChanged(object sender, EventArgs e)
        {

            if (usernametxt.Text.Length <= 25)
            {
                query = "select * from users where username like '" + usernametxt.Text + "%' ";
                ds = fn.getdata(query);

                userdatagridview.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Maximum limit Reached..!");
            }
           
        }

        string username;
        private void userdatagridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            username = userdatagridview.Rows[e.RowIndex].Cells[6].Value.ToString();

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you Sure..?","Delete Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (current_user != username)
                {
                    query = "delete from users where username = '"+username+"'";
                    fn.setdata(query,"User deleted Successfully..!");
                    Viewuser_UC_Load(this, null);
                }
                else
                {
                    MessageBox.Show("You are Trying to delete \nYour own Profile..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            Viewuser_UC_Load(this, null);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userdatagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
