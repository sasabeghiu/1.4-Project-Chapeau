using System;
using System.Collections.Generic;
using ChapeauModel;
using System.Data;
using System.Data.SqlClient;

namespace ChapeauDAL
{
    public class OrderDAO : BaseDao
    {
        TableDAO tabledao = new TableDAO();
        MenuDAO menudao = new MenuDAO();
        MenuItemDAO menuItemDAO = new MenuItemDAO();

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
        public void AddOrder()
        {
            OpenConnection();
            string query = ("INSERT INTO [Order] ([order_ID], [bill_ID], [table_number], [employee_number], [order_time], [order_status], [comment], [is_paid]) VALUES (@order_ID, @bill_ID, @table_number, @employee_number, @order_time, @order_status, @comment, @is_paid);");
            SqlParameter[] sqlParameters = new SqlParameter[0];
            CloseConnection();
            ExecuteEditQuery(query, sqlParameters);
        }

        public void EditOrder()
        {
            OpenConnection();
            string query = ("UPDATE [Orders] SET [billID] = @billID, [table_number] = @table_number, [employee_number] = @employee_number, [order_time] = @order_time, [order_status] = @order_status, [comment] = @comment, [is_paid] = @ispaid WHERE [orderID] = @orderID");
            SqlParameter[] sqlParameters = new SqlParameter[0];
            CloseConnection();
            ExecuteEditQuery(query, sqlParameters);
        }

        public void DeleteOrder(Order order)
        {
            OpenConnection();
            string query = ("DELETE FROM [Orders] WHERE [order_ID] = @order_ID");
            SqlParameter[] sqlParameters = new SqlParameter[0];
            CloseConnection();
            ExecuteEditQuery(query, sqlParameters);
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

        public List<OrderItem> GetOrderItemsByTableID(int tableid)
        {
            OpenConnection();
            string query = "SELECT order_item_id, order_number, menu_item_id, quantity, comment, status, datetime, table_number FROM [Order_Item] WHERE table_number = @table_number";
            SqlParameter[] sqlParameters = { new SqlParameter("@table_number", tableid) };
            return ReadOrderItem(ExecuteSelectQuery(query, sqlParameters));
        }


       


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
            string query = "SELECT * FROM [Order_Item]";

            List<OrderItem> orderItems = new List<OrderItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderItem orderitem = new OrderItem()
                {
                    OrderItemID = (int)dr["order_item_id"],
                    Order_Number = (int)dr["order_number"],
                    MenuItemID = menuItemDAO.GetMenuItemByID((int)dr["menu_item_id"]),
                    Quantity = (int)dr["quantity"],
                    Comment = (string)dr["comment"],
                    Order_Status = (OrderStatus)Enum.Parse(typeof(OrderStatus), dr["status"].ToString()),
                    Order_Time = (DateTime)dr["datetime"],
                    Table_Number = tabledao.GetTable((int)dr["table_number"]),
                };
                orderItems.Add(orderitem);
            }

            SqlParameter[] sqlParameters = new SqlParameter[0];
            CloseConnection();
            return ReadOrderItem(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<OrderItem> GetAllOrderItems()
        {
            OpenConnection();
            string query = ("SELECT * FROM [Order_Item]");
            SqlParameter[] sqlParameters = new SqlParameter[0];
            CloseConnection();
            return GetOrderItems(ExecuteSelectQuery(query, sqlParameters));
        }
        //add order item.
        public void AddOrderItem(OrderItem orderItem)
        {
            int status = (int)orderItem.Order_Status;
            Table tableNumber = orderItem.Table_Number;

            string query = ("INSERT INTO[Order_Item](order_item_id,order_number, menu_item_id, quantity, comment, status,datetime,table_number) VALUES (@order_item_id, @order_number, @menu_item_id, @quantity, @comment, @datetime, @table_number); ");
            SqlParameter[] sqlParameters = new SqlParameter[7];
            sqlParameters[0] = new SqlParameter("order_item_id", orderItem.OrderItemID);
            sqlParameters[1] = new SqlParameter("menu_item_id", orderItem.MenuItemID);
            sqlParameters[2] = new SqlParameter("quantity", orderItem.Quantity);
            sqlParameters[3] = new SqlParameter("comment", orderItem.Comment);
            sqlParameters[4] = new SqlParameter("status", status);
            sqlParameters[5] = new SqlParameter("datetime", orderItem.Order_Time);
            sqlParameters[6] = new SqlParameter("table_number", tableNumber);

            ExecuteSelectQuery(query, sqlParameters);
        }


        //update order item quantity.
        public void UpdateOrderItem(OrderItem orderItem, int newQuantity)
        {
            string query = $"UPDATE [Order_Item] SET order_quantity={newQuantity} WHERE order_quanity={orderItem.Quantity}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public List<Order> GetCurrentOrders()
        {
            string query = "SELECT order_ID, order_status, order_time FROM[Order] WHERE is_paid = 0";

            SqlParameter[] sqlParameters = new SqlParameter[0];

            return ReadKitchenOrders(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Order> GetPreviousOrders()
        {
            string query = "SELECT order_ID, order_status, order_time FROM[Order] WHERE is_paid = 1";

            SqlParameter[] sqlParameters = new SqlParameter[0];

            return ReadKitchenOrders(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Order> ReadKitchenOrders(DataTable dataTable)
        {
            List<Order> orderList = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order()
                {
                    
                    OrderID = (int)dr["order_ID"],
                    Order_Status = (OrderStatus)Enum.Parse(typeof(OrderStatus), dr["order_status"].ToString()),
                    Order_Time = (DateTime)(dr["order_time"]),

                };
                orderList.Add(order);
            }
            return orderList;
        }
        
        public List<OrderItem> GetKitchenItemsById(int id)
        {
            List<OrderItem> orderItems = new List<OrderItem>();
            SqlCommand cmd = new SqlCommand("SELECT MenuItem.menu_item_name, quantity, Order_Item.comment FROM [Order] JOIN Order_Item ON order_number = order_ID JOIN MenuItem ON MenuItem.menu_item_id = Order_Item.menu_item_id WHERE order_ID = @id AND CONVERT(VARCHAR, menu_item_category) <> 'Drinks'", OpenConnection());
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                OrderItem item = ReturnOrderItemKitchen(reader);
                orderItems.Add(item);
            }
            reader.Close();

            return orderItems;
        }

        public List<OrderItem> GetBarItemsById(int id)
        {
            List<OrderItem> orderItems = new List<OrderItem>();
            SqlCommand cmd = new SqlCommand("SELECT MenuItem.menu_item_name, quantity, Order_Item.comment FROM [Order] JOIN Order_Item ON order_number = order_ID JOIN MenuItem ON MenuItem.menu_item_id = Order_Item.menu_item_id WHERE order_ID = @id AND CONVERT(VARCHAR, menu_item_category) = 'Drinks'", OpenConnection());
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                OrderItem item = ReturnOrderItemKitchen(reader);
                orderItems.Add(item);
            }
            reader.Close();

            return orderItems;
        }

        public void UpdateOrder(Order order)
        {
            SqlCommand queryUpdateOrder = new SqlCommand("UPDATE [Order] SET order_status = @orderstatus WHERE order_ID = @orderid", OpenConnection());
            queryUpdateOrder.Parameters.AddWithValue("@orderstatus", order.Order_Status.ToString());
            queryUpdateOrder.Parameters.AddWithValue("@orderid", order.OrderID.ToString());
            queryUpdateOrder.ExecuteNonQuery();
            CloseConnection();
        }

        public void UpdateOrderItemKitchen(OrderItem item)
        {
            SqlCommand queryUpdateOrder = new SqlCommand("UPDATE [Order_Item] SET status = @orderstatus WHERE order_item_id = @itemid", OpenConnection());
            queryUpdateOrder.Parameters.AddWithValue("@orderstatus", item.Order_Status.ToString());
            queryUpdateOrder.Parameters.AddWithValue("@itemid", item.OrderItemID.ToString());
            queryUpdateOrder.ExecuteNonQuery();
            CloseConnection();
        }

        public List<OrderItem> GetItemsById(int id)
        {
            List<OrderItem> orderItems = new List<OrderItem>();
            SqlCommand cmd = new SqlCommand("SELECT MenuItem.menu_item_name, MenuItem.menu_item_price, quantity, Order_Item.comment, Order_Item.status FROM [Order] JOIN Order_Item ON order_number = order_ID JOIN MenuItem ON MenuItem.menu_item_id = Order_Item.menu_item_id WHERE order_ID = @id", OpenConnection());
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                OrderItem item = ReturnOrderItem(reader);
                orderItems.Add(item);
            }
            reader.Close();

            return orderItems;
        }

        private OrderItem ReturnOrderItemKitchen(SqlDataReader reader)
        {
            MenuItem item = new MenuItem
            {
                Menu_Item_Name = (string)reader["menu_item_name"],
            };
            int quantity = (int)reader["quantity"];
            string comment = (string)reader["comment"];
            OrderItem orderItem = new OrderItem(item, quantity, comment);
            return orderItem;
        }

        private OrderItem ReturnOrderItem(SqlDataReader reader)
        {
            MenuItem item = new MenuItem
            {
                Menu_Item_Name = (string)reader["menu_item_name"],
                Menu_Item_Price = (int)reader["menu_item_price"],
            };
            int quantity = (int)reader["quantity"];
            string comment = (string)reader["comment"];
            OrderStatus status = (OrderStatus)Enum.Parse(typeof(OrderStatus), reader["status"].ToString());
            OrderItem orderItem = new OrderItem(item, quantity, comment, status);
            return orderItem;
        }

        //made another method below
        /*
        private List<OrderItem> ReadOrderItems(DataTable dataTable)
        {
            List<OrderItem> itemList = new List<OrderItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderItem item = new OrderItem()
                {
                    
                    Quantity = (int)dr["quantity"],
                    Order_Time = (DateTime)(dr["order_time"]),

                };
                itemList.Add(item);
            }
            return itemList;
        }
        */

        private List<OrderItem> ReadOrderItem(DataTable dataTable)
        {
            List<OrderItem> itemList = new List<OrderItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderItem item = new OrderItem()
                {
                    OrderItemID = (int)dr["order_item_id"],
                    Order_Number = (int)dr["order_number"],
                    MenuItemID = menuItemDAO.GetMenuItemByID((int)dr["menu_item_id"]),
                    Quantity = (int)dr["quantity"],
                    Comment = (string)dr["comment"],
                    Order_Status = (OrderStatus)Enum.Parse(typeof(OrderStatus), dr["status"].ToString()),
                    Order_Time = (DateTime)dr["datetime"],
                    Table_Number = tabledao.GetTable((int)dr["table_number"]),

                };
                itemList.Add(item);
            }
            return itemList;
        }
        

    }
}