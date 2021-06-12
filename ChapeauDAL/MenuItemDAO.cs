using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using ChapeauModel;
using System.Data;

namespace ChapeauDAL
{
    public class MenuItemDAO : BaseDao
    {
<<<<<<< HEAD
        //sasa changeed  this method
=======

>>>>>>> parent of ee71bd3 (changed the tables colors depending on availability)
        public List<MenuItem> GetAllMenuItems()
        {
            OpenConnection();
            SqlCommand queryGetAll = new SqlCommand("SELECT * FROM [MenuItem]");
            SqlDataReader reader = queryGetAll.ExecuteReader();
            List<MenuItem> menuItems = new List<MenuItem>();
            while (reader.Read())
            {
                MenuItem menuItem = ReadMenuItem(reader);
                menuItems.Add(menuItem);
            }
            reader.Close();
            CloseConnection();
            return menuItems;
        }

        public MenuItem GetMenuItemByID(int id)
        {
            OpenConnection();
            SqlCommand queryGetByID = new SqlCommand("SELECT * FROM [MenuItem] WHERE menu_item_id = @id");
            queryGetByID.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = queryGetByID.ExecuteReader();
            MenuItem menuItem = null;
            if (reader.Read())
            {
                menuItem = ReadMenuItem(reader);
            }
            reader.Close();
            CloseConnection();
            return menuItem;
        }

        public List<MenuItem> GetMenuItemsByCategory(int menuItemCategory)
        {
            OpenConnection();
            SqlCommand queryGetByID = new SqlCommand("SELECT * FROM [MenuItem] WHERE menu_item_category = @id");
            queryGetByID.Parameters.AddWithValue("@id", menuItemCategory);
            SqlDataReader reader = queryGetByID.ExecuteReader();
            List<MenuItem> menuItems = new List<MenuItem>();
            while (reader.Read())
            {
                MenuItem menuItem = ReadMenuItem(reader);
                menuItems.Add(menuItem);
            }
            reader.Close();
            CloseConnection();
            return menuItems;
        }

        public MenuItem GetMenuItemByName(string menuItemName)
        {
            OpenConnection();
            SqlCommand queryGetByID = new SqlCommand("SELECT * FROM [MenuItem] WHERE menu_item_name = @name");
            queryGetByID.Parameters.AddWithValue("@name", menuItemName);
            SqlDataReader reader = queryGetByID.ExecuteReader();
            MenuItem menuItem = null;
            if (reader.Read())
            {
                menuItem = ReadMenuItem(reader);
            }
            reader.Close();
            CloseConnection();
            return menuItem;
        }

        private MenuItem ReadMenuItem(SqlDataReader reader)
        {
            int menuItemID = (int)reader["menu_item_id"];
            string menuItemName = (string)reader["menu_item_name"];
            int menuItemStock = (int)reader["menu_item_stock"];
            int menuItemPrice = (int)reader["menu_item_price"];
            int menuItemVAT = (int)reader["menu_item_vat"];
            Menu menuid = (Menu)reader["menu_id"];
            string category = (string)reader["menu_item_category"];

            return new MenuItem(menuItemID, menuItemName, menuItemStock, menuItemPrice, menuItemVAT, menuid, category);
        }
    }
}
