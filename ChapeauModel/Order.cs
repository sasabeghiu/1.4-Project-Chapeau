using System;
using System.Collections.Generic;
using ChapeauModel;

public class Order
{
    public List<OrderItem> OrderedItems { get; set; }

    public int OrderID { get; set; } // to refer to the order later
    public int BillID { get; set; } //to refer to the bill within the order
    public Table Table_Number { get; set; } // 1 - 10
    public Employee Employee_Number { get; set; } // who took the order
    public DateTime Order_Time { get; set; } // what time was the order taken
    public OrderStatus Order_Status { get; set; } // order Ordered, Preparing, Ready, Delivered

    public string Comment { get; set; } // customer places comment

    public bool IsPaid { get; set; } // displays if order is paid or not.

    public Order(int orderID, int billID, Table tableNumber, Employee employeeNumber, DateTime orderTime, OrderStatus orderStatus, string comment, bool isPaid)
    {
        OrderID = orderID;
        BillID = billID;
        Table_Number = tableNumber;
        Employee_Number = employeeNumber;
        Order_Time = orderTime;
        Order_Status = orderStatus;
        Comment = comment;
        IsPaid = isPaid;
    }

    public Order()
    {
        OrderedItems = new List<OrderItem>();
    }
}