using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Project__PMS_.Pharma_UC
{
    public partial class modifymed_UC : UserControl
    {
        Functions fn = new Functions();
        string query;

        public modifymed_UC()
        {
            InitializeComponent();
        }

        private void modifymed_UC_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
        }

        //searching medicine record
        private void searchbtn_Click(object sender, EventArgs e)
        {
            if (med_idtxt.Text != "")
            {
               
                    query = "select * from Medicine where Med_ID = '" + med_idtxt.Text + "'";
                    DataSet ds = fn.getdata(query);

                    if (ds.Tables[0].Rows.Count != 0)
                    {
                            med_idtxt.Text = ds.Tables[0].Rows[0][0].ToString();
                            mednametxt.Text = ds.Tables[0].Rows[0][1].ToString();
                            medformulatxt.Text = ds.Tables[0].Rows[0][2].ToString();
                            medcompanytxt.Text = ds.Tables[0].Rows[0][3].ToString();
                            medexptxt.Text = ds.Tables[0].Rows[0][4].ToString();
                            medavquantitylbl.Text = ds.Tables[0].Rows[0][6].ToString();
                            pricetxt.Text = ds.Tables[0].Rows[0][5].ToString();
                            supnamecb.Text = ds.Tables[0].Rows[0][7].ToString();

                    }
                    else
                    {
                        MessageBox.Show("No Medicine with ID : " + med_idtxt.Text + " exist.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
               
            }
            else
            {
                clearall();
                MessageBox.Show("Enter Medicine ID to Search Data..!","Information",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            setall();
        }

        //updating Medicine Record
        int totalquantity;
        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (mednametxt.Text != "" && medformulatxt.Text != "" && medcompanytxt.Text != "" && medexptxt.Text != "")
            {
                if (pricetxt.Text != "" && int.Parse(pricetxt.Text) >= 0)
                {
                    if (medaddqutxt.Text != "" && int.Parse(medaddqutxt.Text) >= 0)
                    {
                        string med_name = mednametxt.Text;
                        string med_formula = medformulatxt.Text;
                        string med_company = medcompanytxt.Text;
                        DateTime exp_date = DateTime.Parse(medexptxt.Text);
                        int avl_quantity = int.Parse(medavquantitylbl.Text);
                        int add_quantity = int.Parse(medaddqutxt.Text);
                        int unit_price = int.Parse(pricetxt.Text);

                        totalquantity = avl_quantity + add_quantity;
                        medavquantitylbl.Text = totalquantity.ToString();

                        query = "update Medicine set Med_Name = '" + med_name + "', Med_Formula = '" + med_formula + "', Med_Company = '" + med_company + "', Med_exp = '" + exp_date + "', Med_price=" + unit_price + ",Med_Quantity = " + totalquantity + ", Supplier_Name = '"+supnamecb.Text+"' where Med_ID = '" + med_idtxt.Text + "'";
                        fn.setdata(query, "Medicine Record Updated Successfully..!");
                    }
                    else
                    {
                        string med_name = mednametxt.Text;
                        string med_formula = medformulatxt.Text;
                        string med_company = medcompanytxt.Text;
                        DateTime exp_date = DateTime.Parse(medexptxt.Text);
                        int avl_quantity = int.Parse(medavquantitylbl.Text);
                        int add_quantity = 0;
                        int unit_price = int.Parse(pricetxt.Text);

                        totalquantity = avl_quantity + add_quantity;

                        query = "update Medicine set Med_Name = '" + med_name + "', Med_Formula = '" + med_formula + "', Med_Company = '" + med_company + "', Med_exp = '" + exp_date + "', Med_price=" + unit_price + ",Med_Quantity = " + totalquantity + " , Supplier_Name = '"+supnamecb.Text+"' where Med_ID = '" + med_idtxt.Text + "'";
                        fn.setdata(query, "Medicine Record Updated Successfully..!");
                    }
                }
                else
                {
                    MessageBox.Show("Enter Valid Price","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Fill all Feilds","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            clearall();

        }

        // setting data into text boxes
        public void setall()
        {
            query = "select * from Medicine where Med_ID = '" + med_idtxt.Text + "'";
            DataSet ds = fn.getdata(query);

            if (ds.Tables[0].Rows.Count != 0)
            {

                med_idtxt.Text = ds.Tables[0].Rows[0][1].ToString();
                mednametxt.Text = ds.Tables[0].Rows[0][2].ToString();
                medformulatxt.Text = ds.Tables[0].Rows[0][3].ToString();
                medcompanytxt.Text = ds.Tables[0].Rows[0][4].ToString();
                medexptxt.Text = ds.Tables[0].Rows[0][5].ToString();
                medavquantitylbl.Text = ds.Tables[0].Rows[0][7].ToString();
                pricetxt.Text = ds.Tables[0].Rows[0][6].ToString();
            }
            else
            {
                MessageBox.Show("Medicine ID does not Exist..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //clearing all the raw data from the boxes
        public void clearall()
        {
            med_idtxt.Clear();
            mednametxt.Clear();
            medformulatxt.Clear();
            medcompanytxt.Clear();
            medexptxt.ResetText();
            medavquantitylbl.ResetText();
            pricetxt.Clear();

            if(medaddqutxt.Text != "0")
            {
                medaddqutxt.Text = "0";
            }
            else
            {
                medaddqutxt.Text = "0";
            }
        }


        private void LoadSuppliers()
        {
            // Clear existing items in the ComboBox
            supnamecb.Items.Clear();

            // Define your connection string
            string connectionString = "data source=DESKTOP-16V99E1\\SQLEXPRESS; database=PMS;integrated security=True";

            // Create a SqlConnection using the connection string
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Supplier_Name FROM supplier";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Create a SqlDataReader to read the data
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Loop through the rows in the reader
                            while (reader.Read())
                            {
                                // Read the Supplier_Name value from the current row

                                string supplierName = reader.GetString(0);
                                // Add the supplierName to the ComboBox
                                supnamecb.Items.Add(supplierName);
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error in Connection with DataBase ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void mednametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void medcompanytxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void medformulatxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void medaddqutxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void pricetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void mednametxt_TextChanged(object sender, EventArgs e)
        {
            if (mednametxt.Text.Length <= 30)
            { }
            else
            {
                MessageBox.Show("Maximum limit Reached..!");
            }
        }

        private void med_idtxt_TextChanged(object sender, EventArgs e)
        {
            if (med_idtxt.Text.Length <= 10)
            { }
            else
            {
                MessageBox.Show("Maximum limit Reached..!");
            }
        }

        private void medformulatxt_TextChanged(object sender, EventArgs e)
        {
            if (medformulatxt.Text.Length <= 30)
            { }
            else
            {
                MessageBox.Show("Maximum limit Reached..!");
            }
        }

        private void medcompanytxt_TextChanged(object sender, EventArgs e)
        {
            if (medcompanytxt.Text.Length <= 60)
            { }
            else
            {
                MessageBox.Show("Maximum limit Reached..!");
            }
        }

        private void medaddqutxt_TextChanged(object sender, EventArgs e)
        {
            if (medaddqutxt.Text.Length <= 8)
            { }
            else
            {
                MessageBox.Show("Maximum limit Reached..!");
            }
        }

        private void pricetxt_TextChanged(object sender, EventArgs e)
        {
            if (pricetxt.Text.Length <= 8)
            { }
            else
            {
                MessageBox.Show("Maximum limit Reached..!");
            }
        }
    }
}
