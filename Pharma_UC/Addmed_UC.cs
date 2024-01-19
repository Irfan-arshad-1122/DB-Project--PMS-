using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Project__PMS_.Pharma_UC
{
    public partial class Addmed_UC : UserControl
    {
        Functions fn = new Functions();
        string query;

        public Addmed_UC()
        {
            InitializeComponent();
        }

        private void Addmed_UC_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if(med_idtxt.Text != "" && mednametxt.Text != "" && medformulatxt.Text != "" && pricetxt.Text != "" && quantitytxt.Text != "" && supnamecb.Text != "")
            {
                if (pricetxt.Text != "" && int.Parse(pricetxt.Text) >= 0)
                {
                    if (quantitytxt.Text != "" && int.Parse(quantitytxt.Text) >= 0)
                    {
                        string medID = med_idtxt.Text;
                        string medname = mednametxt.Text;
                        string medformula = medformulatxt.Text;
                        string medcompany = medcompanytxt.Text;
                        int price = int.Parse(pricetxt.Text);
                        int quantity = int.Parse(quantitytxt.Text);
                        DateTime expdate = expdatetxt.Value;
                        string supname = supnamecb.Text;

                        query = "select Supplier_ID from supplier where Supplier_Name = '"+supname+"'";
                        DataSet ds = fn.getdata(query);
                        

                        query = "insert into Medicine (Med_ID,Med_Name,Med_Formula,Med_Company,Med_exp,Med_price,Med_quantity,Supplier_Name) values ('" + medID + "','" + medname + "','" + medformula + "','" + medcompany + "','" + expdate + "'," + price + "," + quantity + ",'"+ supname +"')";
                        fn.setdata(query, "Medicine Added Successfully..!");
                        clearall();
                    }
                    else
                    {
                        MessageBox.Show("Enter Valid Quantity..!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Enter Valid Price..!","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Enter All Data..!","Information",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }          
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            clearall();
        }
        public void clearall()
        {
            med_idtxt.Clear();
            mednametxt.Clear();
            medformulatxt.Clear();
            medcompanytxt.Clear();
            expdatetxt.ResetText();
            pricetxt.Clear();
            quantitytxt.Clear();
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
                catch(Exception)
                {
                    MessageBox.Show("Error in Connection with DataBase ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void med_idtxt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void quantitytxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
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

        private void med_idtxt_TextChanged(object sender, EventArgs e)
        {
            if (med_idtxt.Text.Length <= 10)
            { }
            else
            {
                MessageBox.Show("Maximum limit Reached..!");
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

        private void pricetxt_TextChanged(object sender, EventArgs e)
        {
            if (pricetxt.Text.Length <= 6)
            { }
            else
            {
                MessageBox.Show("Maximum limit Reached..!");
            }
        }

        private void quantitytxt_TextChanged(object sender, EventArgs e)
        {
            if (quantitytxt.Text.Length <= 8)
            { }
            else
            {
                MessageBox.Show("Maximum limit Reached..!");
            }
        }
    }
}
