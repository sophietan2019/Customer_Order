using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public static class OrderDB
    {
        //Method1: retrieve all records from table [orders]
        public static List<Order> GetAllOrders()
        {
            List<Order> orderlist = new List<Order>(); //empty list
            Order order;      //for reading
                              //create sql connection
            SqlConnection connection = NorthwindDB.GetConnection();

            //create select cmd
            string query = "select [orders].OrderID,[orders].CustomerID,[orders].OrderDate,[orders].RequiredDate,[orders].ShippedDate,"
                                   + "sum([Order Details].UnitPrice*(1-[Order Details].Discount)*[Order Details].Quantity) as OrderTotal"
                                   + " from [orders] inner join [Order Details]"
                                   + " on [Order Details].OrderID=[Orders].OrderID"
                                   + " group by [orders].OrderID,[orders].CustomerID,[orders].OrderDate,[orders].RequiredDate,[orders].ShippedDate"
                                   ;
            SqlCommand cmd = new SqlCommand(query, connection);
            try
            {
                //open the connection
                connection.Open();
                //run the select query
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                // build order list to return
                while (reader.Read()) //if there is an order
                {
                    order = new Order();
                    order.OrderID = (int)reader["OrderID"];
                    order.CustomerID = reader["CustomerID"].ToString();
                    order.OrderDate = string.Format("{0:MM/dd/yyyy}", reader["OrderDate"]);
                    order.RequiredDate = string.Format("{0:MM/dd/yyyy}", reader["RequiredDate"]);
                    order.ShippedDate = string.Format("{0:MM/dd/yyyy}", reader["ShippedDate"]);
                    order.OrderTotal = Convert.ToDecimal(reader["OrderTotal"]);
                    orderlist.Add(order);
                }
                reader.Close();
            }

            catch (Exception ex) //error
            {
                throw ex;
            }

            finally //executes always
            {
                connection.Close();
            }

            //return the list
            return orderlist;
        }


        //Method 2 Update  order in table [orders]
        // return indicator of success

        public static bool UpdateOrder(Order oldOrder, Order newOrder)
        {
            bool success = false; //did not update

            //connection
            SqlConnection connection = NorthwindDB.GetConnection();

            //update command (only update shippeddate)
            string updateStatement = "UPDATE  [Orders] ShippedDate=@NewShippedDate" +
                "WHERE ShippedDate=@OldShippedDate";

            SqlCommand cmd = new SqlCommand(updateStatement, connection);
            string newshipdate = String.Format("{0:d/M/yyyy HH:mm:ss}", newOrder.ShippedDate);
            cmd.Parameters.AddWithValue("@NewShippedDate",  newshipdate);
            cmd.Parameters.AddWithValue("@OldShippedDate", oldOrder.ShippedDate);

            try
            {
                connection.Open();
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    success = true;  //updated
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return success;
        }
    }
}

