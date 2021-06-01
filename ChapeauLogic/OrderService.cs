using System.Collections.Generic;
using ChapeauModel;
using ChapeauDAL;

namespace ChapeauLogic
{
    public class OrderService
    {
        OrderDAO ordersdb;

        public OrderService()
        {
            ordersdb = new OrderDAO();
        }

        public List<Order> GetOrders()
        {
            List<Order> orders = ordersdb.GetAllOrders();
            return orders;
        }

        public void UpdateOrder(Order order, bool completed)
        {
            ordersdb.UpdateOrder(order, completed);
        }
    }
}
