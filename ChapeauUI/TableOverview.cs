using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ChapeauLogic;
using ChapeauModel;

namespace ChapeauUI
{
    public partial class TableOverview : Form
    {
        Employee user;
        TableService tableService;
       
        public TableOverview(Employee user)
        {
            this.user = user;
            tableService = new TableService();
            InitializeComponent();
        }

        private void TableOverview_Load(object sender, EventArgs e)
        {
            lbl_user.Text = user.First_Name + user.Last_Name;

            /*List<Table> tables = tableService.GetTables();
            foreach(Table table in tables)
            {
                if (table.Table_Availability==Table_Availability.Available)
                {
                    //
                }
            }*/
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

            if (result==DialogResult.Yes)
            {
                this.Hide();
                Login loginpage = new Login();
                loginpage.ShowDialog();
                this.Close();
            }
        }
    }
}
