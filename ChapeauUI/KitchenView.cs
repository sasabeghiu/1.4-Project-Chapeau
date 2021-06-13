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
    public partial class KitchenView : Form
    {
        public KitchenView()
        {
            InitializeComponent();
            LoadCurrentOrders();
        }

        private void LoadCurrentOrders()
        {
            panelKitchenCurrent.Show();
            panelKitchenPrevious.Hide();

            OrderService orderService = new OrderService();

            List<Order> orderList = orderService.GetCurrentOrders();

            listViewCurrentOrders.View = View.Details;
            listViewCurrentOrders.Items.Clear();

            foreach(Order order in orderList)
            {
                ListViewItem li = new ListViewItem(order.OrderID.ToString());
                li.SubItems.Add(order.Order_Status.ToString());
                li.SubItems.Add(order.Order_Time.ToString("HH:mm MM/dd/yyyy"));
                li.Tag = order;
                listViewCurrentOrders.Items.Add(li);
            }
        }

        private void LoadPreviousOrders()
        {
            panelKitchenPrevious.Show();
            panelKitchenCurrent.Hide();

            OrderService orderService = new OrderService();

            List<Order> orderList = orderService.GetPreviousOrders();

            listViewPreviousOrders.View = View.Details;
            listViewPreviousOrders.Items.Clear();

            foreach (Order order in orderList)
            {
                ListViewItem li = new ListViewItem(order.OrderID.ToString());
                li.SubItems.Add(order.Order_Status.ToString());
                li.SubItems.Add(order.Order_Time.ToString("HH:mm MM/dd/yyyy"));
                li.Tag = order;
                listViewPreviousOrders.Items.Add(li);
            }
        }

        private void listViewCurrentOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewCurrentOrders.SelectedItems.Count > 0)
            {
                int orderid = int.Parse(listViewCurrentOrders.SelectedItems[0].Text);
                LoadOrderDetailsC(orderid);
            }
        }

        private void listViewPreviousOrders_SelectedIndexChanged_1(object sender, EventArgs e)
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
            List<OrderItem> itemList = orderService.GetOrderItemsById(orderid, "kitchen");

            lblDetailsKC.Text = $"Order Details for Order  #({orderid})";

            listViewDetailsKC.CheckBoxes = true;
            listViewDetailsKC.View = View.Details;
            listViewDetailsKC.Items.Clear();

            foreach (OrderItem item in itemList)
            {
                if (item.MenuItemID.Menu_Item_Category == "Drinks")
                {
                    continue;
                }
                else
                {
                    ListViewItem li = new ListViewItem(item.Quantity.ToString());
                    li.SubItems.Add(item.MenuItemID.Menu_Item_Name);
                    li.SubItems.Add(item.Comment);
                    li.Tag = item;
                    listViewDetailsKC.Items.Add(li);
                }
            }
        }

        private void LoadOrderDetailsP(int orderid)
        {
            OrderService orderService = new OrderService();
            List<OrderItem> itemList = orderService.GetOrderItemsById(orderid, "kitchen");

            lblDetailsKP.Text = $"Order Details for Order  #({orderid})";

            listViewDetailsKP.CheckBoxes = true; //enables check boxes
            listViewDetailsKP.View = View.Details;
            listViewDetailsKP.Items.Clear();

            //ListViewItem li = new ListViewItem();

            foreach (OrderItem item in itemList)
            {
                if (item.MenuItemID.Menu_Item_Category == "Drinks")
                {
                    continue;
                }
                else
                {
                    ListViewItem li = new ListViewItem(item.Quantity.ToString());
                    li.SubItems.Add(item.MenuItemID.Menu_Item_Name);
                    li.SubItems.Add(item.Comment);
                    li.Tag = item;
                    listViewDetailsKP.Items.Add(li);
                }
            }

        }
        private void ItemChecked(string itemName)
        {
            string message = $"{itemName} will be marked as ready";
            string title = "Notification sent to waiter";
            MessageBox.Show(message, title);
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

        private void btnLogOut_Click(object sender, EventArgs e) //logout button
        {
            Logout();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            btnMarkAsReadyKP.Enabled = false;
            LoadPreviousOrders();
        }

        private void btnCurrent_Click(object sender, EventArgs e)
        {
            LoadCurrentOrders();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void btnMarkAsReadyKC_Click(object sender, EventArgs e)
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
