//definition of the class Order
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4Assignement
{
    public class Order
    {
        //class property
        public int OrderID { get; set; }

        public string CustomerID { get; set; }
        public DateTime? OrderDate { get; set; }

        public DateTime? RequiredDate { get; set; }

        public DateTime? ShippedDate { get; set; }

        public decimal totalOrder { get; set; }
        //method copy order  
        public  Order CopyOrder()
        {
            Order copy = new Order();
            copy.OrderID = OrderID  ; // this Order ID
            copy.CustomerID = CustomerID;
            copy.OrderDate = OrderDate;
            copy.RequiredDate = RequiredDate;
            copy.ShippedDate = ShippedDate;
            copy.totalOrder = totalOrder;
            return copy;
        }

    }
}
