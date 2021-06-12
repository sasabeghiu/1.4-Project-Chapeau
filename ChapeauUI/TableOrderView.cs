using System;
using System.Windows.Forms;
using ChapeauLogic;
using ChapeauModel;

namespace ChapeauUI
{
    public partial class TableOrderView : Form
    {
        Employee user;
        Table table;

        public TableOrderView(Employee user, int tableNr)
        {
            this.user = user;
            /*TableService tableService = new TableService();
            Table table = tableService.GetTable(tableNr);
            this.table = table;*/
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

            /*
            if(table.Table_Availability==Table_Availability.Occupied)
            {
                btn_seatGuests.Hide();
            }
            OrderService orderService = new OrderService();
            List<Order> orderList = new List<Order>();
            listViewOrders.Clear();
            listViewOrders.View = View.Details;
            listViewOrders.Columns.Add("Item");
            listViewOrders.Columns.Add("Quantity");
            listViewOrders.Columns.Add("Price");
            foreach(Order o in orderList)
            {
                ListViewItem li = new ListViewItem(new String[] { o. });
                listViewOrders.Items.Add(li);
            }
            listViewOrders.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent); //Auto resize colums to fit data
            listViewOrders.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize); // Make sure headers fit
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bill billpage = new Bill();
            billpage.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderDisplayMenu menupage = new OrderDisplayMenu();
            menupage.ShowDialog();
            this.Close();
        }
    }
}
