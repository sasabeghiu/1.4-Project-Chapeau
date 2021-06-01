using System;
using System.Collections.Generic;
using ChapeauModel;
using System.Data;
using System.Data.SqlClient;

namespace ChapeauDAL
{
    public class OrderDAO : BaseDao
    {
        List<Order> ReadOrders(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order()
                {
                    OrderID = (int)dr["order_ID"],
                    BillID = (int)dr["bill_ID"],
                    Table_Number = (Table)dr["table_number"],
                    Employee_Number = (Employee)dr["empoyee_number"],
                    Order_Time = (DateTime)dr["order_time"],
                    Order_Status = (OrderStatus)dr["order_status"],
                    Comment = (string)dr["comment"]
                };
                orders.Add(order);
            }
            return orders;
        }
        public List<OrderItem> GetOrderItems(DataTable dataTable)
        {
            List<OrderItem> orderItems = new List<OrderItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderItem orderitem = new OrderItem()
                {
                    OrderItemID = (int)dr["order_ID"],
                    Order_Number = (int)dr["order_number"],
                    MenuItemID = (MenuItem)dr["menu_item_id"],
                    Quantity = (int)dr["quantity"],
                    Comment = (string)dr["comment"],
                    Order_Status = (OrderStatus)dr["status"],
                    Order_Time = (DateTime)dr["datetime"],
                    Table = (Table)dr["table_number"]
                };
                orderItems.Add(orderitem);
            }
            return orderItems;
        }

        public List<Order> GetAllOrders()
        {
            string query = "SELECT order_number, bill_ID, table_number, employee_number, order_time, order_status, comment FROM [Order]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadOrders(ExecuteSelectQuery(query, sqlParameters));
        }

        public void UpdateOrder(Order order, bool completed)
        {
            string query = $"UPDATE [Order] SET order_status={completed} WHERE order_ID={order.OrderID}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        // public List<OrderItem> GetAllOrderItems() {to be updated}
        //{
        //    List<OrderItem> orderItems = new List<OrderItem>();
        //    return orderItems;
        // }

        public void UpdateOrderItem(OrderItem orderItem, int newQuantity)
        {
            string query = $"UPDATE [Order_Item] SET order_quantity={newQuantity} WHERE order_quanity={orderItem.Quantity}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
