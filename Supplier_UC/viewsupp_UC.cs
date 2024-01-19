using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Project__PMS_.Supplier_UC
{
    public partial class viewsupp_UC : UserControl
    {
        Functions fn = new Functions();
        string query;

        public viewsupp_UC()
        {
            InitializeComponent();
        }

        private void viewsupp_UC_Load(object sender, EventArgs e)
        {
            query = "select Supplier_ID,Supplier_Name,Supplier_NIC,Supplier_Phone,Supplier_Address,Total_Amount,Payed_Amount,Pending_Amount from supplier";
            DataSet ds = fn.getdata(query);

            supdatagrid.DataSource = ds.Tables[0];
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            viewsupp_UC_Load(this,null);
        }


        string supid;
        private void supdatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            supid = supdatagrid.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You sure..!", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                query = "Delete from supplier where Supplier_ID = '" + supid + "' ";
                fn.setdata(query, "Record Deleted Successfully..!");
                
                query = "select Supplier_ID,Supplier_Name,Supplier_NIC,Supplier_Phone,Supplier_Address,Total_Amount,Payed_Amount,Pending_Amount from supplier";
                DataSet ds = fn.getdata(query);

                supdatagrid.DataSource = ds.Tables[0];
            }
        }

        private void suppnametxt_TextChanged(object sender, EventArgs e)
        {
            if (suppnametxt.Text.Length <= 25)
            {
                query = "select Supplier_ID,Supplier_Name,Supplier_NIC,Supplier_Phone,Supplier_Address,Total_Amount,Payed_Amount,Pending_Amount from supplier where Supplier_Name like '" + suppnametxt.Text + "%'";
                DataSet ds = fn.getdata(query);
                supdatagrid.DataSource = ds.Tables[0];

            }
            else
            {
                MessageBox.Show("Maximum limit Reached..!");
            }
        }

        private void supdatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
