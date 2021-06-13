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

        private Order currentOrder;

        static OrderMain orderMain;
        MenuService menuService = new MenuService();
        OrderService orderService = new OrderService();
        OrderItem oI;
        




        public static OrderMain GetInstance()
        {
            if (orderMain == null)
                orderMain = new OrderMain();
            return orderMain;
        }

        public OrderMain()
        {
            InitializeComponent();
            currentOrder = new Order();
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
                lv1.SubItems.Add(menuitem.Menu_Item_Price.ToString());
                lv1.SubItems.Add(menuitem.Menu_Item_Vat.ToString());
                lv1.SubItems.Add(menuitem.Menu_Item_Category.ToString());
                listViewMenus.Items.Add(lv1);
            }
            listViewMenus.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewMenus.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
 

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
            currentOrder.OrderedItems.Add(oI);
            listViewOrder.Items.Clear();


            foreach (OrderItem orderedItem in currentOrder.OrderedItems)
            {
                ListViewItem lv2 = new ListViewItem(orderedItem.OrderItemID.ToString());
                lv2.SubItems.Add(orderedItem.MenuItemID.Menu_Item_Name);
                lv2.SubItems.Add(orderedItem.Quantity.ToString());
                listViewOrder.Items.Add(lv2);

                listViewOrder.Tag = orderedItem;
            }


            listViewOrder.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewOrder.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

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
                ListViewItem li = listViewMenus.SelectedItems[0];

                oI = new OrderItem();
                MenuItem mI = new MenuItem();

                oI.OrderItemID = int.Parse(li.SubItems[0].Text);
                oI.Quantity = 1;
                // oI.MenuItemID.Menu_Item_Name = li.SubItems[2].Text;
                oI.MenuItemID = mI;
                oI.Comment = "";
                oI.Table_Number = currentOrder.Table_Number;
            }


        }

        private void labelQuantity_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int tableNumber = int.Parse(textBoxTableNumber.Text);


            List<OrderItem> orderItems = orderService.GetOrderItemsByTableID(tableNumber);
            listViewOrder.View = View.Details;


            foreach (OrderItem orderItem in orderItems)
            {
                ListViewItem lv2 = new ListViewItem(orderItem.OrderItemID.ToString());
                lv2.SubItems.Add(orderItem.Quantity.ToString());
                lv2.SubItems.Add(orderItem.MenuItemID.Menu_Item_Name);
                lv2.SubItems.Add(orderItem.Comment);
                listViewOrder.Items.Add(lv2);
            }

            listViewMenus.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewMenus.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            if (tableNumber < 1)
            {
                MessageBox.Show("Please enter a valid table number!");
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
