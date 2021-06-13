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
                li.SubItems.Add(order.Order_Time.ToString("MM/dd/yyyy HH:mm"));
                li.Tag = order;
                listViewCurrentOrders.Items.Add(li);
            }
        }

        private void listViewCurrentOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewCurrentOrders.SelectedItems.Count > 0)
            {
                lbltest.Text = "2d";
                int orderid = int.Parse(listViewCurrentOrders.SelectedItems[0].Text);
                LoadOrderDetails(orderid);
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
                li.SubItems.Add(order.Order_Time.ToString("MM/dd/yyyy HH:mm"));
                li.Tag = order;
                listViewPreviousOrders.Items.Add(li);
            }
        }

        private void LoadOrderDetails(int orderid)
        {
            OrderService orderService = new OrderService();
            List<OrderItem> itemList = orderService.GetOrderItemsById(orderid);

            //MenuService menuService = new MenuService();
            //Menu menu = menuService.GetByMenuId(2);
            listViewDetailsK.Clear();
            listViewDetailsK.View = View.Details;
            listViewDetailsK.Items.Clear();

            listViewDetailsK.Columns.Add("Item name");
            listViewDetailsK.Columns.Add("Item quantity");
            listViewDetailsK.Columns.Add("Item comment");

            foreach (OrderItem item in itemList)
            {
                ListViewItem li = new ListViewItem(item.MenuItemID.Menu_Item_Name);
                li.SubItems.Add(item.Quantity.ToString());
                li.SubItems.Add(item.Comment);
                li.Tag = item;
                listViewDetailsK.Items.Add(li);
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

        private void KitchenView_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Logout();
        }


    }
}
