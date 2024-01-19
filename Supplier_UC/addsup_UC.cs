using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Project__PMS_.Supplier_UC
{
    public partial class addsup_UC : UserControl
    {
        Functions fn = new Functions();
        string query;

        public addsup_UC()
        {
            InitializeComponent();
        }

        private void addsup_UC_Load(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (supidtxt.Text != "" && snametxt.Text != "" && sphonetxt.Text != "" && snictxt.Text != "" && saddresstxt.Text != "")
                {
                    if (isvalid_numer(sphonetxt.Text))
                    {
                        if (isvalid_cnic(nictxt.Text))
                        {
                            if (stotalamtxt.Text != "" && int.Parse(stotalamtxt.Text) >= 0)
                            {
                                if (spayedamtxt.Text != "" && int.Parse(spayedamtxt.Text) >= 0)
                                {
                                    if (int.Parse(stotalamtxt.Text) >= int.Parse(spayedamtxt.Text))
                                    {
                                        pendingamlbl.Text = (int.Parse(stotalamtxt.Text) - int.Parse(spayedamtxt.Text)).ToString();
                                    }
                                    else
                                    {
                                        pendingamlbl.Text = (0).ToString();
                                    }

                                    string sup_id = supidtxt.Text;
                                    string name = snametxt.Text;
                                    string sphone = sphonetxt.Text;
                                    string nic = snictxt.Text;
                                    string address = saddresstxt.Text;
                                    int totalamount = int.Parse(stotalamtxt.Text);
                                    int payedamount = int.Parse(spayedamtxt.Text);
                                    int pendingamount = int.Parse(pendingamlbl.Text);

                                    if (totalamount == (payedamount + pendingamount))
                                    {
                                        query = " insert into supplier (Supplier_ID,Supplier_Name,Supplier_Phone,Supplier_NIC,Supplier_Address,Total_Amount,Payed_Amount,Pending_Amount) values ('" + sup_id + "','" + name + "','" + sphone + "','" + nic + "','" + address + "'," + totalamount + "," + payedamount + "," + pendingamount + ")";
                                        fn.setdata(query, "Record Added Successfully");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Total amount is not Equal \nTo Payed and Pending Amount", "Incorrect Amount", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Enter Valid Amount", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Enter valid Amount", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Fill all Feilds..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
             }
            catch (Exception)
            {
                MessageBox.Show("Fill all Feilds..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
            
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            clearall();
        }
        public void clearall()
        {
            supidtxt.Clear();
            snametxt.Clear();
            sphonetxt.ResetText();
            snictxt.Clear();
            saddresstxt.Clear();
            stotalamtxt.ResetText();
            spayedamtxt.ResetText();
            pendingamlbl.ResetText();
        }


        //checking whether cnic is valid or not
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
                MessageBox.Show("NIC format is Incorrect..!");
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

        private void supidtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void stotalamtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void spayedamtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void snametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void supidtxt_TextChanged(object sender, EventArgs e)
        {
            if (supidtxt.Text.Length <= 10)
            { }
            else
            {
                MessageBox.Show("Maximum limit Reached..!");
            }
        }

        private void snametxt_TextChanged(object sender, EventArgs e)
        {
            if (snametxt.Text.Length <= 25)
            { }
            else
            {
                MessageBox.Show("Maximum limit Reached..!");
            }
        }

        private void sphonetxt_TextChanged(object sender, EventArgs e)
        {
            if (sphonetxt.Text.Length <= 11)
            { }
            else
            {
                MessageBox.Show("Maximum limit Reached..!");
            }
        }

        private void snictxt_TextChanged(object sender, EventArgs e)
        {
            if (snictxt.Text.Length <= 15)
            { }
            else
            {
                MessageBox.Show("Maximum limit Reached..!");
            }
        }

        private void stotalamtxt_TextChanged(object sender, EventArgs e)
        {
            if (stotalamtxt.Text.Length <= 10)
            { }
            else
            {
                MessageBox.Show("Maximum limit Reached..!");
            }
        }

        private void spayedamtxt_TextChanged(object sender, EventArgs e)
        {
            if (spayedamtxt.Text.Length <= 10)
            { }
            else
            {
                MessageBox.Show("Maximum limit Reached..!");
            }
        }
    }
}
