using ConsoleApp1.Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Data
{
    public class Data
    {
        public List<Product> GetAll()
        {
            var productList = new List<Product>();
            SqlConnection con = Database.GetConnection();
            con.Open();
            using (con)
            {
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                command.CommandText = "Select * From product";
                SqlDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        Product product = new Product((int)reader.GetValue(0), (string)reader.GetValue(1), (decimal)reader.GetValue(2), (int)reader.GetValue(3));
                        productList.Add(product);
                    }
                }
            }
            con.Close();
            return productList;
        }
    }
}
