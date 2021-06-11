using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ChapeauLogic;
using ChapeauModel;

namespace ChapeauUI
{
    public partial class Bill_PaidInCash : Form
    {
        BillService bill;
        int total;
        public Bill_PaidInCash()
        {
            InitializeComponent();
            bill = new BillService();

            lbl_total.Text = $"{bill.CalculateBill()}";
            total = int.Parse(lbl_total.Text);
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            int received = int.Parse(txtBox_Handin.Text);
            int tip = int.Parse(txtBox_Tip.Text);
            lbl_change.Text = $"{received - total - tip}";
        }

        private void Bill_PaidInCash_Load(object sender, EventArgs e)
        {
        }
    }
}
