using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;
using System.Data;

namespace DAL
{
    public static class OrderDetailDB
    {
        //retrieve selected records from table OrderDetail
        public static List<OrderDetail> GetSelectedOrderDetail(int orderID)
        {
            List<OrderDetail> orderdetail_list = new List<OrderDetail>(); //empty list
            OrderDetail orderdetail;  //for reading

            //create connection 
            SqlConnection connection = NorthwindDB.GetConnection();

            //create command for Select query to get the orderdetails
            string query = "select * from [Order Details] where OrderID=@OrderID";
            SqlCommand cmd = new SqlCommand(query, connection);

            // supply parameter value
            cmd.Parameters.AddWithValue("@OrderID", orderID);


            //open the connection
            connection.Open();
            //run the command
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            //add orderdetail data to the list
            while (reader.Read()) //while there still is data to read
            {
                orderdetail = new OrderDetail();
                orderdetail.OrderID = (int)reader["OrderID"];
                orderdetail.ProductID = (int)reader["ProductID"];
                orderdetail.UnitPrice = (decimal)reader["UnitPrice"];
                orderdetail.Quantity = Convert.ToInt32(reader["Quantity"]);
                orderdetail.Discount = Convert.ToDecimal(reader["Discount"]);

                orderdetail_list.Add(orderdetail);
            }

            return orderdetail_list;

        }
    }
}
