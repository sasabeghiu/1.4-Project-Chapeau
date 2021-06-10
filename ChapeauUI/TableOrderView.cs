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
            lbl_user.Text = user.First_Name + user.Last_Name;
        }
    }
}
