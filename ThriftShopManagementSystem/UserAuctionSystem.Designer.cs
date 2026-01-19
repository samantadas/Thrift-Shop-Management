namespace ThriftShopManagementSystem
{
    partial class UserAuctionSystem
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnPlaceBid = new System.Windows.Forms.Button();
            this.txtBidAmount = new System.Windows.Forms.TextBox();
            this.lblBidAmount = new System.Windows.Forms.Label();
            this.auctionGrid = new System.Windows.Forms.DataGridView();
            this.lblCountdown = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Countdown = new System.Windows.Forms.Label();
            this.btnAdminDeleteAuction = new System.Windows.Forms.Button();
            this.btnAdminAddAuction = new System.Windows.Forms.Button();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.txtStartPrice = new System.Windows.Forms.TextBox();
            this.dtEndTime = new System.Windows.Forms.DateTimePicker();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblStartPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.auctionGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlaceBid
            // 
            this.btnPlaceBid.BackColor = System.Drawing.Color.IndianRed;
            this.btnPlaceBid.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceBid.Location = new System.Drawing.Point(547, 458);
            this.btnPlaceBid.Name = "btnPlaceBid";
            this.btnPlaceBid.Size = new System.Drawing.Size(105, 43);
            this.btnPlaceBid.TabIndex = 31;
            this.btnPlaceBid.Text = "Place Bid";
            this.btnPlaceBid.UseVisualStyleBackColor = false;
            this.btnPlaceBid.Click += new System.EventHandler(this.btnPlaceBid_Click);
            // 
            // txtBidAmount
            // 
            this.txtBidAmount.Location = new System.Drawing.Point(547, 422);
            this.txtBidAmount.Name = "txtBidAmount";
            this.txtBidAmount.Size = new System.Drawing.Size(105, 20);
            this.txtBidAmount.TabIndex = 32;
            // 
            // lblBidAmount
            // 
            this.lblBidAmount.AutoSize = true;
            this.lblBidAmount.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBidAmount.Location = new System.Drawing.Point(542, 389);
            this.lblBidAmount.Name = "lblBidAmount";
            this.lblBidAmount.Size = new System.Drawing.Size(127, 26);
            this.lblBidAmount.TabIndex = 33;
            this.lblBidAmount.Text = "Bid Amount";
            this.lblBidAmount.Click += new System.EventHandler(this.label1_Click);
            // 
            // auctionGrid
            // 
            this.auctionGrid.AllowUserToAddRows = false;
            this.auctionGrid.AllowUserToDeleteRows = false;
            this.auctionGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.auctionGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.auctionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.auctionGrid.Location = new System.Drawing.Point(15, 12);
            this.auctionGrid.Name = "auctionGrid";
            this.auctionGrid.ReadOnly = true;
            this.auctionGrid.Size = new System.Drawing.Size(1217, 320);
            this.auctionGrid.TabIndex = 34;
            // 
            // lblCountdown
            // 
            this.lblCountdown.AutoSize = true;
            this.lblCountdown.Location = new System.Drawing.Point(146, 371);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(0, 13);
            this.lblCountdown.TabIndex = 35;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.auctionTimer);
            // 
            // Countdown
            // 
            this.Countdown.AutoSize = true;
            this.Countdown.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Countdown.Location = new System.Drawing.Point(506, 335);
            this.Countdown.Name = "Countdown";
            this.Countdown.Size = new System.Drawing.Size(206, 45);
            this.Countdown.TabIndex = 36;
            this.Countdown.Text = "00:00:00";
            // 
            // btnAdminDeleteAuction
            // 
            this.btnAdminDeleteAuction.BackColor = System.Drawing.Color.IndianRed;
            this.btnAdminDeleteAuction.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminDeleteAuction.Location = new System.Drawing.Point(229, 484);
            this.btnAdminDeleteAuction.Name = "btnAdminDeleteAuction";
            this.btnAdminDeleteAuction.Size = new System.Drawing.Size(170, 43);
            this.btnAdminDeleteAuction.TabIndex = 37;
            this.btnAdminDeleteAuction.Text = "DELETE AUCTION";
            this.btnAdminDeleteAuction.UseVisualStyleBackColor = false;
            this.btnAdminDeleteAuction.Visible = false;
            this.btnAdminDeleteAuction.Click += new System.EventHandler(this.btnAdminDeleteAuction_Click);
            // 
            // btnAdminAddAuction
            // 
            this.btnAdminAddAuction.BackColor = System.Drawing.Color.IndianRed;
            this.btnAdminAddAuction.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminAddAuction.Location = new System.Drawing.Point(46, 484);
            this.btnAdminAddAuction.Name = "btnAdminAddAuction";
            this.btnAdminAddAuction.Size = new System.Drawing.Size(159, 43);
            this.btnAdminAddAuction.TabIndex = 38;
            this.btnAdminAddAuction.Text = "ADD AUCTION";
            this.btnAdminAddAuction.UseVisualStyleBackColor = false;
            this.btnAdminAddAuction.Visible = false;
            this.btnAdminAddAuction.Click += new System.EventHandler(this.btnAdminAddAuction_Click);
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(178, 371);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(274, 20);
            this.txtProdName.TabIndex = 41;
            this.txtProdName.Visible = false;
            // 
            // txtStartPrice
            // 
            this.txtStartPrice.Location = new System.Drawing.Point(178, 408);
            this.txtStartPrice.Name = "txtStartPrice";
            this.txtStartPrice.Size = new System.Drawing.Size(131, 20);
            this.txtStartPrice.TabIndex = 43;
            this.txtStartPrice.Visible = false;
            // 
            // dtEndTime
            // 
            this.dtEndTime.Location = new System.Drawing.Point(178, 443);
            this.dtEndTime.Name = "dtEndTime";
            this.dtEndTime.Size = new System.Drawing.Size(200, 20);
            this.dtEndTime.TabIndex = 45;
            this.dtEndTime.Visible = false;
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndTime.Location = new System.Drawing.Point(73, 441);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(85, 22);
            this.lblEndTime.TabIndex = 46;
            this.lblEndTime.Text = "End Time";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(44, 371);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(128, 22);
            this.lblProductName.TabIndex = 42;
            this.lblProductName.Text = "Product Name";
            // 
            // lblStartPrice
            // 
            this.lblStartPrice.AutoSize = true;
            this.lblStartPrice.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartPrice.Location = new System.Drawing.Point(56, 405);
            this.lblStartPrice.Name = "lblStartPrice";
            this.lblStartPrice.Size = new System.Drawing.Size(95, 22);
            this.lblStartPrice.TabIndex = 44;
            this.lblStartPrice.Text = "Start Price";
            // 
            // UserAuctionSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtProdName);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.Countdown);
            this.Controls.Add(this.txtStartPrice);
            this.Controls.Add(this.btnAdminDeleteAuction);
            this.Controls.Add(this.lblStartPrice);
            this.Controls.Add(this.lblCountdown);
            this.Controls.Add(this.dtEndTime);
            this.Controls.Add(this.auctionGrid);
            this.Controls.Add(this.btnAdminAddAuction);
            this.Controls.Add(this.lblBidAmount);
            this.Controls.Add(this.txtBidAmount);
            this.Controls.Add(this.btnPlaceBid);
            this.Name = "UserAuctionSystem";
            this.Size = new System.Drawing.Size(1251, 745);
            ((System.ComponentModel.ISupportInitialize)(this.auctionGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlaceBid;
        private System.Windows.Forms.TextBox txtBidAmount;
        private System.Windows.Forms.Label lblBidAmount;
        private System.Windows.Forms.DataGridView auctionGrid;
        private System.Windows.Forms.Label lblCountdown;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Countdown;
        private System.Windows.Forms.Button btnAdminDeleteAuction;
        private System.Windows.Forms.Button btnAdminAddAuction;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.TextBox txtStartPrice;
        private System.Windows.Forms.DateTimePicker dtEndTime;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblStartPrice;
    }
}
