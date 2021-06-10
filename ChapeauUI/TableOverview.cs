using System;
using System.Windows.Forms;
using ChapeauModel;
using ChapeauLogic;
using System.Collections.Generic;

namespace ChapeauUI
{
    public partial class TableOverview : Form
    {
        Employee user;
        public TableOverview(Employee user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void TableOverview_Load(object sender, EventArgs e)
        {
            TableService tableService = new TableService();
            List<Table> tables = tableService.GetTables();

        }

        //when selecting a table a new form with order details will be opened depending on the table
        private void SelectedTable(int tableNr)
        {
            TableOrderView orderView = new TableOrderView(user, tableNr);
            orderView.Show();
            this.Close();
        }

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
    }
}
