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

        public List<OrderItem> GetOrderItemsByID(int orderid, string parameter)
        {
            if (parameter == "kitchen")
            {
                return  ordersdb.GetKitchenItemsById(orderid);
            }
            return ordersdb.GetBarItemsById(orderid);
        }

        public List<OrderItem> GetOrderItemsById(int orderid)
        {
            List<OrderItem> orderItems = ordersdb.GetItemsById(orderid);
            return orderItems;
        }

        public List<Order> GetCurrentOrders()
        {
            List<Order> orders = ordersdb.GetCurrentOrders();
            return orders;
        }

        public List<Order> GetPreviousOrders()
        {
            List<Order> orders = ordersdb.GetPreviousOrders();
            return orders;
        }

        public void MarkOrderAsReady(Order order)
        {
            ordersdb.MarkAsReady(order);
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
