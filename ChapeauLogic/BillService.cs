using ChapeauDAL;
using ChapeauModel;
using System;
using System.Collections.Generic;
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
        public Order GetHost()
        {
            Order host = billdb.GetHost();
            return host;
        }
        public List<OrderItem> GetItems()
        {
            List<OrderItem> items = billdb.GetItems();
            return items;
        }
    }
}
