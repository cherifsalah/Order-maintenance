//Definition of the class of the object OrderDetails : contain a detail order of an order
//an order can have 1 or many orderdetails
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4Assignement
{
    public class OrderDetails
    {
        /// <summary>
        /// class Property
        /// </summary>
        public int OrderID { get; set; }
        public int ProductID { get; set; }

        public decimal UnitPrice { get; set; }
        public Int16 Quantity { get; set; }
        public float Discount { get; set; }
        public decimal LineTotal { get; set; }
    }
}
