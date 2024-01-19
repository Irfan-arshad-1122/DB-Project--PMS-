using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Project__PMS_.Supplier_UC
{
    public partial class updatesup_UC : UserControl
    {
        Functions fn = new Functions();
        string query;
        DataSet ds;

        public updatesup_UC()
        {
            InitializeComponent();
        }

        private void updatesup_UC_Load(object sender, EventArgs e)
        {

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            setdata();
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            setdata();
        }

        public void setdata()
        {
            query = "select * from supplier where Supplier_ID = '" + sup_idtxt.Text + "'";
            ds = fn.getdata(query);
            if (ds.Tables[0].Rows.Count != 0)
            {

                sup_idtxt.Text = ds.Tables[0].Rows[0][1].ToString();
                nametxt.Text = ds.Tables[0].Rows[0][2].ToString();
                phonetxt.Text = ds.Tables[0].Rows[0][3].ToString();
                nictxt.Text = ds.Tables[0].Rows[0][4].ToString();
                addresstxt.Text = ds.Tables[0].Rows[0][5].ToString();
                totalamlbl.Text = ds.Tables[0].Rows[0][6].ToString();
                payedamlbl.Text = ds.Tables[0].Rows[0][7].ToString();
                pendingamlbl.Text = ds.Tables[0].Rows[0][8].ToString();
            }
            else
            {
                MessageBox.Show("Supplier ID does not Exist..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void addbtn_Click(object sender, EventArgs e)
        {
            query = "select * from supplier where Supplier_ID = '" + sup_idtxt.Text + "'";
            ds = fn.getdata(query);
            if (ds.Tables[0].Rows.Count != 0)
            {
                if (nametxt.Text != "" && phonetxt.Text != "" && nictxt.Text != "" && addresstxt.Text != "")
                {
                    if (isvalid_numer(phonetxt.Text))
                    {
                        if (isvalid_cnic(nictxt.Text))
                        {
                            int total1, total2;

                            //updating total amount label
                            if (uptotalamtxt.Text != "")
                            {
                                int uptotal = int.Parse(uptotalamtxt.Text);
                                total1 = int.Parse(totalamlbl.Text);
                                if (uptotal >= 0)
                                {
                                    totalamlbl.Text = (uptotal + total1).ToString();
                                }
                            }
                            else
                            {
                                int uptotal = 0;
                                total1 = int.Parse(totalamlbl.Text);
                                if (uptotal >= 0)
                                {
                                    totalamlbl.Text = (uptotal + total1).ToString();
                                }
                            }

                            //updating payed amount label
                            if (uppayedamtxt.Text != "")
                            {
                                int uppayed = int.Parse(uppayedamtxt.Text);
                                total2 = int.Parse(payedamlbl.Text);
                                if (uppayed >= 0)
                                {
                                    payedamlbl.Text = (uppayed + total2).ToString();
                                }
                            }
                            else
                            {
                                int uppayed = 0;
                                total2 = int.Parse(payedamlbl.Text);
                                if (uppayed >= 0)
                                {
                                    payedamlbl.Text = (uppayed + total2).ToString();
                                }
                            }

                            if (int.Parse(uptotalamtxt.Text) < 0)
                            {
                                MessageBox.Show("Negative Amount Error..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                if (uppayedamtxt.Text != "" && int.Parse(uppayedamtxt.Text) > 0)
                                {
                                    //updating pending amount
                                    if (int.Parse(totalamlbl.Text) >= int.Parse(payedamlbl.Text))
                                    {
                                        pendingamlbl.Text = ((int.Parse(totalamlbl.Text) - int.Parse(payedamlbl.Text))).ToString();
                                        //updating data in the database

                                        string name = nametxt.Text;
                                        string phone = phonetxt.Text;
                                        string nic = nictxt.Text;
                                        string address = addresstxt.Text;
                                        int total = int.Parse(totalamlbl.Text);
                                        int payed = int.Parse(payedamlbl.Text);
                                        int pending = int.Parse(pendingamlbl.Text);

                                        query = "select * from supplier where Supplier_ID =  '" + sup_idtxt.Text + "'";
                                        DataSet ds = fn.getdata(query);

                                        query = "update supplier set Supplier_Name= '" + name + "',Supplier_Phone=" + phone + ",Supplier_NIC ='" + nic + "',Supplier_Address='" + address + "',Total_Amount=" + total + ",Pending_Amount=" + pending + ",Payed_Amount=" + payed + " where Supplier_ID = '" + sup_idtxt.Text + "'";
                                        fn.setdata(query, "Record Updated Successfully..!");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Total Amount is less \nThan Payed Amount..!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Negative Amount Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                            }
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Fill all Feilds..!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Enter Supplier ID \nTo Update Data","Information",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

        private void nametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void uptotalamtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void uppayedamtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void sup_idtxt_TextChanged(object sender, EventArgs e)
        {
            if (sup_idtxt.Text.Length <= 10)
            { }
            else
            {
                MessageBox.Show("Maximum limit Reached..!");
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

        private void uptotalamtxt_TextChanged(object sender, EventArgs e)
        {
            if (uptotalamtxt.Text.Length <= 8)
            { }
            else
            {
                MessageBox.Show("Maximum limit Reached..!");
            }
        }

        private void uppayedamtxt_TextChanged(object sender, EventArgs e)
        {
            if (uppayedamtxt.Text.Length <= 8)
            { }
            else
            {
                MessageBox.Show("Maximum limit Reached..!");
            }
        }
    }
}

