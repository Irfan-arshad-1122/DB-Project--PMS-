using DB_Project__PMS_.DB;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Project__PMS_.Mdels
{
    public struct RevenueByDate
    {
        public string Date { get; set; }
        public decimal TotalAmount { get; set; }
    }

    public class Dashboard : dbconnection
    {
        private DateTime startDate;
        private DateTime endDate;
        private int numberDays;

        public int NumCustomers { get; private set; }
        public int NumSupplier { get; private set; }
        public int NumProducts { get; private set; }
        public int NumSales { get; private set; }
        public List<KeyValuePair<string,int>> TopProductList { get; private set; }
        public List<KeyValuePair<string, int>> UnderStocklist { get; private set; }
        public List<RevenueByDate> GrossRevenueList { get; private set; }
        public int numsales { get; set; }
        public decimal TotalReveneu { get; set; }
        
        //constructor
        public Dashboard()
        {

        }

        //private method
        private void getnumberItems()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using(var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select count(Customer_Name) from Sales";
                    NumCustomers = (int)command.ExecuteScalar();

                    command.CommandText = "select count(Supplier_ID) from supplier";
                    NumSupplier = (int)command.ExecuteScalar();

                    command.CommandText = "select count(Med_ID) from Medicne";
                    NumProducts = (int)command.ExecuteScalar();

                    command.CommandText = @"select count(S_No) from Sales where Date  between  @fromDate and @toDate";
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    NumSales = (int)command.ExecuteScalar();

                }
            }
        }

        private void GetSalesAnalysis()
        {
            GrossRevenueList=new List<RevenueByDate>();
            TotalReveneu = 0;

            using (var connection = GetConnection())
            {
                connection.Open();
                using(var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"select Date,sum(Total_Price) from Sales where Date between  @fromDate and @toDate group by Date";
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    var reader = command.ExecuteReader();

                    var resulttable = new List<KeyValuePair<DateTime, decimal>>();
                    while(reader.Read())
                    {
                        resulttable.Add(new KeyValuePair<DateTime, decimal>((DateTime)reader[0], (decimal)reader[1]));
                        TotalReveneu += (decimal)reader[0];
                    }
                    reader.Close();

                    if(numberDays <= 30)
                    {
                        foreach(var item in resulttable)
                        {
                            GrossRevenueList.Add(new RevenueByDate
                            {
                                Date = item.Key.ToString("dd MMM"),
                                TotalAmount = item.Value
                            });
                        }
                    }

                    //groupbyweek
                    else if (numberDays <= 92)
                    {
                    }

                }
            }
        }



    }
}
