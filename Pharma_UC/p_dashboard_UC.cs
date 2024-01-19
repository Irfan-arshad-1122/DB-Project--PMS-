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
    public partial class p_dashboard_UC : UserControl
    {
        Functions fn = new Functions();
        string query;
        DataSet ds;
        public p_dashboard_UC()
        {
            InitializeComponent();
        }


        private void p_dashboard_UC_Load(object sender, EventArgs e)
        {
            int today_sales = 0 ;
            query = "SELECT Total_Price FROM sales WHERE CONVERT(date, Date) = CONVERT(date, GETDATE());";
            ds = fn.getdata(query);

            for(int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                today_sales = today_sales + int.Parse(ds.Tables[0].Rows[i][0].ToString());
            }
            incomelbl.Text = today_sales.ToString();

            int todayssalesqt = 0 ;
            query = "SELECT COUNT(*) FROM sales WHERE CONVERT(date, Date) = CONVERT(date, GETDATE());";
            ds = fn.getdata(query);
            for(int i = 0; i < ds.Tables[0].Rows.Count;i++) 
            {
                todayssalesqt = todayssalesqt + int.Parse(ds.Tables[0].Rows[i][0].ToString());
             }
            saleslbl.Text = todayssalesqt.ToString();

            int availablestock = 0;
            query = "SELECT Med_quantity FROM Medicine";
            ds = fn.getdata(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                availablestock = availablestock + int.Parse(ds.Tables[0].Rows[i][0].ToString());
            }
            availablestocklbl.Text = availablestock.ToString();


            int expiredstock = 0;
            query = "SELECT Med_quantity FROM Medicine WHERE CONVERT(date, Med_exp) = CONVERT(date, GETDATE());";
            ds = fn.getdata(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                expiredstock = expiredstock + int.Parse(ds.Tables[0].Rows[i][0].ToString());
            }
            expiredstocklbl.Text = expiredstock.ToString();


            int supplier = 0;
            query = "SELECT Supplier_ID FROM supplier ";
            ds = fn.getdata(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                supplier = supplier + 1;
            }
            supplierlbl.Text = supplier.ToString();


            int med = 0;
            query = "SELECT Med_ID FROM Medicine";
            ds = fn.getdata(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                med = med + 1;
            }
            medlbl.Text = med.ToString();

            query = "SELECT TOP 5 Med_ID,Med_Name,Med_quantity FROM Medicine ORDER BY Med_quantity ASC;";
            ds = fn.getdata(query);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                dataGridView1.Rows.Add(row[0], row[1], row[2]);
            }

            // Customize DataGridView column headers
            if (dataGridView1.Columns.Contains("MedID"))
            {
                dataGridView1.Columns["MedID"].HeaderText = "Medicine ID";
            }
            if (dataGridView1.Columns.Contains("Medicine_Name"))
            {
                dataGridView1.Columns["Medicine_Name"].HeaderText = "Medicine Name";
            }
            if (dataGridView1.Columns.Contains("Medicine_Quantity"))
            {
                dataGridView1.Columns["Medicine_Quantity"].HeaderText = "Quantity";
            }



        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
