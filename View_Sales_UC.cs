using DGVPrinterHelper;
using System;
using System.Collections;
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
    public partial class View_Sales_UC : UserControl
    {
        Functions fn = new Functions();
        string query;

        public View_Sales_UC()
        {
            InitializeComponent();
        }

        int totalincome = 0;
        private void View_Sales_UC_Load(object sender, EventArgs e)
        {
            setlabel.Visible = true;
            setlabel.Text = "Total Sales:";
            query = "select S_No,Customer_Name,Date,Med_Name,Price_Per_Unit,No_of_Units,Total_Price from Sales";
            setlabel.ForeColor = Color.Black;
            DataSet ds = fn.getdata(query);
            salesdatagridview.DataSource = ds.Tables[0];

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                totalincome = totalincome + int.Parse(ds.Tables[0].Rows[i][6].ToString());
            }
            totalincometxt.Text = "Total Income : " + totalincome.ToString();

            
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            View_Sales_UC_Load(this, null);
        }

        private void salesdatagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            totalincome = 0;
            
            DateTime startDate = fromdatetxt.Value.Date;
            DateTime endDate = todatetxt.Value.Date;

            // Validate that the start date is before or equal to the end date
            if (startDate > endDate)
            {
                MessageBox.Show("Start date cannot be after the end date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Construct the SQL query
            string query = $"select S_No,Customer_Name,Date,Med_Name,Price_Per_Unit,No_of_Units,Total_Price from Sales WHERE Date >= '{startDate:yyyy-MM-dd}' AND Date <= '{endDate:yyyy-MM-dd}'";
            DataSet searchResults = fn.getdata(query);

            // Do something with the search results
            if (searchResults.Tables[0].Rows.Count != 0)
            {
                salesdatagridview.DataSource = searchResults.Tables[0];

                for (int i = 0; i < searchResults.Tables[0].Rows.Count; i++)
                {
                    totalincome = totalincome + int.Parse(searchResults.Tables[0].Rows[i][6].ToString());
                }
                totalincometxt.Text = "Total Income : " + totalincome.ToString();
            }
            else
            {
                MessageBox.Show("No records found within the specified date range.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                totalincometxt.Text = "Total Income : 00";
            }
            

        }

        private void printreport_Click(object sender, EventArgs e)
        {
            DGVPrinter print = new DGVPrinter();
            print.Title = "\nSales Report\n";
            //print.SubTitle = string.Format("Medicines Bill");
            print.SubTitle = string.Format("Date:-  {0}  \n", DateTime.Now.Date);
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.PorportionalColumns = true;
            print.HeaderCellAlignment = StringAlignment.Near;
            print.Footer = totalincometxt.Text;
            print.FooterSpacing = 50;
            
            print.PrintDataGridView(salesdatagridview);
        }
    }
}
