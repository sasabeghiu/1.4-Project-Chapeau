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
    public partial class OrderDisplayMenu : Form
    {
        public Order currentOrder { get; set; }

        static OrderDisplayMenu orderDisplayMenu;
        MenuService menuService = new MenuService();
        DataTable dataTable;

        public OrderDisplayMenu()
        {
            InitializeComponent();

        }


        public static OrderDisplayMenu GetInstance()
        {
            if (orderDisplayMenu == null)
                orderDisplayMenu = new OrderDisplayMenu();
            return orderDisplayMenu;
        }




        private void Order_Load(object sender, EventArgs e)
        {
            List<MenuItem> menuitems = menuService.GetAllMenuItems();
            listViewMenus.View = View.Details;

            foreach (MenuItem menuitem in menuitems)
            {
                ListViewItem lv1 = new ListViewItem(menuitem.Menu_Item_ID.ToString());
                lv1.SubItems.Add(menuitem.Menu_Item_Name);
                lv1.SubItems.Add(menuitem.Menu_Item_Stock.ToString());
                listViewMenus.Items.Add(lv1);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
