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

namespace DB_Project__PMS_.Pharma_UC
{
    public partial class viewmed_UC : UserControl
    {
        Functions fn = new Functions();
        string query;

        public viewmed_UC()
        {
            InitializeComponent();
        }

        int stockquantity=0, stockamount=0;
        private void viewmed_UC_Load(object sender, EventArgs e)
        {
            query = "select Med_ID,Med_Name,Med_Formula,Med_Company,Med_exp,Med_price,Med_quantity from Medicine";
            DataSet ds = fn.getdata(query);
            medicinedatagrid.DataSource = ds.Tables[0];

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                stockquantity = stockquantity + int.Parse(ds.Tables[0].Rows[i][6].ToString());
                stockamount = stockamount + (int.Parse(ds.Tables[0].Rows[i][5].ToString()) * int.Parse(ds.Tables[0].Rows[i][6].ToString()));
            }
            stocktxt.Text = "Stock Quantity : " + stockquantity.ToString();
            amountlbl.Text = "Grand Total : " + stockamount.ToString();
        }

        private void usernametxt_TextChanged(object sender, EventArgs e)
        {
            if (mednametxt.Text.Length <= 30)
            {
                query = "select Med_ID,Med_Name,Med_Formula,Med_Company,Med_exp,Med_price,Med_quantity from Medicine where Med_Name like '" + mednametxt.Text + "%'";
                DataSet ds = fn.getdata(query);
                medicinedatagrid.DataSource = ds.Tables[0];
                if (ds.Tables[0].Rows.Count != 0)
                {
                    stockamount = 0;
                    stockquantity = 0;

                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        stockquantity = stockquantity + int.Parse(ds.Tables[0].Rows[i][6].ToString());
                        stockamount = stockamount + (int.Parse(ds.Tables[0].Rows[i][5].ToString()) * int.Parse(ds.Tables[0].Rows[i][6].ToString()));
                    }
                    stocktxt.Text = "Stock Quantity : " + stockquantity.ToString();
                    amountlbl.Text = "Grand Total : " + stockamount.ToString();
                }
                else
                {
                    stocktxt.Text = "Stock Quantity : 00";
                    amountlbl.Text = "Grand Total : 00";
                }
            }
            else
            {
                MessageBox.Show("Maximum limit Reached..!");
            }
        }

        string supid;
        private void medicinedatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                supid = medicinedatagrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch {
                MessageBox.Show("correct this");
            }
        }
        private void medicinedatagrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            viewmed_UC_Load(this, null);
        }

        private void printreport_Click(object sender, EventArgs e)
        {
            DGVPrinter print = new DGVPrinter();
            print.Title = "\nStock Report\n";
            print.SubTitle = string.Format("Date:-  {0}  \n", DateTime.Now.Date);
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.PorportionalColumns = true;
            print.HeaderCellAlignment = StringAlignment.Near;
            print.Footer = stocktxt.Text;
            print.FooterSpacing = 50;

            print.PrintDataGridView(medicinedatagrid);
        }
    }
}
