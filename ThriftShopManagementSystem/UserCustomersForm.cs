using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeShopManagementSystem;

namespace ThriftShopManagementSystem
{
    public partial class UserCustomersForm : UserControl
    {
        public UserCustomersForm()
        {
            InitializeComponent();
            displayCustomersData();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayCustomersData();
        }
        public void displayCustomersData()
        {
            CustomersData cData = new CustomersData();

            List<CustomersData> listData = cData.allCustomersData();

            datagridview1.DataSource = listData;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
