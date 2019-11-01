//class OrderDb contain defintion of method to get all orders and Update a single order in Db
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4Assignement
{
    public static class OrderDB
    {
        /// <summary>
        /// Retrieves data of all the orders in DB 
        /// </summary>
        /// 
        /// <returns> list of all the orders</returns>
       
        public static ListResult GetOrders()
        {
            List<Order> lstOrder = new List<Order>() ;
            List<OrderDetails> lstOrderdetails = new List<OrderDetails>();
            ListResult lstresult = new ListResult();
            List<OrderDetails> OrderDetails = new List<OrderDetails>();
            int col_OrderDate;
            int col_requiredDate;
            int col_shippedDate;
            using (SqlConnection connection = NorthwindDB.GetConnection())
            {
                string selectQuery = "SELECT OrderID, CustomerID, OrderDate, RequiredDate, ShippedDate " +
                                     "FROM Orders";
                
                using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                { 
                    connection.Open();

                    SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                
                        //get the col number of OrderDate and RequiredDate and ShippedDate 
                        if (reader.HasRows)
                        {
                            col_OrderDate = reader.GetOrdinal("OrderDate");
                            col_requiredDate = reader.GetOrdinal("RequiredDate");
                            col_shippedDate = reader.GetOrdinal("ShippedDate");

                            while (reader.Read())
                            {
                                Order order = new Order();
                                order.OrderID = (int)reader["OrderID"];
                                order.CustomerID = (string)reader["CustomerID"];
                                // for any column that can be null need to determine if it is DBNull
                                // and set accordingly

                                order.OrderDate = reader.IsDBNull(col_OrderDate) ?
                                    null : (DateTime?)Convert.ToDateTime(reader["OrderDate"]);
                                order.RequiredDate = reader.IsDBNull(col_requiredDate) ?
                                    null : (DateTime?)Convert.ToDateTime(reader["RequiredDate"]);
                                order.ShippedDate = reader.IsDBNull(col_shippedDate) ?
                                    null : (DateTime?)Convert.ToDateTime(reader["ShippedDate"]);
                                //get the list of order details for this order 
                                OrderDetails = OrderDetailsDB.GetOrderDetails(order.OrderID);
                                order.totalOrder = get_total_order(OrderDetails);
                                //add this order to the list of order 
                                lstOrder.Add(order);
                                //add orderdetails to the list of all orderdetails 
                                lstOrderdetails = lstOrderdetails.Concat(OrderDetails).ToList();
                            }
                        }
                
                }
            }
           
            lstresult.ListOrders = lstOrder;
            lstresult.listOrderDetails = lstOrderdetails;
            return lstresult;
        }

        //return total order amount given a list of all the order details of a given order 
        public static decimal get_total_order(List<OrderDetails> lstorderDetails)
        {
            decimal total=0;
            foreach (OrderDetails orderdetail in lstorderDetails)
            {
                total += orderdetail.LineTotal;
            }
            return total;
        }
        //update a given order with a new shipdate
        public static bool UpdateOrder(Order OldOrder,Order NewOrder)
        {
            bool success = true;
            string update_where_str="";
            SqlConnection con = NorthwindDB.GetConnection();
            string updateStatement = "UPDATE Orders SET " +
                                     "OrderDate = @NewOrderDate, " +
                                     "RequiredDate = @NewRequiredDate, " +
                                     "ShippedDate = @NewShippedDate " +
                                     "WHERE OrderID = @OldOrderID "; // to identify record to update
             // remaining conditions for optimistic concurrency
             //test if where is (is null) or (=oldvalue)
            if (OldOrder.OrderDate.HasValue)
                     { update_where_str += "AND OrderDate = @OldOrderDate "; }
                else
                    { update_where_str += "AND OrderDate is Null "; }
            if (OldOrder.RequiredDate.HasValue)
                { update_where_str += "AND RequiredDate = @OldRequiredDate "; }
                else
                { update_where_str += "AND RequiredDate is Null "; }
                if (OldOrder.ShippedDate.HasValue)
                { update_where_str += "AND ShippedDate = @OldShippedDate "; }
                else
                { update_where_str += "AND ShippedDate is Null "; }
            updateStatement += update_where_str;
                                
                                     
            SqlCommand cmd = new SqlCommand(updateStatement, con);
            cmd.Parameters.AddWithValue("@NewOrderDate", NewOrder.OrderDate);
            cmd.Parameters.AddWithValue("@NewRequiredDate", NewOrder.RequiredDate);
            cmd.Parameters.AddWithValue("@NewShippedDate", NewOrder.ShippedDate);
            cmd.Parameters.AddWithValue("@OldOrderID", OldOrder.OrderID);
            if (OldOrder.OrderDate.HasValue) { cmd.Parameters.AddWithValue("@OldOrderDate", OldOrder.OrderDate); }
            if (OldOrder.RequiredDate.HasValue) { cmd.Parameters.AddWithValue("@OldRequiredDate", OldOrder.RequiredDate); }
            if (OldOrder.ShippedDate.HasValue) { cmd.Parameters.AddWithValue("@OldShippedDate", OldOrder.ShippedDate); }  
           
            try
            {
                con.Open();
                int rowsUpdated = cmd.ExecuteNonQuery( );
                if (rowsUpdated == 0) success = false; // did not update (another user updated or deleted)
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }

            return success;
          }
        
    }
}
