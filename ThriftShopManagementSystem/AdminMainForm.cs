using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThriftShopManagementSystem
{
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void adminAddUsers1_Load(object sender, EventArgs e)
        {

        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to Sign out?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();

                this.Hide();
            }
        }

        private void adminAddProducts1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminDashboardForm1.Visible = true;
            adminAddUsers1.Visible = false;
            adminAddProducts1.Visible = false;
            userCustomersForm1.Visible = false;
            userAuctionSystem1.Visible = false;

            AdminDashboardForm adForm = adminDashboardForm1 as AdminDashboardForm;

            if(adForm != null)
            {
                adForm.refreshData();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminDashboardForm1.Visible = false;
            adminAddUsers1.Visible = true;
            adminAddProducts1.Visible = false;
            userCustomersForm1.Visible = false;
            userAuctionSystem1.Visible = false;

            AdminAddUsers aaUsers = adminAddUsers1 as AdminAddUsers;

            if (aaUsers != null)
            {
                aaUsers.refreshData();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            adminDashboardForm1.Visible = false;
            adminAddUsers1.Visible = false;
            adminAddProducts1.Visible = true;
            userCustomersForm1.Visible = false;
            userAuctionSystem1.Visible = false;

            AdminAddProducts aaProd = adminAddProducts1 as AdminAddProducts;

            if (aaProd != null)
            {
                aaProd.refreshData();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            adminDashboardForm1.Visible = false;
            adminAddUsers1.Visible = false;
            adminAddProducts1.Visible = false;
            userCustomersForm1.Visible = true;
            userAuctionSystem1.Visible = false;

            UserCustomersForm ccForm = userCustomersForm1 as UserCustomersForm;

            if (ccForm != null)
            {
                ccForm.refreshData();
            }
        }

        private void adminDashboardForm1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            adminDashboardForm1.Visible = false;
            adminAddUsers1.Visible = false;
            adminAddProducts1.Visible = false;
            userCustomersForm1.Visible = false;

            userAuctionSystem1.Visible = true;

            
            userAuctionSystem1.SetRole("Admin");
        }
    }
}