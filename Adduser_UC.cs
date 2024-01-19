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

namespace DB_Project__PMS_
{
    public partial class Adduser_UC : UserControl
    {
        Functions fn = new Functions();
        string query;

        public Adduser_UC()
        {
            InitializeComponent();
        }

        private void Adduser_UC_Load(object sender, EventArgs e)
        {

        }

        private void signuptbtn_Click(object sender, EventArgs e)
        {
            if (userroletxt.Text != "" && nametxt.Text != "" && dobtxt.Text != "" && phonetxt.Text != "" && nictxt.Text != "" && usernametxt.Text != "" && passwordtxt.Text != "" && childhoodfriendtxt.Text != "" && schoolnametxt.Text != "" && petnametxt.Text != "")
            {
                
                if (isvalid_cnic(nictxt.Text))
                {
                    if (isvalid_numer(phonetxt.Text))
                    {
                        string role = userroletxt.Text;
                        string name = nametxt.Text;
                        string dob = dobtxt.Text;
                        Int64 phone = Int64.Parse(phonetxt.Text);
                        string nic = nictxt.Text;
                        string username = usernametxt.Text;
                        string password = passwordtxt.Text;
                        string question1 = childhoodfriendtxt.Text;
                        string question2 = schoolnametxt.Text;
                        string question3 = petnametxt.Text;

                        try
                        {
                            query = "insert into users (user_role,name,dob,mobile,nic,username,password , Childhood_Friend, First_Attended_School,Favourite_Pet) values ('" + role + "','" + name + "','" + dob + "'," + phone + ",'" + nic + "','" + username + "','" + password + "','" + question1 + "','" + question2 + "','" + question3 + "')";
                            fn.setdata(query, "Sign Up Successfull..!");

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Username Already Exist..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Fill all Feilds..!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            clearall();
        }

        private void usernametxt_TextChanged(object sender, EventArgs e)
        {
            if (usernametxt.Text.Length <= 20)
            {
                query = "select * from users where username =  '" + usernametxt.Text + "'";
                DataSet ds = fn.getdata(query);

                if (ds.Tables[0].Rows.Count == 0)
                {
                    usererrorlbl.Visible = false;
                }
                else
                {
                    usererrorlbl.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Maximum limit Reached..!");
            }
            
        }

        public void clearall()
        {
            userroletxt.SelectedIndex = -1;
            nametxt.Clear();
            dobtxt.ResetText();
            phonetxt.Clear();
            nictxt.Clear();
            usernametxt.Clear();
            passwordtxt.Clear();
            childhoodfriendtxt.Clear();
            schoolnametxt.Clear();
            petnametxt.Clear();
        }


        //checking whether cnic is valid or not
        public bool isvalid_cnic(string cnic)
        {
            Regex check = new Regex(@"^[0-9]{5}-[0-9]{7}-[0-9]{1}$");
            bool valid = false;
            valid = check.IsMatch(cnic);
            if(valid == true)
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
                return true;
            }
            else
            {
                MessageBox.Show("Number is not Valid..!");
                return false;
            }
        }

        //limiting username to letters and numbers only
        private void usernametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
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

        private void phonetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void nametxt_TextChanged(object sender, EventArgs e)
        {
            if(nametxt.Text.Length <= 30)
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
            if (passwordtxt.Text.Length >= 6)
            {
                if (passwordtxt.Text.Length <= 20)
                { }
                else
                {
                    MessageBox.Show("Maximum limit Reached..!");
                }
            }
            else 
            {
                MessageBox.Show("Password Should be At ..!");
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
            if (petnametxt.Text.Length <= 25)
            { }
            else
            {
                MessageBox.Show("Maximum limit Reached..!");
            }
        }
    }
}
