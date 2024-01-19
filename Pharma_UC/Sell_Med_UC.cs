using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Xml.Linq;



namespace DB_Project__PMS_.Pharma_UC
{
    public partial class Sell_Med_UC : UserControl
    {
        Functions fn = new Functions();
        string query;
        DataSet ds;

        public Sell_Med_UC()
        {
            InitializeComponent();
        }

        private void Sell_Med_UC_Load(object sender, EventArgs e)
        {
            listBoxMedicines.Items.Clear();
            query = "select Med_Name from Medicine where Med_exp >= getdate() and Med_quantity >'0'";
            ds = fn.getdata(query);

            for(int i = 0;  i< ds.Tables[0].Rows.Count; i++)
            {
                listBoxMedicines.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }

        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            Sell_Med_UC_Load(this, null);
        }

        //setting functionality for search text box
        private void searchtxt_TextChanged(object sender, EventArgs e)
        {
            if (searchtxt.Text.Length <= 30)
            {
                listBoxMedicines.Items.Clear();
                query = "select Med_Name from Medicine where Med_Name like '" + searchtxt.Text + "%' and Med_exp >= getdate() and Med_quantity > '0'";
                ds = fn.getdata(query);

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    listBoxMedicines.Items.Add(ds.Tables[0].Rows[i][0].ToString());
                }
            }
            else
            {
                MessageBox.Show("Maximum limit Reached..!");
            }
           
        }

        //setting data into listbox
        private void listBoxMedicines_SelectedIndexChanged(object sender, EventArgs e)
        {
            noofunittxt.Clear();

            string name = listBoxMedicines.GetItemText(listBoxMedicines.SelectedItem);

            mednamelbl.Text = name;

            query = "select Med_ID,Med_exp,Med_Price from Medicine where Med_Name = '"+name+"'";
            ds = fn.getdata(query);
            try
            {
                medidlbl.Text = ds.Tables[0].Rows[0][0].ToString();
                expdatelbl.Text = ds.Tables[0].Rows[0][1].ToString();
                priceperunitlbl.Text = ds.Tables[0].Rows[0][2].ToString();
            }
            catch { }
        }

        //no of units calculation
        private void noofunittxt_TextChanged(object sender, EventArgs e)
        {
            if (noofunittxt.Text.Length <= 8)
            {
                if (noofunittxt.Text != "")
                {
                    int unitprice = int.Parse(priceperunitlbl.Text);
                    int no_of_units = int.Parse(noofunittxt.Text);
                    int total_amount = unitprice * no_of_units;
                    totalpricetxt.Text = total_amount.ToString();

                }
                else
                {
                    totalpricetxt.ResetText();
                }
            }
            else
            {
                MessageBox.Show("Miximum limit Reached..!");
            }
        }

        //add to cart button functionality
        protected int n,units=0,totalprice, totalamount = 0;
        protected int quantity, newquantity;
        private void addtocartbtn_Click(object sender, EventArgs e)
        {
            if(medidlbl.Text != "")
            {
                if (customertxt.Text != "" && noofunittxt.Text != "")
                {
                    if (int.Parse(noofunittxt.Text) > 0)
                    {
                        query = "select Med_quantity from Medicine where Med_ID = '" + medidlbl.Text + "'";
                        ds = fn.getdata(query);

                        quantity = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                        newquantity = quantity - int.Parse(noofunittxt.Text);

                        if (newquantity >= 0)
                        {
                            //setting data into datagrid iew
                            n = purchasemeddatagrid.Rows.Add();
                            purchasemeddatagrid.Rows[n].Cells[0].Value = medidlbl.Text;
                            purchasemeddatagrid.Rows[n].Cells[1].Value = customertxt.Text;
                            purchasemeddatagrid.Rows[n].Cells[2].Value = mednamelbl.Text;
                            
                            purchasemeddatagrid.Rows[n].Cells[3].Value = priceperunitlbl.Text;
                            purchasemeddatagrid.Rows[n].Cells[4].Value = noofunittxt.Text;
                            purchasemeddatagrid.Rows[n].Cells[5].Value = totalpricetxt.Text;

                            //calculating total amount
                            totalamount = totalamount + int.Parse(totalpricetxt.Text);
                            totalRSlbl.Text = "Rs. " + totalamount.ToString();

                            //updating stock in the database
                            query = "update Medicine set Med_quantity = " + newquantity + " where Med_ID = '" + medidlbl.Text + "'";
                            fn.setdata(query, "Medicine Added..!");

                            string medid = medidlbl.Text;
                            string medname = mednamelbl.Text;
                            int priceperunit = int.Parse(priceperunitlbl.Text);
                            units = int.Parse(noofunittxt.Text);
                            totalprice = int.Parse(totalpricetxt.Text);
                            string customer = customertxt.Text;

                            query = "insert into Sales (Med_ID,Med_Name,Price_Per_Unit,No_of_Units,Total_Price,Date,Customer_Name) values ('" + medid + "','" + medname + "'," + priceperunit + "," + units + "," + totalprice + ",getdate(),'" + customer + "') ";
                            fn.Setdatawithoutmessage(query);
                        }
                        else
                        {
                            MessageBox.Show("Medicine out of Stock..!\n Only " + quantity + " left", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        clearall();
                        Sell_Med_UC_Load(this, null);
                    }
                }
                else
                {
                    MessageBox.Show("Enter Customer Name \nAnd No of Units..!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Select Medicine First..!","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        //removing added medicine record from data grid view
        int valueAmount;
        string valueid, customername;
        protected int noofunits;
        private void purchasemeddatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (purchasemeddatagrid.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = purchasemeddatagrid.SelectedRows[0];

                // Retrieve the values from the selected row
                valueid = selectedRow.Cells["Column1"].Value.ToString();
                customername = selectedRow.Cells["Med_Name"].Value.ToString();
                noofunits = int.Parse(selectedRow.Cells["No_of_Unit"].Value.ToString());

                // Use the retrieved values as needed
                Console.WriteLine("Selected MedID: " + valueid);
                Console.WriteLine("Selected Med Name: " + customername);
                Console.WriteLine("Selected Quantity: " + noofunits);
            }
            else
            {
                // No row selected, handle the situation accordingly
                Console.WriteLine("No row selected.");
            }

        }

        //coding for remove button
        private void removebtn_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(valueid) && purchasemeddatagrid.SelectedRows.Count > 0)
            {
                try
                {
                    purchasemeddatagrid.Rows.RemoveAt(this.purchasemeddatagrid.SelectedRows[0].Index);
                }
                catch
                {

                }
                finally
                {
                    //totalprice = 0;
                    query = " select Med_quantity from Medicine where Med_ID = '"+valueid+"'";
                    ds = fn.getdata(query);

                    quantity = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                    quantity = quantity + noofunits;

                    query = "update Medicine set Med_quantity = "+quantity+" where Med_ID = '"+valueid+"'";
                    fn.setdata(query, "Medicine Removed from Cart..!");

                    query = "delete from Sales where Med_ID = '" + valueid + "' And Customer_Name = '" + customername + "'";
                    fn.Setdatawithoutmessage(query);

                    //units = units - noofunits;
                    //query = "update Sales set No_of_Units = " + units + " where Med_ID = '"+valueid+"' And Customer_Name = '"+customername+"'";
                    //fn.Setdatawithoutmessage(query);

                    //query = "update Sales set Total_Price = " + 0 + " where Med_ID = '" + valueid + "' And Customer_Name = '" + customername + "'";
                    //fn.Setdatawithoutmessage(query);


                    totalamount = totalamount - totalprice;
                    totalRSlbl.Text = "Rs."+totalamount.ToString();

                }
                Sell_Med_UC_Load(this, null);

            }
            else
            {
                MessageBox.Show("Null");
            }
        }

        private void customernametxt_TextChanged(object sender, EventArgs e)
        {
            if(customertxt.Text.Length <=25)
            { }
            else
            {
                MessageBox.Show("Maximum limit Reached..!");
            }
        }


        //purchase and print button coding
        private void purchaseprintbtn_Click(object sender, EventArgs e)
        {

            PrintDocument pd = new PrintDocument();

            //    pd.DefaultPageSettings.PaperSize = new PaperSize("Custom", 250, 500);
            //  PrintDocument pd = new PrintDocument();
           // PD.DefaultPageSettings.PaperSize = new PaperSize("Custom", 350, 500);
            pd.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);

            // Print the document
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = pd;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }

            totalamount = 0;
            totalRSlbl.Text = "Rs. 00";
            purchasemeddatagrid.DataSource = 0;
            customertxt.Clear();
        }
        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            PrintDocument PD = new PrintDocument();
            PD.DefaultPageSettings.PaperSize = new PaperSize("Custom", 350, 500);
            PD.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
            Font f8 = new Font("Calibri", 8, FontStyle.Regular);
            Font f10 = new Font("Calibri", 10, FontStyle.Regular);
            Font f10b = new Font("Calibri", 10, FontStyle.Bold);
            Font f14 = new Font("Calibri", 14, FontStyle.Bold);
            Font f10a = new Font("Calibri", 14, FontStyle.Bold | FontStyle.Italic);

            int leftmargin = PD.DefaultPageSettings.Margins.Left;
            int centermargin = PD.DefaultPageSettings.PaperSize.Width / 2;
            int rightmargin = PD.DefaultPageSettings.PaperSize.Width;

            StringFormat right = new StringFormat();
            StringFormat center = new StringFormat();
            right.Alignment = StringAlignment.Far;
            center.Alignment = StringAlignment.Center;

            string line = "----------------------------------------------------------------------------------------------------";
            e.Graphics.DrawString("Muhammad Abdullah Pharmacy", f10b, Brushes.Black, centermargin, 5, center);
            e.Graphics.DrawString("Haripur", f10, Brushes.Black, centermargin, 18, center);
            e.Graphics.DrawString("Tel +92*****", f10, Brushes.Black, centermargin, 33, center);
 
            e.Graphics.DrawString("Customer Name: ", f8, Brushes.Black, 0, 50);
            e.Graphics.DrawString(customertxt.Text , f8, Brushes.Black, 80, 50);
            
            e.Graphics.DrawString("Date : ", f8, Brushes.Black, 0, 60);
            e.Graphics.DrawString(DateTime.Now.ToString("dd-MM-yyyy"), f8, Brushes.Black, 30, 60);
            e.Graphics.DrawString("Time : ", f8, Brushes.Black, 260, 60);
            e.Graphics.DrawString(DateTime.Now.ToString("hh:mm:ss"), f8, Brushes.Black, 300, 60);
            e.Graphics.DrawString(line, f8, Brushes.Black, 0, 70);
            e.Graphics.DrawString("Item Name", f10b, Brushes.Black, 0, 80);
            e.Graphics.DrawString("Unit Price", f10b, Brushes.Black, 90, 80);
            e.Graphics.DrawString("Quantity", f10b, Brushes.Black, 180, 80);
            e.Graphics.DrawString("Total Amount", f10b, Brushes.Black, 260, 80);


            double totalpricee = 0;

           

            int yPos = 100;

            foreach (DataGridViewRow row in purchasemeddatagrid.Rows)
            {
                string medname = row.Cells["Med_Name"].Value.ToString();
                int uprice = Convert.ToInt32(row.Cells["Unit_Price"].Value);
                double qnt = Convert.ToDouble(row.Cells["No_of_Unit"].Value);
                double tprice = Convert.ToDouble(row.Cells["Total_Amount"].Value);
// double totalprice = Convert.ToDouble(total.Text);

                // Retrieve prod_id based on product name
                e.Graphics.DrawString(medname, f10, Brushes.Black, 0, yPos);
                e.Graphics.DrawString(uprice.ToString(), f10, Brushes.Black, 90, yPos);
                e.Graphics.DrawString(qnt.ToString(), f10, Brushes.Black, 180, yPos);
                e.Graphics.DrawString(tprice.ToString(), f10, Brushes.Black, 260, yPos);
            }


            

                yPos += 20;
            

            e.Graphics.DrawString(line, f8, Brushes.Black, 0, yPos);
            e.Graphics.DrawString("Total :", f10b, Brushes.Black, 260, 10 + yPos);
            e.Graphics.DrawString(totalRSlbl.Text  , f10b, Brushes.Black, 299, 10 + yPos);
            e.Graphics.DrawString("Thanks You!", f10a, Brushes.Black, centermargin, 40 + yPos, center);



// DataGridView.Rows.Clear();
        }



        //clearing all the text boxes
        private void clearall()
        {
            medidlbl.ResetText();
            mednamelbl.ResetText();
            expdatelbl.ResetText();
            priceperunitlbl.ResetText();
            noofunittxt.Clear();
            totalpricetxt.ResetText();
        }

        private void customertxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void noofunittxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void searchtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
