using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Project__PMS_.DB
{
    public abstract class dbconnection
    {
        private readonly string connectionString;
        public dbconnection()
        {
            connectionString = "data source=DESKTOP-16V99E1\\SQLEXPRESS; database=PMS;integrated security=True";
        }
        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
