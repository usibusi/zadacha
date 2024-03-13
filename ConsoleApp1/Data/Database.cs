using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Data
{
    public class Database
    {
        private string connectionString = "Data source = DESKTOP-M834BAO; Database = az; integrated security = true";
        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
