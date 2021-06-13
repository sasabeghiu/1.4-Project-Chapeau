using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ChapeauLogic;
using ChapeauModel;

namespace ChapeauUI
{
    public partial class TableOrderView : Form
    {
        Employee user;
        Table table;
        TableService tableService;

        public TableOrderView(Employee user, int tableNr)
        {
            tableService = new TableService();
            Table table = tableService.GetTable(tableNr);
            this.table = table;
            this.user = user;
            InitializeComponent();
        }

        //logout button
        private void btn_logout_Click(object sender, EventArgs e)
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

        //back to table overview
        private void btn_GoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            TableOverview tablepage = new TableOverview(user);
            tablepage.ShowDialog();
            this.Close();
        }

        private void TableOrderView_Load(object sender, EventArgs e)
        {
            lbl_user.Text = "User: " + user.First_Name + user.Last_Name;
            CheckAvailability();

            OrderService orderService = new OrderService();
            List<OrderItem> itemsList = orderService.GetOrderItemsById(table.Table_Number);

            listViewOrders.Clear();
            listViewOrders.View = View.Details;
            listViewOrders.Columns.Add("Item");
            listViewOrders.Columns.Add("Quantity");
            listViewOrders.Columns.Add("Price");
            listViewOrders.Columns.Add("State");

            foreach(OrderItem o in itemsList)
            {
                ListViewItem li = new ListViewItem(new String[] { o.MenuItemID.Menu_Item_Name, o.Quantity.ToString(), o.MenuItemID.Menu_Item_Price.ToString(), o.Order_Status.ToString() });
                listViewOrders.Items.Add(li);
            }
            listViewOrders.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent); //Auto resize colums to fit data
            listViewOrders.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize); // Make sure headers fit
            
        }

        private void CheckAvailability()
        {

            if (table.Table_Availability == Table_Availability.Occupied)
            {
                btn_seatGuests.Enabled = false;
            }
            else if (table.Table_Availability == Table_Availability.Reserved)
            {
                lbl_Reservation.Text = "Reservation for John and Marie LeClerk at 12:30";
                btn_pay.Enabled = false;
                btn_addOrder.Enabled = false;
            }
            else if (table.Table_Availability == Table_Availability.Available)
            {
                btn_pay.Enabled = false;
                btn_addOrder.Enabled = false;
            }
        }

        //pay the bill
        private void btn_pay_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bill billpage = new Bill();
            billpage.ShowDialog();
            this.Close();
        }
        //open menu
        private void btn_addOrder_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            OrderMain menupage = new OrderMain();
            menupage.ShowDialog();
            this.Close();
        }
        
        //seat guests or mark table as occupied
        private void btn_seatGuests_Click(object sender, EventArgs e)
        {
            //use updatestatus
            //table.Table_Availability = Table_Availability.Occupied;
            MessageBox.Show("The table is now occupied, you can go to the menu.", $"Table {table.Table_Number} state changed");
            btn_addOrder.Enabled = true;
        }
    }
}
