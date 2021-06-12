using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ChapeauLogic;
using ChapeauModel;

namespace ChapeauUI
{
    public partial class lbl_TableOverview : Form
    {
        Employee user;
        TableService tableService;

        public lbl_TableOverview(Employee user)
        {
            this.user = user;
            tableService = new TableService();
            InitializeComponent();
        }

        private void TableOverview_Load(object sender, EventArgs e)
        {
            lbl_user.Text = "User: " + user.First_Name + user.Last_Name;
            
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
    }
}
