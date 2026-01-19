using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace ThriftShopManagementSystem
{
    public partial class UserAuctionSystem : UserControl
    {

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\saman\Documents\thrift.mdf;Integrated Security=True;Connect Timeout=30");
        public UserAuctionSystem()
        {
            InitializeComponent();
            LoadAuctions();
            ApplyRolePermissions();

            SetRole("User");

            if (Form1.LoggedInRole == "Admin")
            {
                btnAdminAddAuction.Visible = true;
                btnAdminDeleteAuction.Visible = true;
            }
            else
            {
                btnAdminAddAuction.Visible = false;
                btnAdminDeleteAuction.Visible = false;
            }

        }

        private void ApplyRolePermissions()
        {
            bool isUser = Session.Role == "User";

            lblBidAmount.Visible = isUser;
            txtBidAmount.Visible = isUser;
            btnPlaceBid.Visible = isUser;
            
            txtBidAmount.Visible = isUser;
            btnPlaceBid.Visible = isUser;

        }


        public void SetRole(string role)
        {
            bool isAdmin = role == "Admin";

            
            
            lblProductName.Visible = isAdmin;
            lblStartPrice.Visible = isAdmin;
            lblEndTime.Visible = isAdmin;

           
            
            txtProdName.Visible = isAdmin;
            txtStartPrice.Visible = isAdmin;
            dtEndTime.Visible = isAdmin;

            
            btnAdminAddAuction.Visible = isAdmin;
            btnAdminDeleteAuction.Visible = isAdmin;
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void LoadAuctions()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connect.ConnectionString))
                {
                    string query = @"
                SELECT 
                    id AS AuctionID,
                    prod_name AS Product,
                    current_bid AS CurrentBid,
                    highest_bidder AS HighestBidder,
                    end_time AS EndsAt
                FROM auctions
                WHERE status = 'Active'
                 ORDER BY current_bid DESC
            ";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    auctionGrid.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load auctions: " + ex.Message);
            }
        }

        private void btnPlaceBid_Click(object sender, EventArgs e)
        {
            if (auctionGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select an auction first.");
                return;
            }

            if (!double.TryParse(txtBidAmount.Text, out double bidAmount))
            {
                MessageBox.Show("Invalid bid amount.");
                return;
            }

            int auctionId = Convert.ToInt32(
                auctionGrid.SelectedRows[0].Cells["AuctionID"].Value
            );

            try
            {
                using (SqlConnection con = new SqlConnection(connect.ConnectionString))
                {
                    con.Open();

                    
                    string getPrice = "SELECT current_bid FROM auctions WHERE id = @id";
                    double currentPrice;

                    using (SqlCommand cmd = new SqlCommand(getPrice, con))
                    {
                        cmd.Parameters.AddWithValue("@id", auctionId);
                        currentPrice = Convert.ToDouble(cmd.ExecuteScalar());
                    }

                    if (bidAmount <= currentPrice)
                    {
                        MessageBox.Show("Bid must be higher than current bid.");
                        return;
                    }

                    
                    string insertBid = @"
                INSERT INTO bids (auction_id, bidder_username, bid_amount, bid_time)
                VALUES (@auctionId, @username, @amount, GETDATE())
            ";

                    using (SqlCommand cmd = new SqlCommand(insertBid, con))
                    {
                        cmd.Parameters.AddWithValue("@auctionId", auctionId);
                        cmd.Parameters.AddWithValue("@username", Session.Username);
                        cmd.Parameters.AddWithValue("@amount", bidAmount);
                        cmd.ExecuteNonQuery();
                    }

                    
                    string updateAuction = @"
                UPDATE auctions
                SET current_bid = @amount,
                    highest_bidder = @username
                WHERE id = @auctionId
            ";

                    using (SqlCommand cmd = new SqlCommand(updateAuction, con))
                    {
                        cmd.Parameters.AddWithValue("@amount", bidAmount);
                        cmd.Parameters.AddWithValue("@username", Session.Username);
                        cmd.Parameters.AddWithValue("@auctionId", auctionId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Bid placed successfully!");
                LoadAuctions();
                txtBidAmount.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bid failed: " + ex.Message);
            }
        }

        

     
        private void auctionTimer(object sender, EventArgs e)
        {
            if (auctionGrid.SelectedRows.Count == 0)
            {
                Countdown.Text = "--:--:--";
                Countdown.ForeColor = Color.Black;
                return;
            }

            DateTime endTime = Convert.ToDateTime(
                auctionGrid.SelectedRows[0].Cells["EndsAt"].Value
            );

            TimeSpan remaining = endTime - DateTime.Now;

            if (remaining.TotalSeconds <= 0)
            {
                Countdown.Text = "ENDED";
                Countdown.ForeColor = Color.Red;
                btnPlaceBid.Enabled = false;
            }
            else
            {
                Countdown.Text = remaining.ToString(@"hh\:mm\:ss");
                Countdown.ForeColor =
                    remaining.TotalSeconds <= 10 ? Color.Red : Color.Black;
                btnPlaceBid.Enabled = true;
            }
        }

        private void btnAdminAddAuction_Click(object sender, EventArgs e)
        {
            if (Form1.LoggedInRole != "Admin")
            {
                MessageBox.Show("Unauthorized action.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connect.ConnectionString))
            {
                con.Open();

                string insert = @"
            INSERT INTO auctions
            (prod_name, start_price, current_bid, start_time, end_time, status)
            VALUES
            (@pname, @price, @price, GETDATE(), @end, 'Active')
        ";

                using (SqlCommand cmd = new SqlCommand(insert, con))
                {
                    
                    cmd.Parameters.AddWithValue("@pname", txtProdName.Text);
                    cmd.Parameters.AddWithValue("@price", txtStartPrice.Text);
                    cmd.Parameters.AddWithValue("@end", dtEndTime.Value);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Auction added.");
            LoadAuctions();
        }

        private void btnAdminDeleteAuction_Click(object sender, EventArgs e)
        {
            if (Form1.LoggedInRole != "Admin")
            {
                MessageBox.Show("Unauthorized action.");
                return;
            }

            if (auctionGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select an auction first.");
                return;
            }

            int auctionId = Convert.ToInt32(
                auctionGrid.SelectedRows[0].Cells["AuctionID"].Value
            );

            DialogResult result = MessageBox.Show(
                "Delete selected auction?",
                "Confirm",
                MessageBoxButtons.YesNo
            );

            if (result != DialogResult.Yes) return;

            using (SqlConnection con = new SqlConnection(connect.ConnectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(
                    "DELETE FROM auctions WHERE id = @id", con))
                {
                    cmd.Parameters.AddWithValue("@id", auctionId);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Auction deleted.");
            LoadAuctions(); //
        }
    }
}
