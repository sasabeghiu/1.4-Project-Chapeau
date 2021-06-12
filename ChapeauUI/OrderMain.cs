using ChapeauLogic;
using ChapeauModel;
using ChapeauDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChapeauUI
{
    public partial class OrderMain : Form
    {
        public Order currentOrder { get; set; }

        static OrderMain orderMain;
        MenuService menuService = new MenuService();
        OrderService orderService = new OrderService();


        public static OrderMain GetInstance()
        {
            if (orderMain == null)
                orderMain = new OrderMain();
            return orderMain;
        }

        public OrderMain()
        {
            InitializeComponent();
        }

        private void OrderMain_Load(object sender, EventArgs e)
        {
            //loads menu into list view on left
            List<MenuItem> menuitems = menuService.GetAllMenuItems();
            listViewMenus.View = View.Details;

            foreach (MenuItem menuitem in menuitems)
            {
                ListViewItem lv1 = new ListViewItem(menuitem.Menu_Item_ID.ToString());
                lv1.SubItems.Add(menuitem.Menu_Item_Name);
                lv1.SubItems.Add(menuitem.Menu_Item_Stock.ToString());
                listViewMenus.Items.Add(lv1);
            }
            listViewMenus.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewMenus.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            //loads order items into list view on right

            List<OrderItem> orderItems = orderService.GetAllOrderItems();
            listViewOrder.View = View.Details;

            foreach (OrderItem orderItem in orderItems)
            {
                ListViewItem lv2 = new ListViewItem(orderItem.OrderItemID.ToString());
                lv2.SubItems.Add(orderItem.Order_Number.ToString());
                lv2.SubItems.Add(orderItem.MenuItemID.ToString());
                lv2.SubItems.Add(orderItem.Quantity.ToString());
                lv2.SubItems.Add(orderItem.Comment);
                lv2.SubItems.Add(orderItem.Order_Status.ToString());
                lv2.SubItems.Add(orderItem.Table.ToString());
                lv2.SubItems.Add(orderItem.Order_Time.ToString());
            }

           



        }

        private void buttonTable_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBarKitchen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOrderView_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPayment_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {

        }

        private void buttonComplete_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }

        private void listViewMenus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewMenus.SelectedItems.Count == 1)
            {

            }
        }
    }
}
