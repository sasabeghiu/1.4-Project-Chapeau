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
        public Bill_PaidInCash()
        {
            InitializeComponent();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            (new Bill()).Show(); this.Close();
        }

        private void Bill_PaidInCash_Load(object sender, EventArgs e)
        {
            BillService bill = new BillService();
            lbl_total.Text = $"{bill.CalculateBill()}";
            int total = int.Parse(lbl_total.Text);
            int receveid = int.Parse(txtBox_Handin.Text);
            int tip = int.Parse(txtBox_Tip.Text);
            lbl_change.Text = $"{receveid - total - tip}";
        }
    }
}
