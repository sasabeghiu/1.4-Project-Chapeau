using System;
using System.Collections.Generic;
using ChapeauModel;
using System.Data;
using System.Data.SqlClient;

namespace ChapeauDAL
{
    public class OrderDAO : BaseDao
    {
        /// read order or read orders
        private Order ReadOrder(SqlDataReader reader)
        {
            TableDAO tableDAO = new TableDAO();
            EmployeeDAO employeeDAO = new EmployeeDAO();
            Order order = new Order();

            int OrderID = (int)reader["order_ID"];
            int BillID = (int)reader["bill_ID"];
            Table Table_Number = (Table)reader["table_number"];
            Employee Employee_Number = (Employee)reader["empoyee_number"];
            DateTime Order_Time = (DateTime)reader["order_time"];
            OrderStatus Order_Status = (OrderStatus)reader["order_status"];
            string Comment = (string)reader["comment"];
            bool isPaid = (bool)reader["is_paid"];

            return new Order(OrderID, BillID, Table_Number, Employee_Number, Order_Time, Order_Status, Comment, isPaid);
        }

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

        //get order or get all orders
        public List<Order> GetAllOrders()
        {
            OpenConnection();
            string query = "SELECT order_ID, bill_ID, table_number, employee_number, order_time, order_status, comment FROM [Order]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            CloseConnection();
            return ReadOrders(ExecuteSelectQuery(query, sqlParameters));
        }


        //add, edit, delete orders
        public void AddOrder(Order order)
        {
            OpenConnection();
            SqlCommand queryAddOrder = new SqlCommand("INSERT INTO [Order] ([order_ID], [bill_ID], [table_number], [employee_number], [order_time], [order_status], [comment], [is_paid]) VALUES (@order_ID, @bill_ID, @table_number, @employee_number, @order_time, @order_status, @comment, @is_paid);");
            queryAddOrder.Parameters.AddWithValue("@order_ID", order.OrderID);
            queryAddOrder.Parameters.AddWithValue("@billID", order.BillID);
            queryAddOrder.Parameters.AddWithValue("@table_number", order.Table_Number);
            queryAddOrder.Parameters.AddWithValue("@employeeID", order.Employee_Number);
            queryAddOrder.Parameters.AddWithValue("@order_time", order.Order_Time);
            queryAddOrder.Parameters.AddWithValue(@"order_status", order.Order_Status);
            queryAddOrder.Parameters.AddWithValue("@comment", order.Comment);
            queryAddOrder.Parameters.AddWithValue("@is_paid", order.IsPaid);
            queryAddOrder.ExecuteNonQuery();
            CloseConnection();
        }

        public void EditOrder(Order order)
        {
            OpenConnection();
            SqlCommand queryEditOrder = new SqlCommand("UPDATE [Orders] SET [billID] = @billID, [table_number] = @table_number, [employee_number] = @employee_number, [order_time] = @order_time, [order_status] = @order_status, [comment] = @comment, [is_paid] = @ispaid WHERE [orderID] = @orderID");
            queryEditOrder.Parameters.AddWithValue("@billID", order.BillID);
            queryEditOrder.Parameters.AddWithValue("@table_number", order.Table_Number);
            queryEditOrder.Parameters.AddWithValue("@employeeID", order.Employee_Number);
            queryEditOrder.Parameters.AddWithValue("@order_time", order.Order_Time);
            queryEditOrder.Parameters.AddWithValue(@"order_status", order.Order_Status);
            queryEditOrder.Parameters.AddWithValue("@comment", order.Comment);
            queryEditOrder.Parameters.AddWithValue("@is_paid", order.IsPaid);
            queryEditOrder.Parameters.AddWithValue("@order_ID", order.OrderID);
            queryEditOrder.ExecuteNonQuery();
            CloseConnection();
        }

        public void DeleteOrder(Order order)
        {
            OpenConnection();
            SqlCommand queryDeleteOrder = new SqlCommand("DELETE FROM [Orders] WHERE [order_ID] = @order_ID");
            queryDeleteOrder.Parameters.AddWithValue("@order_ID", order.OrderID);
            queryDeleteOrder.ExecuteNonQuery();
            CloseConnection();
        }

        //update status of order
        public void UpdateOrderStatusToOrdered(Order order, OrderStatus ordered)
        {
            string query = $"UPDATE [Order] SET order_status={ordered} WHERE order_ID={order.OrderID}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public void UpdateOrderStatusToPreparing(Order order, OrderStatus preparing)
        {
            string query = $"UPDATE [Order] SET order_status={preparing} WHERE order_ID={order.OrderID}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public void UpdateOrderStatusToReady(Order order, OrderStatus ready)
        {
            string query = $"UPDATE [Order] SET order_status={ready} WHERE order_ID={order.OrderID}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public void UpdateOrderStatusToDelivered(Order order, OrderStatus delivered)
        {
            string query = $"UPDATE [Order] SET order_status={delivered} WHERE order_ID={order.OrderID}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        //get order last entered, order by order id,order by bill id, order by table number.
        public Order GetLastOrder()
        {
            OpenConnection();
            SqlCommand queryGetLastOrder = new SqlCommand("SELECT TOP 1 * FROM [Orders] ORDER BY [orderID] DESC");
            SqlDataReader reader = queryGetLastOrder.ExecuteReader();
            Order order = null;
            if (reader.Read())
            {
                order = ReadOrder(reader);
            }
            reader.Close();
            CloseConnection();
            return order;
        }

        //get order by order id
        /* public Order GetOrderByOrderID(int order_ID)
        {
            OpenConnection();
            SqlCommand queryGetOrderByOrderID = new SqlCommand(("SELECT order_ID, bill_ID, table_number, employee_number, order_time, order_status, comment, is_paid FROM [Order] WHERE order_ID = @order_ID AND order_status <> 1"));
            queryGetOrderByOrderID.Parameters.AddWithValue("@order_ID", order_ID);
            SqlDataReader reader = queryGetOrderByOrderID.ExecuteReader();
            Order order = null;
            if (reader.Read())
            {
                order = ReadOrder(reader);
            }

            if (reader.HasRows == false)
            {
                throw new Exception("There is no order placed at the selected table");
            }
            reader.Close();
            CloseConnection();

            order.orderItems = GetAllOrderItems(order.OrderID);

            return order;
        }
        //get order by bill id
        public Order GetOrderByBillID(int bill_ID)
        {
            OpenConnection();
            SqlCommand queryGetOrderByBillID = new SqlCommand(("SELECT order_ID, bill_ID, table_number, employee_number, order_time, order_status, comment, is_paid FROM [Order] WHERE bill_ID = @bill_ID AND order_status <> 1"));
            queryGetOrderByBillID.Parameters.AddWithValue("@bill_ID", bill_ID);
            SqlDataReader reader = queryGetOrderByBillID.ExecuteReader();
            Order order = null;
            if (reader.Read())
            {
                order = ReadOrder(reader);
            }

            if (reader.HasRows == false)
            {
                throw new Exception("There is no order placed at the selected table");
            }
            reader.Close();
            CloseConnection();

            order.orderItems = GetAllOrderItems(order.OrderID);

            return order;
        }
        //get order by table number
        public Order GetOrderByTableNumber(int table_number)
        {
            OpenConnection();
            SqlCommand queryOrderGetByTableNumber = new SqlCommand(("SELECT order_ID, bill_ID, table_number, employee_number, order_time, order_status, comment, is_paid FROM [Order] WHERE table_number = @table_number AND order_status <> 1"));
            queryOrderGetByTableNumber.Parameters.AddWithValue("@table_number", table_number);
            SqlDataReader reader = queryOrderGetByTableNumber.ExecuteReader();
            Order order = null;
            if (reader.Read())
            {
                order = ReadOrder(reader);
            }

            if (reader.HasRows == false)
            {
                throw new Exception("There is no order placed at the selected table");
            }
            reader.Close();
            CloseConnection();

            order.orderItems = GetAllOrderItems(order.OrderID);

            return order;
        }
        */

        /// now making all the queries for the order items
        /// read order item, get order items, get all order items
        private OrderItem ReadOrderItem(SqlDataReader reader)
        {
            MenuDAO menuDAO = new MenuDAO();
            TableDAO tableDAO = new TableDAO();

            int OrderItemID = (int)reader["order_item_id"];
            int Order_Number = (int)reader["order_number"];
            MenuItem MenuItemID = (MenuItem)reader["menu_item_id"];
            int Quantity = (int)reader["quantity"];
            string Comment = (string)reader["comment"];
            OrderStatus Order_Status = (OrderStatus)reader["status"];
            DateTime Order_Time = (DateTime)reader["datetime"];
            Table table = (Table)reader["table_number"];

            return new OrderItem(OrderItemID, Order_Number, MenuItemID, Quantity, Comment, Order_Status, table, Order_Time);
        }

        public List<OrderItem> GetOrderItems(DataTable dataTable)
        {
            OpenConnection();
            SqlCommand sqlGetOrderItems = new SqlCommand("SELECT (order_item.id, order_number, menu_item_id, quantity, comment, status, datetime, table_number) FROM [Order_Item] LEFT OUTER JOIN [Orders] ON order_item_id = order_ID");
            SqlDataReader reader = sqlGetOrderItems.ExecuteReader();
            List<OrderItem> orderItems = new List<OrderItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderItem orderitem = new OrderItem()
                {
                    OrderItemID = (int)dr["order_item_id"],
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
            while (reader.Read())
            {
                OrderItem orderItem = ReadOrderItem(reader);
                orderItems.Add(orderItem);
            }
            reader.Close();
            CloseConnection();
            return orderItems;
        }

        public List<OrderItem> GetAllOrderItems()
        {
            OpenConnection();
            SqlCommand queryGetAllOrderItems = new SqlCommand("SELECT order_item_id, order_number, menu_item_id, quantity, comment, status, datetime, table_number FROM [Order_Item] WHERE order_item_id = '{OrderItem.order_item_id} ");
            SqlDataReader reader = queryGetAllOrderItems.ExecuteReader();
            List<OrderItem> orderItems = new List<OrderItem>();
            while (reader.Read())
            {
                OrderItem orderItem = ReadOrderItem(reader);
                orderItems.Add(orderItem);
            }
            reader.Close();
            CloseConnection();
            return orderItems;
        }

        //add order item.
        public void AddOrderItem(OrderItem orderItem)
        {
            OpenConnection();
            SqlCommand queryAddOrderItem = new SqlCommand("INSERT INTO[Order_Item]([order_item_id],[order_number], [menu_item_id], [quantity], [comment],[status],[datetime],[table_number]) VALUES (@order_item_id, @order_number, @menu_item_id, @quantity, @comment, @datetime, @table_number); ");
            queryAddOrderItem.Parameters.AddWithValue("@order_item_id", orderItem.OrderItemID);
        }

        //update order item quantity.
        public void UpdateOrderItem(OrderItem orderItem, int newQuantity)
        {
            string query = $"UPDATE [Order_Item] SET order_quantity={newQuantity} WHERE order_quanity={orderItem.Quantity}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        //get order item last entered
        // public OrderItem GetLastOrderItem()
        // {

        // }

        //get order item by order item id
        // public OrderItem GetOrderItemByOrderID(int order_item_id)
        // {

        //  }

        //get bar item only
        //   public List<OrderItem> GetBarItems()
        //   {

        //   }

        //get kitchen item only
        //   public List<OrderItem> GetKitchenItems()
        //  {

        //   }


    }
}