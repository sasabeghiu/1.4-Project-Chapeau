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

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       //this can't be done until the menu is updated private void DisplayMenuItems()
       // {

        //    List<MenuItem> menuItems = MenuService.GetByMenuId(menu_id);
        //    foreach (MenuItem menuItem in menuItems)
        //    {

        //    }
        


    }
}
