using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ChapeauLogic;
using ChapeauModel;

namespace ChapeauUI
{
    //Alexandru
    public partial class TableOverview : Form
    {
        //logic and model layers used later on
        Employee user;
        TableService tableService;
        OrderService orderService;

        public TableOverview(Employee user)
        {
            this.user = user;
            tableService = new TableService();
            orderService = new OrderService();
            InitializeComponent();
        }

        private void TableOverview_Load(object sender, EventArgs e)
        {
            lbl_user.Text = $"User: ({user.Employee_Role}) {user.First_Name} {user.Last_Name}";
            GetTableState();
            GetOrderState();
        }

        //display different colors for different states of table 
        private void GetTableState()
        {
            //getting the list of tables from DB and creating a list of buttons for each table
            List<Table> tables = tableService.GetTables();
            Button[] buttons = { btn_table_one, btn_table_two, btn_table_three, btn_table_four, btn_table_five, btn_table_six, btn_table_seven, btn_table_eight, btn_table_nine, btn_table_ten };

            for (int i = 0; i < tables.Count; i++)
            {
                if (tables[i].Table_Availability == Table_Availability.Available)
                {
                    buttons[i].BackColor = Color.Green;
                }
                else if (tables[i].Table_Availability == Table_Availability.Reserved)
                {
                    buttons[i].BackColor = Color.Orange;
                }
                else if (tables[i].Table_Availability == Table_Availability.Occupied)
                {
                    buttons[i].BackColor = Color.Red;
                }
            }
        }

        //display different icons for different states of order 
        private void GetOrderState()
        {
            //getting the list of tables from DB and creating a list of icons for each order(table) and a list of labels for time displaying
            List<Table> tables = tableService.GetTables();
            PictureBox[] orderStatus = { pB_StatusOrder1, pB_StatusOrder2, pB_StatusOrder3, pB_StatusOrder4, pB_StatusOrder5, pB_StatusOrder6, pB_StatusOrder7, pB_StatusOrder8, pB_StatusOrder9, pB_StatusOrder10 };
            Label[] orderRunningtimer = { lbl_timerOrder1, lbl_timerOrder2, lbl_timerOrder3, lbl_timerOrder4, lbl_timerOrder5, lbl_timerOrder6, lbl_timerOrder7, lbl_timerOrder8, lbl_timerOrder9, lbl_timerOrder10 };
            
            for (int i = 0; i < tables.Count; i++)
            {
                List<OrderItem> listoforders = orderService.GetOrderItemsById(i + 1);
                foreach (OrderItem order in listoforders)
                {
                    if (order.Order_Status == OrderStatus.Ordered)
                    {
                        orderStatus[i].Image = Properties.Resources.status_ordered;
                        orderRunningtimer[i].Text = order.Order_Time.ToString("mm:ss");
                    }
                    else if (order.Order_Status == OrderStatus.Preparing)
                    {
                        orderStatus[i].Image = Properties.Resources.status_preparing;
                        orderRunningtimer[i].Text = order.Order_Time.ToString("mm:ss");
                    }
                    else if (order.Order_Status == OrderStatus.Ready)
                    {
                        orderStatus[i].Image = Properties.Resources.status_ready;
                    }
                    else if (order.Order_Status == OrderStatus.Delivered)
                    {
                        orderStatus[i].Image = Properties.Resources.status_delivered;
                    }
                }
            }
        }

        //when selecting a table a new form with order details will be opened depending on the table
        private void SelectedTable(int tableNr)
        {
            this.Hide();
            TableOrderView orderView = new TableOrderView(user, tableNr);
            orderView.ShowDialog();
            this.Close();
        }

        //select any table
        private void btn_table_one_Click(object sender, EventArgs e)
        {
            SelectedTable(1);
        }

        private void btn_table_two_Click(object sender, EventArgs e)
        {
            SelectedTable(2);
        }

        private void btn_table_three_Click(object sender, EventArgs e)
        {
            SelectedTable(3);
        }

        private void btn_table_four_Click(object sender, EventArgs e)
        {
            SelectedTable(4);
        }

        private void btn_table_five_Click(object sender, EventArgs e)
        {
            SelectedTable(5);
        }

        private void btn_table_six_Click(object sender, EventArgs e)
        {
            SelectedTable(6);
        }

        private void btn_table_seven_Click(object sender, EventArgs e)
        {
            SelectedTable(7);
        }

        private void btn_table_eight_Click(object sender, EventArgs e)
        {
            SelectedTable(8);
        }

        private void btn_table_nine_Click(object sender, EventArgs e)
        {
            SelectedTable(9);
        }

        private void btn_table_ten_Click(object sender, EventArgs e)
        {
            SelectedTable(10);
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

        //refresh button
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            this.Hide();
            TableOverview overview = new TableOverview(user);
            overview.ShowDialog();
            this.Close();
        }
    }
}
