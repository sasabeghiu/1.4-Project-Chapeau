using System;
using System.Collections.Generic;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    public class MenuService
    {
        MenuDAO menudb;
        MenuItemDAO menuitemdb;

        public MenuService()
        {
            menudb = new MenuDAO();
            menuitemdb = new MenuItemDAO();
        }


        public List<Menu> GetAll()
        {
            List<Menu> menuList = menudb.GetAll();
            return menuList;
        }

        public Menu GetByMenuId(int menu_id)
        {
            Menu menu = menudb.GetById(menu_id);
            return menu;
        }

        public List<MenuItem> GetAllMenuItems()
        {
            List<MenuItem> menuItems = menuitemdb.GetAllMenuItems();
            return menuItems;
        }
    }
}
