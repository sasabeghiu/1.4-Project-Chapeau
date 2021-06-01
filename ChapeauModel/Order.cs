using System;
using System.Collections.Generic;

namespace ChapeauModel
{
    public class Order
    {
        //whats this for?
        public List<OrderItem> orderItems = new List<OrderItem>();

        public int OrderID { get; set; } // to refer to the order later
        public int BillID { get; set; } //to refer to the bill within the order
        public Table Table_Number { get; set; } // 1 - 10
        public Employee Employee_Number { get; set; } // who took the order
        public DateTime Order_Time { get; set; } // what time was the order taken
        public OrderStatus Order_Status { get; set; } // order incomplete/order complete
        public string Comment { get; set; } // customer places comment

        public Order(int orderID, int billID, Table tableNumber, Employee employeeNumber, DateTime orderTime, OrderStatus orderStatus, string comment)
        {
            OrderID = orderID;
            BillID = billID;
            Table_Number = tableNumber;
            Employee_Number = employeeNumber;
            Order_Time = orderTime;
            Order_Status = orderStatus;
            Comment = comment;
        }

        public Order()
        {

        }
    }
}
