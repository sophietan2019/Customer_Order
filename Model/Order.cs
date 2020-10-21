using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Order
    {
        //constructor
        public Order() { }

        // public objects
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public string OrderDate { get; set; }
        public string RequiredDate { get; set; }
        public string ShippedDate { get; set; }

        public decimal  OrderTotal { get; set; }

        // make idenitical copy of Order
        public Order Clone()
        {
            Order copy = new Order();
            copy.OrderID = this.OrderID;
            copy.CustomerID = this.CustomerID;
            copy.OrderDate = this.OrderDate;
            copy.RequiredDate = this.RequiredDate;
            copy.ShippedDate = this.ShippedDate;
           
            return copy;
        }
    }
}
