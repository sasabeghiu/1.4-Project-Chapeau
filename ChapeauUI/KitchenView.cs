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
            LoadKitchenOrders();
        }

        private void LoadKitchenOrders()
        {
            OrderService orderService = new OrderService();

            List<Order> orderList = orderService.GetKitchenOrders();

            listViewKitchen.View = View.Details;
            listViewKitchen.Items.Clear();

            foreach(Order order in orderList)
            {
                ListViewItem li = new ListViewItem(order.OrderID.ToString());
                li.SubItems.Add(order.Order_Status.ToString());
                li.SubItems.Add(order.Order_Time.ToString("MM/dd/yyyy HH:mm"));
                li.Tag = order;
                listViewKitchen.Items.Add(li);
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
    }
}
