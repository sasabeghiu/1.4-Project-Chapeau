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

        public BillService()
        {
            billdb = new BillDAO();
        }
        public List<Bill> GetBills()
        {
            List<Bill> billList = billdb.GetBills();
            return billList;
        }
        public List<Order> OrderItems()
        {
            return billdb.OrderItems();
            
        }
        public List<OrderItem> OrderOverview(DataTable dataTable)
        {
            return billdb.OrderOverview(dataTable);
        }
        public int CalculateBill()
        {
            return billdb.CalculateBill();
        }
        public int VatDrinks()
        {
            return billdb.VatDrinks();
        }
    }
}
