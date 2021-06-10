using ChapeauLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChapeauUI
{
    public partial class KitchenViewcs : Form
    {
        public KitchenViewcs()
        {
            InitializeComponent();
        }

        private void LoadOrders()
        {
            OrderService orderService = new OrderService();

            List<Order> orders = new List<Order>();
        }
    }
}
