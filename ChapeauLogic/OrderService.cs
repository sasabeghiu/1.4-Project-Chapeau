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

        public List<Order> GetAllOrders()
        {
            List<Order> orders = ordersdb.GetAllOrders();
            return orders;
        }

        public List<OrderItem> GetAllOrderItems()
        {
            List<OrderItem> orderItems = ordersdb.GetAllOrderItems();
            return orderItems;
        }

        public void UpdateOrderStatusToOrdered(Order order, OrderStatus ordered)
        {
            ordersdb.UpdateOrderStatusToOrdered(order, ordered);
        }

        public void UpdateOrderStatusToPreparing(Order order, OrderStatus preparing)
        {
            ordersdb.UpdateOrderStatusToPreparing(order, preparing);
        }

        public void UpdateOrderStatusToReady(Order order, OrderStatus ready)
        {
            ordersdb.UpdateOrderStatusToReady(order, ready);
        }

        public void UpdateOrderStatusToDelivered(Order order, OrderStatus delivered)
        {
            ordersdb.UpdateOrderStatusToDelivered(order, delivered);
        }
    }
}
