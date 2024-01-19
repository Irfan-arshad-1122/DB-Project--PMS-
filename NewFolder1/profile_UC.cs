using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Project__PMS_.NewFolder1
{
    public partial class profile_UC : UserControl
    {
        Functions fn = new Functions();
        string query;
        DataSet ds;

        public profile_UC()
        {
            InitializeComponent();
        }

        public string ID
        {
            set { usernamelbl.Text = value; }
        }

        private void profile_UC_Load(object sender, EventArgs e)
        {
            query = "select * from users where username = '" + usernamelbl.Text + "'";
            ds = fn.getdata(query);

            userroletxt.Text = ds.Tables[0].Rows[0][1].ToString();
            nametxt.Text = ds.Tables[0].Rows[0][2].ToString();
            dobtxt.Text = ds.Tables[0].Rows[0][3].ToString();
            phonetxt.Text = ds.Tables[0].Rows[0][4].ToString();
            nictxt.Text = ds.Tables[0].Rows[0][5].ToString();
            passwordtxt.Text = ds.Tables[0].Rows[0][7].ToString();
            childhoodfriendtxt.Text = ds.Tables[0].Rows[0][8].ToString();
            schoolnametxt.Text = ds.Tables[0].Rows[0][9].ToString();
            petnametxt.Text = ds.Tables[0].Rows[0][10].ToString();
        }

        private void updatebtn_Click_1(object sender, EventArgs e)
        {
            if (userroletxt.Text != "" && nametxt.Text != "" && dobtxt.Text != "" && phonetxt.Text != "" && nictxt.Text != "" && passwordtxt.Text != "" && childhoodfriendtxt.Text != "" && schoolnametxt.Text != "" && petnametxt.Text != "")
            {
                if (isvalid_cnic(nictxt.Text))
                {
                    if(isvalid_numer(phonetxt.Text))
                    {
                        if (isvalid_cnic(nictxt.Text))
                        {
                            string role = userroletxt.Text;
                            string name = nametxt.Text;
                            string dob = dobtxt.Text;
                            Int64 phone = Int64.Parse(phonetxt.Text);
                            string nic = nictxt.Text;
                            string username = usernamelbl.Text;
                            string password = passwordtxt.Text;
                            string question1 = childhoodfriendtxt.Text;
                            string question2 = schoolnametxt.Text;
                            string question3 = petnametxt.Text;

                            query = "update users set user_role = '" + role + "', name= '" + name + "',dob='" + dob + "',mobile=" + phone + ",nic='" + nic + "',password='" + password + "',Childhood_Friend = '" + question1 + "',First_Attended_School = '" + question2 + "' , Favourite_Pet = '" + question3 + "' where username = '" + usernamelbl.Text + "'";
                            fn.setdata(query, "Profile Updated Successfully..!");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Fill all Feilds..!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //reset button functionality
        private void resetbtn_Click_1(object sender, EventArgs e)
        {
            profile_UC_Load(this, null);
        }

        //validating NIC text box
        public bool isvalid_cnic(string cnic)
        {
            Regex check = new Regex(@"^[0-9]{5}-[0-9]{7}-[0-9]{1}$");
            bool valid = false;
            valid = check.IsMatch(cnic);
            if (valid == true)
            {
                return valid;
            }
            else
            {
                MessageBox.Show("NIC is not Valid..!");
                return false;
            }
        }
        public bool isvalid_numer(string number)
        {
            Regex check = new Regex(@"^[0-9]{11}$");
            bool valid = false;
            valid = check.IsMatch(number);
            if (valid == true)
            {
                return valid;
            }
            else
            {
                MessageBox.Show("Number is not Valid..!");
                return false;
            }
        }

        private void phonetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void nametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void childhoodfriendtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void schoolnametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void petnametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void nametxt_TextChanged(object sender, EventArgs e)
        {

            if (nametxt.Text.Length <= 25)
            { }
            else
            {
                MessageBox.Show("Maximum limit Reached..!");
            }
        }

        private void phonetxt_TextChanged(object sender, EventArgs e)
        {

            if (phonetxt.Text.Length <= 11)
            { }
            else
            {
                MessageBox.Show("Maximum limit Reached..!");
            }
        }

        private void nictxt_TextChanged(object sender, EventArgs e)
        {

            if (nictxt.Text.Length <= 15)
            { }
            else
            {
                MessageBox.Show("Maximum limit Reached..!");
            }
        }

        private void passwordtxt_TextChanged(object sender, EventArgs e)
        {

            if (passwordtxt.Text.Length <= 20)
            { }
            else
            {
                MessageBox.Show("Maximum limit Reached..!");
            }
        }

        private void childhoodfriendtxt_TextChanged(object sender, EventArgs e)
        {

            if (childhoodfriendtxt.Text.Length <= 25)
            { }
            else
            {
                MessageBox.Show("Maximum limit Reached..!");
            }
        }

        private void schoolnametxt_TextChanged(object sender, EventArgs e)
        {

            if (schoolnametxt.Text.Length <= 60)
            { }
            else
            {
                MessageBox.Show("Maximum limit Reached..!");
            }
        }

        private void petnametxt_TextChanged(object sender, EventArgs e)
        {

            if (petnametxt.Text.Length <= 15)
            { }
            else
            {
                MessageBox.Show("Maximum limit Reached..!");
            }
        }
    }
}
