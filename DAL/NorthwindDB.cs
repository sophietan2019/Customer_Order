using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class NorthwindDB
    {       
        public static SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
            return new SqlConnection(connectionString);
        }
    }
}
