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
    public partial class Medvalidity_UC : UserControl
    {
        Functions fn = new Functions();
        string query;

        public Medvalidity_UC()
        {
            InitializeComponent();
        }

        private void Medvalidity_UC_Load(object sender, EventArgs e)
        {
            setlabel.Visible =true;
            setlabel.Text = "All Medicines:";
            query = "select * from Medicine";
            setlabel.ForeColor = Color.Black;
            DataSet ds = fn.getdata(query);

            medicinedatagridview.DataSource = ds.Tables[0];
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(checktxt.SelectedIndex == 0)
            {
                    query = "select * from Medicine where Med_exp >= getdate()";
                    DataSet ds = fn.getdata(query);

                    medicinedatagridview.DataSource = ds.Tables[0];
                    setlabel.Visible = true;
                    setlabel.Text = "Valid Medicines:";
                    setlabel.ForeColor = Color.Black;
               
            }
            else if( checktxt.SelectedIndex == 1)
            {
                query = "select * from Medicine where Med_exp <= getdate()";
                DataSet ds = fn.getdata(query);

                medicinedatagridview.DataSource = ds.Tables[0];
                setlabel.Visible = true;
                setlabel.Text = "Expired Medicines:";
                setlabel.ForeColor = Color.Red;
            }
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            Medvalidity_UC_Load(this, null);
        }
    }
}
