using ChapeauLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChapeauUI
{
    public partial class KitchenView : Form
    {
        public KitchenView()
        {
            InitializeComponent();
            LoadOrders();
        }

        private void LoadOrders()
        {
            List<Order> orderList = new List<Order>();
            OrderService orderService = new OrderService();

            orderList = orderService.GetOrders();

            listViewKitchen.View = View.Details;

            foreach(Order order in orderList)
            {
                ListViewItem item = new ListViewItem(order.OrderID.ToString());
                item.SubItems.Add(order.Order_Status.ToString());
                item.SubItems.Add(order.Order_Time.ToString());
                listViewKitchen.Items.Add(item);
            }


        }
    }
}
