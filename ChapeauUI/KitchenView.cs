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

            if(listViewCurrentOrders.SelectedItems.Count > 0)
            {

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

        private void btnLogOut_Click(object sender, EventArgs e) //logout button
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

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            LoadPreviousOrders();
        }

        private void btnCurrent_Click(object sender, EventArgs e)
        {
            LoadCurrentOrders();
        }
    }
}
