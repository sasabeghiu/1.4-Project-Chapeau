using System;

namespace ChapeauModel
{
    public class OrderItem
    {
        public int OrderItemID { get; set; }
        public int Order_Number { get; set; }
        public MenuItem MenuItemID { get; set; }
        public int Quantity { get; set; }
        public string Comment { get; set; }
        public OrderStatus Order_Status { get; set; }
        public Table Table { get; set; }
        public DateTime Order_Time { get; set; }

        public OrderItem(int orderItemID, int orderNumber, MenuItem menuitemID, int quantity, string comment, OrderStatus orderStatus, Table table, DateTime Ordertime)
        {
            OrderItemID = orderItemID;
            Order_Number = orderNumber;
            MenuItemID = menuitemID;
            Quantity = quantity;
            Comment = comment;
            Order_Status = orderStatus;
            Table = table;
            Order_Time = Ordertime;
        }

        public OrderItem()
        {

        }

        public OrderItem(MenuItem menu, int quantity, string comment, OrderStatus status)
        {
            this.MenuItemID = menu;
            this.Quantity = quantity;
            this.Comment = comment;
            this.Order_Status = status;
        }

        public OrderItem(MenuItem menu, int quantity, string comment)
        {
            this.MenuItemID = menu;
            this.Quantity = quantity;
            this.Comment = comment;
        }
    }
}
