using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ChapeauModel;
using System.Data;

namespace ChapeauDAL
{
    public class MenuItemDAO : BaseDao
    {
        //sasa changeed  this method
        public List<MenuItem> GetAllMenuItems()
        {
            /*
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
            */
            string query = "SELECT * FROM [MenuItem]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadItems(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<MenuItem> ReadItems(DataTable dataTable)
        {
            List<MenuItem> items = new List<MenuItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                MenuItem item = new MenuItem()
                {
                    Menu_Item_ID = (int)(dr["menu_item_id"]),
                    Menu_Item_Name = (string)(dr["menu_item_name"]),
                    Menu_Item_Stock = (int)(dr["menu_item_stock"]),
                    Menu_Item_Price = (int)(dr["menu_item_price"]),
                    Menu_Item_Vat = (int)(dr["menu_item_vat"]),
                    //Menu_ID = (Menu)(dr["menu_id"]),
                    Menu_Item_Category = (string)(dr["menu_item_category"])
                };
                items.Add(item);
            }
            return items;
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
