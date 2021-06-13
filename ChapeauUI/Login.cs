using System;
using System.Windows.Forms;
using ChapeauModel;
using ChapeauLogic;

namespace ChapeauUI
{
    //Alexandru
    public partial class Login : Form
    {
        //logic and model layers used later on
        Employee user;
        EmployeeService employeeService;

        public Login()
        {
            InitializeComponent();
            employeeService = new EmployeeService();

            //hide the pin
            txtPin.UseSystemPasswordChar = true;
            txtPin.PasswordChar = '*';
        }

        //login in dependence of user role
        private void btn_Login_Click(object sender, EventArgs e)
        {
            string pin = txtPin.Text;

            if (pin == "")
            {
                MessageBox.Show("Please enter your PIN-code", "PIN Required");
            }

            user = employeeService.GetEmployeeByPassword(pin);

            if (user != null)
            {
                if (user.Employee_Role == EmployeeRole.Waiter)
                {
                    this.Hide();
                    TableOverview waiterform = new TableOverview(user);
                    waiterform.ShowDialog();
                    this.Close();
                }
                else if (user.Employee_Role == EmployeeRole.Bartender)
                {
                    this.Hide();
                    BarView barform = new BarView();
                    barform.ShowDialog();
                    this.Close();
                }
                else if (user.Employee_Role == EmployeeRole.Chef)
                {
                    this.Hide();
                    KitchenView cheform = new KitchenView();
                    cheform.ShowDialog();
                    this.Close();
                }
                else if (user.Employee_Role == EmployeeRole.Manager)
                {
                    MessageBox.Show("We have no manager", "No manager");
                }
            }
            else
            {
                MessageBox.Show("Incorrect PIN, please try again.", "Wrong PIN");
            }
        }

        //created this method because txt.maxlegth was not working
        private void SelectedButtons(int button)
        {
            if (txtPin.Text.Length <= 3)
            {
                txtPin.Text += button;
            }
            else
            {
                txtPin.Text = txtPin.Text;
            }
        }

        private void btn_one_Click(object sender, EventArgs e)
        {
            SelectedButtons(1);
        }

        private void btn_two_Click(object sender, EventArgs e)
        {
            SelectedButtons(2);
        }

        private void btn_three_Click(object sender, EventArgs e)
        {
            SelectedButtons(3);
        }

        private void btn_four_Click(object sender, EventArgs e)
        {
            SelectedButtons(4);
        }

        private void btn_five_Click(object sender, EventArgs e)
        {
            SelectedButtons(5);
        }

        private void btn_six_Click(object sender, EventArgs e)
        {
            SelectedButtons(6);
        }

        private void btn_seven_Click(object sender, EventArgs e)
        {
            SelectedButtons(7);
        }

        private void btn_eight_Click(object sender, EventArgs e)
        {
            SelectedButtons(8);
        }

        private void btn_nine_Click(object sender, EventArgs e)
        {
            SelectedButtons(9);
        }

        private void btn_zero_Click(object sender, EventArgs e)
        {
            SelectedButtons(0);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtPin.Text = "";
        }
    }
}
