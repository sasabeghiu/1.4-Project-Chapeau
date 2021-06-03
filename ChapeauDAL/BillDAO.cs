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
        
      
        private Bill Readbill(SqlDataReader reader)
        {
            //retrieve data from all fields
            int OrderId = (int)reader["payment_number"];
            int BillId = (int)reader["order_number"];
            Order host = host.Employee_Number.First_Name();
            Order order_items= order_itemsprice.orderItems();
            int totalPrice = (int)reader["total_price"];
            PaymentType Type = (PaymentType)reader["payment_type"];
            string Feedback = (string)reader["feedback"];
            int Tip = (int)reader["payment_tip"];
            int Vat = (int)reader["vat"];

            //return new bill object
            return new Bill(OrderId,BillId,host,order_itemsprice,totalPrice,Type,Feedback,Tip,Vat) ;
        }
        public List<MenuItem> ItemsPrice()
        {

        } 
        public int DuplicateItems() //Set price if an item was order more than once
        {
            OrderItem item_quantity=order.Quantity;// how many
            OrderItem item_id=item_id.OrderItemID;//what
            Order items = items.orderItems();//the list of items ordered
            int price =0;
            foreach(OrderItem item in items)
            {
              price = item_id* item_quantity // multiply item with quantity
            }
            return price;

        }
        public int TotalPrice()
        {
            Order order_items = order_items.orderItems();
            int total=0;
            int item_price;
            foreach (OrderItem item in order_items)
            {
                item_price =item.MenuItemID.Menu_Item_Price;
                 
            }
            total=item_price+item_price;
            return total;
        }
    }
}
