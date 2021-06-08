using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using ChapeauModel;



namespace ChapeauDAL
{
    public class BillDAO : BaseDao
    {
        private SqlConnection dbConnection;
        public BillDAO()
        {
            string connString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
            dbConnection = new SqlConnection(connString);
        }
        public List<Bill> GetBills()
        {
            dbConnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Payment", dbConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Bill> billList = new List<Bill>();
            while (reader.Read())
            {
                Bill bill = Readbill(reader);
                billList.Add(bill);
            }
            reader.Close();
            dbConnection.Close();

            return billList;
        }
        public List<Order> OrderItems()
        {
            OrderDAO order = new OrderDAO();
            return order.GetAllOrders();
        }
        public List<OrderItem> OrderOverview(DataTable dataTable)
        {
            OrderDAO order = new OrderDAO();
            return order.GetOrderItems(dataTable);
        }

        private Bill Readbill(SqlDataReader reader)
        {
            //retrieve data from all fields
            int OrderId = (int)reader["payment_number"];
            int BillId = (int)reader["order_number"];
            int totalPrice = (int)reader["total_price"];
            PaymentType Type = (PaymentType)reader["payment_type"];
            string Feedback = (string)reader["feedback"];
            int Tip = (int)reader["payment_tip"];
            int Vat = (int)reader["vat"];

            //return new bill object
            return new Bill(OrderId, BillId, totalPrice, Type, Feedback, Tip, Vat);
        }


        public void AddtoPayment(Bill Data)
        {
            try
            {
                OpenConnection();
                string query = "INSERT INTO Payment (payment_number,total_price,payment_type,order_number,feedback,payment_tip,vat)" +
                               "VALUES('" + Data.BillId + "','" + Data.TotalPrice + "','" + Data.Type + "','"
                                           + Data.OrderId + "','" + Data.Feedback + "','" + Data.Tip + "','" + Data.Vat + "',') ; ";
                SqlParameter[] sqlParameters = new SqlParameter[0];
                ExecuteEditQuery(query, sqlParameters);
            }
            catch (Exception exp)
            {
                throw new Exception("Adding bill failed: " + exp);
            }
            finally
            {
                CloseConnection();
            }


        }
        public int CalculateBill()
        {
            List<OrderItem> items = new List<OrderItem>();
            int totalprice = 0;
            foreach (OrderItem item in items)
            {
                int price = item.MenuItemID.Menu_Item_Price;
                totalprice = price * item.Quantity;
                totalprice++;
            }
            return totalprice;
        }
        public int VatDrinks()
        {
            List<OrderItem> orderItems = new List<OrderItem>();
            int priceVat = 0;
            foreach(OrderItem item in orderItems)
            {
                if (item.MenuItemID.Menu_Item_Vat == 21)
                {
                    priceVat = item.MenuItemID.Menu_Item_Price % 21;
                }
                else if(item.MenuItemID.Menu_Item_Vat == 9)
                {
                    priceVat = item.MenuItemID.Menu_Item_Price % 9;
                }
                priceVat++;
            }
            return priceVat;
        }
        
    }
}
