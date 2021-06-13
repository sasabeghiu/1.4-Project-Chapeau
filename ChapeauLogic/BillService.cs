using ChapeauDAL;
using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ChapeauLogic
{
    public class BillService
    {
        BillDAO billdb;
        OrderDAO orderdb;

        public BillService()
        {
            billdb = new BillDAO();
            orderdb = new OrderDAO();

        }
        public List<Bill> GetBills()
        {
            List<Bill> billList = billdb.GetBills();
            return billList;
        }
        public List<Order> OrderItems()
        {
            return orderdb.GetAllOrders();
            
        }
        public List<OrderItem> OrderOverview()
        {
            return orderdb.GetAllOrderItems();
        }
        public int CalculateBill()
        {
            return billdb.CalculateBill();
        }
        public int VatDrinks()
        {
            return billdb.VatDrinks();
        }
        public void AddtoPayment(Bill Data)
        {
            billdb.AddtoPayment(Data);
        }
    }
}
