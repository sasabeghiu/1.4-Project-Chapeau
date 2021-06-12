using System;

namespace ChapeauModel
{
    public class MenuItem
    {
        public int Menu_Item_ID { get; set; }
        public string Menu_Item_Name { get; set; }
        public int Menu_Item_Stock { get; set; }
        public int Menu_Item_Price { get; set; }
        public int Menu_Item_Vat { get; set; }
        public Menu Menu_ID { get; set; }
        public string Menu_Item_Category { get; set; }

        public MenuItem(int menu_item_id, string menu_item_name, int menu_item_stock, int menu_item_price, int menu_item_vat, Menu menu_id, string menu_item_category)
        {
            Menu_Item_ID = menu_item_id;
            Menu_Item_Name = menu_item_name;
            Menu_Item_Stock = menu_item_stock;
            Menu_Item_Price = menu_item_price;
            Menu_Item_Vat = menu_item_vat;
            Menu_ID = menu_id;
            Menu_Item_Category = menu_item_category;
        }
    }
}
