using System;
using System.Collections.Generic;
using System.Configuration;
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
            //same here
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
        public Order GetHost()
        {
            dbConnection.Open();
            SqlCommand cmd = new SqlCommand("", dbConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            Order order_host = new Order();
            while (reader.Read())
            {
                order_host = Readhost(reader);
            }
            return order_host;

        }
        private Order Readhost(SqlDataReader reader)
        {
            Order name = (Order)reader["employee_number"];
            return name;
            
        }
        public List<OrderItem> GetItems()
        {
            List<OrderDAO> items_list= new OrderDAO();
            return items_list.GetOrderItems();

        }
      
        private Bill Readbill(SqlDataReader reader)
        {
            //retrieve data from all fields
            int OrderId = (int)reader["payment_number"];
            int BillId = (int)reader["order_number"];
            Order host_name = GetHost();
            List<OrderItem> items = GetItems();
            int totalPrice = (int)reader["total_price"];
            PaymentType Type = (PaymentType)reader["payment_type"];
            string Feedback = (string)reader["feedback"];
            int Tip = (int)reader["payment_tip"];
            int Vat = (int)reader["vat"];

            //return new bill object
            return new Bill() ;
        }
    }
}
