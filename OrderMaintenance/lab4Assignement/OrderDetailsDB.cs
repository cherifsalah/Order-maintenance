//definition of method used to get a set of all orderdetails for an order by orderid
 
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4Assignement
{
    public static class OrderDetailsDB
    {
        //get a list of orderDetails for orderID
        public static List<OrderDetails> GetOrderDetails(int orderID)
        {
            List<OrderDetails> lstOrderDetails = new List<OrderDetails>();

            using (SqlConnection connection = NorthwindDB.GetConnection())
            { 
                string selectQuery = "SELECT OrderID, ProductID, UnitPrice, Quantity, Discount " +
                                     "FROM [dbo].[Order Details] " +
                                     "WHERE OrderID = @OrderId ";
            
                using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@OrderID", orderID);
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                
                    while (reader.Read())
                    {
                        //retrieve all data to the created object
                        OrderDetails orderdetails = new OrderDetails();
                        orderdetails.OrderID = (int)reader["OrderID"];
                        orderdetails.ProductID = (int)reader["ProductID"];
                        orderdetails.UnitPrice = (decimal)reader["UnitPrice"];
                        orderdetails.Quantity= (Int16)reader["Quantity"];
                        orderdetails.Discount = (float)reader["Discount"];
                        //calculate line total
                        orderdetails.LineTotal = (1 - Convert.ToDecimal (orderdetails.Discount)) * orderdetails.UnitPrice * orderdetails.Quantity;
                    
                        //add this order detail object to the list of order details 
                        lstOrderDetails.Add(orderdetails);
                    }
                }
            }
            return lstOrderDetails;
            
        }
    }
}
