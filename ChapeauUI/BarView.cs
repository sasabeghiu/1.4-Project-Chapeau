using ChapeauLogic;
using ChapeauModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChapeauUI
{
    public partial class BarView : Form
    {
        public BarView()
        {
            InitializeComponent();
            LoadCurrentOrders();
        }

        private void LoadCurrentOrders()
        {
            panelBarCurrent.Show();
            panelBarPrevious.Hide();

            OrderService orderService = new OrderService();

            List<Order> orderList = orderService.GetCurrentOrders();

            listViewCurrentOrders.View = View.Details;
            listViewCurrentOrders.Items.Clear();

            foreach (Order order in orderList)
            {
                ListViewItem li = new ListViewItem(order.OrderID.ToString());
                li.SubItems.Add(order.Order_Status.ToString());
                li.SubItems.Add(order.Order_Time.ToString("MM/dd/yyyy HH:mm"));
                li.Tag = order;
                listViewCurrentOrders.Items.Add(li);
            }
        }

        private void LoadPreviousOrders()
        {
            panelBarPrevious.Show();
            panelBarCurrent.Hide();

            OrderService orderService = new OrderService();

            List<Order> orderList = orderService.GetPreviousOrders();

            listViewPreviousOrders.View = View.Details;
            listViewPreviousOrders.Items.Clear();

            foreach (Order order in orderList)
            {
                ListViewItem li = new ListViewItem(order.OrderID.ToString());
                li.SubItems.Add(order.Order_Status.ToString());
                li.SubItems.Add(order.Order_Time.ToString("MM/dd/yyyy HH:mm"));
                li.Tag = order;
                listViewPreviousOrders.Items.Add(li);
            }
        }

        private void listViewCurrentOrders_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listViewCurrentOrders.SelectedItems.Count > 0)
            {
                int orderid = int.Parse(listViewCurrentOrders.SelectedItems[0].Text);
                LoadOrderDetailsC(orderid);
            }
        }

        private void listViewPreviousOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPreviousOrders.SelectedItems.Count > 0)
            {
                int orderid = int.Parse(listViewPreviousOrders.SelectedItems[0].Text);
                LoadOrderDetailsP(orderid);
            }
        }
        private void LoadOrderDetailsC(int orderid)
        {
            OrderService orderService = new OrderService();
            List<OrderItem> itemList = orderService.GetOrderItemsByID(orderid, "bar");

            lblDetailsBC.Text = $"Order Details for Order  #({orderid})";

            listViewDetailsBC.CheckBoxes = true;
            listViewDetailsBC.View = View.Details;
            listViewDetailsBC.Items.Clear();

            foreach (OrderItem item in itemList)
            {
                ListViewItem li = new ListViewItem(item.Quantity.ToString());
                li.SubItems.Add(item.MenuItemID.Menu_Item_Name);
                li.SubItems.Add(item.Comment);
                li.Tag = item;
                listViewDetailsBC.Items.Add(li);
            }
        }

        private void LoadOrderDetailsP(int orderid)
        {
            OrderService orderService = new OrderService();
            List<OrderItem> itemList = orderService.GetOrderItemsByID(orderid, "bar");

            lblDetailsBC.Text = $"Order Details for Order  #({orderid})";

            listViewDetailsBP.CheckBoxes = true;
            listViewDetailsBP.View = View.Details;
            listViewDetailsBP.Items.Clear();

            foreach (OrderItem item in itemList)
            {
                ListViewItem li = new ListViewItem(item.Quantity.ToString());
                li.SubItems.Add(item.MenuItemID.Menu_Item_Name);
                li.SubItems.Add(item.Comment);
                li.Tag = item;
                listViewDetailsBP.Items.Add(li);
            }
        }

        private void Logout()
        {
            var result = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                Login loginpage = new Login();
                loginpage.ShowDialog();
                this.Close();
            }
        }
        private void BtnCurrentB_Click(object sender, EventArgs e)
        {
            LoadCurrentOrders();
        }

        private void btnPreviousB_Click_1(object sender, EventArgs e)
        {
            btnMarkAsReadyBP.Enabled = false;
            LoadPreviousOrders();
        }

        private void btnLogOut_Click_1(object sender, EventArgs e)
        {
            Logout();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void btnMarkAsReadyBC_Click(object sender, EventArgs e)
        {
            if (listViewCurrentOrders.SelectedItems.Count == 1)
            {
                OrderService orderService = new OrderService();

                Order order = listViewCurrentOrders.SelectedItems[0].Tag as Order;
                order.Order_Status = OrderStatus.Ready;

                orderService.MarkOrderAsReady(order);
                LoadCurrentOrders();
            }
        }
    }
}
