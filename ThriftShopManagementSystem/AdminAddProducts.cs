using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;

namespace ThriftShopManagementSystem
{
    public partial class AdminAddProducts : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\saman\Documents\thrift.mdf;Integrated Security=True;Connect Timeout=30");
        public AdminAddProducts()
        {
            InitializeComponent();

            displayData();
            displayAddProductsData();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayData();
        }
        public bool emptyFields()
        {
            if (adminAddProducts_id.Text == "" || adminAddProducts_name.Text == ""
                || adminAddProducts_type.SelectedIndex == -1 || adminAddProducts_stock.Text == ""
                || adminAddProducts_price.Text == "" || adminAddProducts_status.SelectedIndex == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void displayData()
        {
            AdminAddProductsData prodData = new AdminAddProductsData();
            List<AdminAddProductsData> listData = prodData.productsListData();

            dataGridView1.DataSource = listData;
        }

        private void adminAddProducts_addBtn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("All fields are required to be filled.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    string selectProdID = "SELECT * FROM products WHERE prod_id = @prodID";

                    using (SqlCommand selectPID = new SqlCommand(selectProdID, connect))
                    {
                        selectPID.Parameters.AddWithValue("@prodID", adminAddProducts_id.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(selectPID);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count >= 1)
                        {
                            MessageBox.Show("Product ID: " + adminAddProducts_id.Text.Trim() + " is taken already", "Error Message"
                               , MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertData = "INSERT INTO products (prod_id, prod_name, prod_type, " +
                                "prod_stock, prod_price, prod_status, prod_image, date_insert) VALUES(@prodID, @prodName" +
                                ", @prodType, @prodStock, @prodPrice, @prodStatus, @prodImage, @dateInsert)";

                            DateTime today = DateTime.Today;

                            string path = Path.Combine(@"G:\Obsidian\aiub_cse_7th_samester\OBJECT_ORIENTED_PROGRAMMING_2_JJ\ThriftShopManagementSystem\ThriftShopManagementSystem\Product_Directory\" + adminAddProducts_id.Text.Trim() + ".jpg");

                            string directoryPath = Path.GetDirectoryName(path);

                            if (!Directory.Exists(directoryPath))
                            {
                                Directory.CreateDirectory(directoryPath);
                            }

                            File.Copy(adminAddProducts_imageView.ImageLocation, path, true);

                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@prodID", adminAddProducts_id.Text.Trim());
                                cmd.Parameters.AddWithValue("@prodName", adminAddProducts_name.Text.Trim());
                                cmd.Parameters.AddWithValue("@prodType", adminAddProducts_type.Text.Trim());
                                cmd.Parameters.AddWithValue("@prodStock", adminAddProducts_stock.Text.Trim());
                                cmd.Parameters.AddWithValue("@prodPrice", adminAddProducts_price.Text.Trim());
                                cmd.Parameters.AddWithValue("@prodStatus", adminAddProducts_status.Text.Trim());
                                cmd.Parameters.AddWithValue("@prodImage", path);
                                cmd.Parameters.AddWithValue("@dateInsert", today);

                                cmd.ExecuteNonQuery();
                                displayAddProductsData();

                                clearFields();

                                MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed connection: " + ex, "Error Message"
                                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void adminAddProducts_importBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png";
                string imagePath = "";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    adminAddProducts_imageView.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void clearFields()
        {
            adminAddProducts_id.Text = "";
            adminAddProducts_name.Text = "";
            adminAddProducts_type.SelectedIndex = -1;
            adminAddProducts_stock.Text = "";
            adminAddProducts_price.Text = "";
            adminAddProducts_status.SelectedIndex = -1;
            adminAddProducts_imageView.Image = null;
        }

        private void adminAddProducts_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                adminAddProducts_id.Text = row.Cells[1].Value.ToString();
                adminAddProducts_name.Text = row.Cells[2].Value.ToString();
                adminAddProducts_type.Text = row.Cells[3].Value.ToString();
                adminAddProducts_stock.Text = row.Cells[4].Value.ToString();
                adminAddProducts_price.Text = row.Cells[5].Value.ToString();
                adminAddProducts_status.Text = row.Cells[6].Value.ToString();

                string imagepath = row.Cells[7].Value.ToString();

                try
                {
                    if (imagepath != null)
                    {
                        adminAddProducts_imageView.Image = Image.FromFile(imagepath);
                    }
                    else
                    {
                        adminAddProducts_imageView.Image = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Image: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

       

        private void adminAddProducts_updateBtn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("All fields are required to be filled.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to Update Product ID: " + adminAddProducts_id.Text.Trim() + "?"
                    , "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (check == DialogResult.Yes)
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        try
                        {
                            connect.Open();

                            string updateData = "UPDATE products SET prod_name = @prodName" +
                                ", prod_type = @prodType, prod_stock = @prodStock, prod_price = @prodPrice, prod_status = @prodStatus" +
                                ", date_update = @dateUpdate WHERE prod_id = @prodID";
                            DateTime today = DateTime.Today;

                            using (SqlCommand updateD = new SqlCommand(updateData, connect))
                            {
                                updateD.Parameters.AddWithValue("@prodName", adminAddProducts_name.Text.Trim());
                                updateD.Parameters.AddWithValue("@prodType", adminAddProducts_type.Text.Trim());
                                updateD.Parameters.AddWithValue("@prodStock", adminAddProducts_stock.Text.Trim());
                                updateD.Parameters.AddWithValue("@prodPrice", adminAddProducts_price.Text.Trim());
                                updateD.Parameters.AddWithValue("@prodStatus", adminAddProducts_status.Text.Trim());
                                updateD.Parameters.AddWithValue("@dateUpdate", today);
                                updateD.Parameters.AddWithValue("@prodID", adminAddProducts_id.Text.Trim());

                                updateD.ExecuteNonQuery();
                                clearFields();

                                MessageBox.Show("Updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                displayData();

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
            }
        }

        private void adminAddProducts_deleteBtn_Click(object sender, EventArgs e)
        {
            if (adminAddProducts_id.Text == "")
            {
                MessageBox.Show(
                    "Please select a product to delete.",
                    "Error Message",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete Product ID: " + adminAddProducts_id.Text + "?",
                "Confirmation Message",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result != DialogResult.Yes)
                return;

            try
            {
                if (connect.State != ConnectionState.Closed)
                    connect.Close();

                connect.Open();

                string deleteQuery = "DELETE FROM products WHERE prod_id = @prodID";

                using (SqlCommand cmd = new SqlCommand(deleteQuery, connect))
                {
                    cmd.Parameters.AddWithValue(
                        "@prodID",
                        adminAddProducts_id.Text.Trim()
                    );

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(
                    "Product deleted successfully!",
                    "Information Message",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                clearFields();
                displayAddProductsData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Delete failed: " + ex.Message,
                    "Error Message",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                connect.Close();
            }
        }

        public void displayAddProductsData()
        {
            if (connect.State != ConnectionState.Closed)
                connect.Close();

            try
            {
                connect.Open();

                string query = "SELECT * FROM products";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridView1.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load products: " + ex.Message,
                    "Error Message",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                connect.Close();
            }
        }

        private void adminAddProducts_refreshBtn_Click(object sender, EventArgs e)
        {
            displayAddProductsData();
        }

        private void adminAddProducts_stock_TextChanged(object sender, EventArgs e)
        {

        }
    }
}