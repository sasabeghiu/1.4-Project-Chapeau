﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauModel;
using ChapeauLogic;

namespace ChapeauUI
{
    public partial class Login : Form
    {
        Employee user;
        EmployeeService employeeService;
        public Login()
        {
            InitializeComponent();
            employeeService = new EmployeeService();
            //hide the pin
            txtPin.UseSystemPasswordChar = true;
            txtPin.PasswordChar = '*';
            //set the textbox max length to 4
            //txtPin.MaxLength = 4; //its not working so i added an if statement in every button
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            //int pin = int.Parse(txtPin.Text);
            //user = employeeService.GetByMenuId(pin);
            //if (txtPin.Text == user.Employee_Password.ToString())

            if (txtPin.Text == "1111")
            {
                this.Hide();
                TableOverview form = new TableOverview();
                form.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect PIN, try again.");
            }
        }

        private void btn_one_Click(object sender, EventArgs e)
        {
            if (txtPin.Text.Length <= 3)
            {
                txtPin.Text += "1";
            }
            else
            {
                txtPin.Text = txtPin.Text;
            }

        }

        private void btn_two_Click(object sender, EventArgs e)
        {
            if (txtPin.Text.Length <= 3)
            {
                txtPin.Text += "2";
            }
            else
            {
                txtPin.Text = txtPin.Text;
            }
        }

        private void btn_three_Click(object sender, EventArgs e)
        {
            if (txtPin.Text.Length <= 3)
            {
                txtPin.Text += "3";
            }
            else
            {
                txtPin.Text = txtPin.Text;
            }
        }

        private void btn_four_Click(object sender, EventArgs e)
        {
            if (txtPin.Text.Length <= 3)
            {
                txtPin.Text += "4";
            }
            else
            {
                txtPin.Text = txtPin.Text;
            }
        }

        private void btn_five_Click(object sender, EventArgs e)
        {
            if (txtPin.Text.Length <= 3)
            {
                txtPin.Text += "5";
            }
            else
            {
                txtPin.Text = txtPin.Text;
            }
        }

        private void btn_six_Click(object sender, EventArgs e)
        {
            if (txtPin.Text.Length <= 3)
            {
                txtPin.Text += "6";
            }
            else
            {
                txtPin.Text = txtPin.Text;
            }
        }

        private void btn_seven_Click(object sender, EventArgs e)
        {
            if (txtPin.Text.Length <= 3)
            {
                txtPin.Text += "7";
            }
            else
            {
                txtPin.Text = txtPin.Text;
            }
        }

        private void btn_eight_Click(object sender, EventArgs e)
        {
            if (txtPin.Text.Length <= 3)
            {
                txtPin.Text += "8";
            }
            else
            {
                txtPin.Text = txtPin.Text;
            }
        }

        private void btn_nine_Click(object sender, EventArgs e)
        {
            if (txtPin.Text.Length <= 3)
            {
                txtPin.Text += "9";
            }
            else
            {
                txtPin.Text = txtPin.Text;
            }
        }

        private void btn_zero_Click(object sender, EventArgs e)
        {
            if (txtPin.Text.Length <= 3)
            {
                txtPin.Text += "0";
            }
            else
            {
                txtPin.Text = txtPin.Text;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtPin.Text = "";
        }
    }
}