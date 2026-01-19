namespace ThriftShopManagementSystem
{
    partial class UserOrderForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserOrderForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.userOrderForm_ItemTable = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sellerOrderForm_price = new System.Windows.Forms.Label();
            this.sellerOrderForm_prodName = new System.Windows.Forms.Label();
            this.sellerOrderForm_clearBtn = new System.Windows.Forms.Button();
            this.sellerOrderForm_removeBtn = new System.Windows.Forms.Button();
            this.sellerOrderForm_addBtn = new System.Windows.Forms.Button();
            this.cashierOrderForm_price = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sellerOrderForm_quantity = new System.Windows.Forms.NumericUpDown();
            this.cashierOrderForm_prodName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sellerOrderForm_productID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sellerOrderForm_type = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.sellerOrderForm_receiptBtn = new System.Windows.Forms.Button();
            this.sellerOrderForm_payBtn = new System.Windows.Forms.Button();
            this.sellerOrderForm_change = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.sellerOrderForm_amount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.sellerOrderForm_orderPrice = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.sellerOrderForm_orderTable = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userOrderForm_ItemTable)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellerOrderForm_quantity)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellerOrderForm_orderTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.userOrderForm_ItemTable);
            this.panel1.Location = new System.Drawing.Point(12, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 354);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Items";
            // 
            // userOrderForm_ItemTable
            // 
            this.userOrderForm_ItemTable.AllowUserToAddRows = false;
            this.userOrderForm_ItemTable.AllowUserToDeleteRows = false;
            this.userOrderForm_ItemTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userOrderForm_ItemTable.Location = new System.Drawing.Point(14, 49);
            this.userOrderForm_ItemTable.Name = "userOrderForm_ItemTable";
            this.userOrderForm_ItemTable.ReadOnly = true;
            this.userOrderForm_ItemTable.Size = new System.Drawing.Size(816, 290);
            this.userOrderForm_ItemTable.TabIndex = 0;
            this.userOrderForm_ItemTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userOrderForm_ItemTable_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.sellerOrderForm_price);
            this.panel2.Controls.Add(this.sellerOrderForm_prodName);
            this.panel2.Controls.Add(this.sellerOrderForm_clearBtn);
            this.panel2.Controls.Add(this.sellerOrderForm_removeBtn);
            this.panel2.Controls.Add(this.sellerOrderForm_addBtn);
            this.panel2.Controls.Add(this.cashierOrderForm_price);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.sellerOrderForm_quantity);
            this.panel2.Controls.Add(this.cashierOrderForm_prodName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.sellerOrderForm_productID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.sellerOrderForm_type);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(12, 384);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(845, 341);
            this.panel2.TabIndex = 1;
            // 
            // sellerOrderForm_price
            // 
            this.sellerOrderForm_price.AutoSize = true;
            this.sellerOrderForm_price.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellerOrderForm_price.Location = new System.Drawing.Point(159, 200);
            this.sellerOrderForm_price.Name = "sellerOrderForm_price";
            this.sellerOrderForm_price.Size = new System.Drawing.Size(35, 17);
            this.sellerOrderForm_price.TabIndex = 32;
            this.sellerOrderForm_price.Text = "100";
            // 
            // sellerOrderForm_prodName
            // 
            this.sellerOrderForm_prodName.AutoSize = true;
            this.sellerOrderForm_prodName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellerOrderForm_prodName.Location = new System.Drawing.Point(148, 143);
            this.sellerOrderForm_prodName.Name = "sellerOrderForm_prodName";
            this.sellerOrderForm_prodName.Size = new System.Drawing.Size(101, 17);
            this.sellerOrderForm_prodName.TabIndex = 31;
            this.sellerOrderForm_prodName.Text = "Test Product";
            // 
            // sellerOrderForm_clearBtn
            // 
            this.sellerOrderForm_clearBtn.BackColor = System.Drawing.Color.IndianRed;
            this.sellerOrderForm_clearBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellerOrderForm_clearBtn.Location = new System.Drawing.Point(515, 278);
            this.sellerOrderForm_clearBtn.Name = "sellerOrderForm_clearBtn";
            this.sellerOrderForm_clearBtn.Size = new System.Drawing.Size(105, 43);
            this.sellerOrderForm_clearBtn.TabIndex = 30;
            this.sellerOrderForm_clearBtn.Text = "CLEAR";
            this.sellerOrderForm_clearBtn.UseVisualStyleBackColor = false;
            this.sellerOrderForm_clearBtn.Click += new System.EventHandler(this.sellerOrderForm_clearBtn_Click);
            // 
            // sellerOrderForm_removeBtn
            // 
            this.sellerOrderForm_removeBtn.BackColor = System.Drawing.Color.IndianRed;
            this.sellerOrderForm_removeBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellerOrderForm_removeBtn.Location = new System.Drawing.Point(380, 278);
            this.sellerOrderForm_removeBtn.Name = "sellerOrderForm_removeBtn";
            this.sellerOrderForm_removeBtn.Size = new System.Drawing.Size(105, 43);
            this.sellerOrderForm_removeBtn.TabIndex = 29;
            this.sellerOrderForm_removeBtn.Text = "REMOVE";
            this.sellerOrderForm_removeBtn.UseVisualStyleBackColor = false;
            this.sellerOrderForm_removeBtn.Click += new System.EventHandler(this.sellerOrderForm_removeBtn_Click);
            // 
            // sellerOrderForm_addBtn
            // 
            this.sellerOrderForm_addBtn.BackColor = System.Drawing.Color.IndianRed;
            this.sellerOrderForm_addBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellerOrderForm_addBtn.Location = new System.Drawing.Point(246, 278);
            this.sellerOrderForm_addBtn.Name = "sellerOrderForm_addBtn";
            this.sellerOrderForm_addBtn.Size = new System.Drawing.Size(105, 43);
            this.sellerOrderForm_addBtn.TabIndex = 28;
            this.sellerOrderForm_addBtn.Text = "ADD";
            this.sellerOrderForm_addBtn.UseVisualStyleBackColor = false;
            this.sellerOrderForm_addBtn.Click += new System.EventHandler(this.sellerOrderForm_addBtn_Click);
            // 
            // cashierOrderForm_price
            // 
            this.cashierOrderForm_price.AutoSize = true;
            this.cashierOrderForm_price.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderForm_price.Location = new System.Drawing.Point(148, 200);
            this.cashierOrderForm_price.Name = "cashierOrderForm_price";
            this.cashierOrderForm_price.Size = new System.Drawing.Size(0, 17);
            this.cashierOrderForm_price.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(67, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Price (TK):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(451, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Quantity:";
            // 
            // sellerOrderForm_quantity
            // 
            this.sellerOrderForm_quantity.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellerOrderForm_quantity.Location = new System.Drawing.Point(531, 136);
            this.sellerOrderForm_quantity.Name = "sellerOrderForm_quantity";
            this.sellerOrderForm_quantity.Size = new System.Drawing.Size(212, 29);
            this.sellerOrderForm_quantity.TabIndex = 24;
            // 
            // cashierOrderForm_prodName
            // 
            this.cashierOrderForm_prodName.AutoSize = true;
            this.cashierOrderForm_prodName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderForm_prodName.Location = new System.Drawing.Point(148, 143);
            this.cashierOrderForm_prodName.Name = "cashierOrderForm_prodName";
            this.cashierOrderForm_prodName.Size = new System.Drawing.Size(0, 17);
            this.cashierOrderForm_prodName.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Product Name:";
            // 
            // sellerOrderForm_productID
            // 
            this.sellerOrderForm_productID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellerOrderForm_productID.FormattingEnabled = true;
            this.sellerOrderForm_productID.Location = new System.Drawing.Point(531, 48);
            this.sellerOrderForm_productID.Name = "sellerOrderForm_productID";
            this.sellerOrderForm_productID.Size = new System.Drawing.Size(212, 32);
            this.sellerOrderForm_productID.TabIndex = 19;
            this.sellerOrderForm_productID.SelectedIndexChanged += new System.EventHandler(this.sellerOrderForm_productID_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(434, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Product ID:";
            // 
            // sellerOrderForm_type
            // 
            this.sellerOrderForm_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellerOrderForm_type.FormattingEnabled = true;
            this.sellerOrderForm_type.Items.AddRange(new object[] {
            "accessories",
            "clothing"});
            this.sellerOrderForm_type.Location = new System.Drawing.Point(91, 48);
            this.sellerOrderForm_type.Name = "sellerOrderForm_type";
            this.sellerOrderForm_type.Size = new System.Drawing.Size(212, 32);
            this.sellerOrderForm_type.TabIndex = 17;
            this.sellerOrderForm_type.SelectedIndexChanged += new System.EventHandler(this.sellerOrderForm_type_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Type:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.sellerOrderForm_receiptBtn);
            this.panel3.Controls.Add(this.sellerOrderForm_payBtn);
            this.panel3.Controls.Add(this.sellerOrderForm_change);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.sellerOrderForm_amount);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.sellerOrderForm_orderPrice);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.sellerOrderForm_orderTable);
            this.panel3.Location = new System.Drawing.Point(874, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(358, 710);
            this.panel3.TabIndex = 2;
            // 
            // sellerOrderForm_receiptBtn
            // 
            this.sellerOrderForm_receiptBtn.BackColor = System.Drawing.Color.IndianRed;
            this.sellerOrderForm_receiptBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellerOrderForm_receiptBtn.Location = new System.Drawing.Point(64, 615);
            this.sellerOrderForm_receiptBtn.Name = "sellerOrderForm_receiptBtn";
            this.sellerOrderForm_receiptBtn.Size = new System.Drawing.Size(251, 43);
            this.sellerOrderForm_receiptBtn.TabIndex = 36;
            this.sellerOrderForm_receiptBtn.Text = "INVOICE";
            this.sellerOrderForm_receiptBtn.UseVisualStyleBackColor = false;
            this.sellerOrderForm_receiptBtn.Click += new System.EventHandler(this.sellerOrderForm_receiptBtn_Click);
            // 
            // sellerOrderForm_payBtn
            // 
            this.sellerOrderForm_payBtn.BackColor = System.Drawing.Color.IndianRed;
            this.sellerOrderForm_payBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellerOrderForm_payBtn.Location = new System.Drawing.Point(64, 556);
            this.sellerOrderForm_payBtn.Name = "sellerOrderForm_payBtn";
            this.sellerOrderForm_payBtn.Size = new System.Drawing.Size(251, 43);
            this.sellerOrderForm_payBtn.TabIndex = 35;
            this.sellerOrderForm_payBtn.Text = "Sell";
            this.sellerOrderForm_payBtn.UseVisualStyleBackColor = false;
            this.sellerOrderForm_payBtn.Click += new System.EventHandler(this.sellerOrderForm_payBtn_Click);
            // 
            // sellerOrderForm_change
            // 
            this.sellerOrderForm_change.AutoSize = true;
            this.sellerOrderForm_change.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellerOrderForm_change.Location = new System.Drawing.Point(184, 505);
            this.sellerOrderForm_change.Name = "sellerOrderForm_change";
            this.sellerOrderForm_change.Size = new System.Drawing.Size(17, 17);
            this.sellerOrderForm_change.TabIndex = 31;
            this.sellerOrderForm_change.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(86, 505);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 17);
            this.label13.TabIndex = 29;
            this.label13.Text = "Change (TK):";
            // 
            // sellerOrderForm_amount
            // 
            this.sellerOrderForm_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellerOrderForm_amount.Location = new System.Drawing.Point(187, 457);
            this.sellerOrderForm_amount.Name = "sellerOrderForm_amount";
            this.sellerOrderForm_amount.Size = new System.Drawing.Size(128, 26);
            this.sellerOrderForm_amount.TabIndex = 34;
            this.sellerOrderForm_amount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sellerOrderForm_amount_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(86, 462);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 17);
            this.label11.TabIndex = 33;
            this.label11.Text = "Amount (TK):";
            // 
            // sellerOrderForm_orderPrice
            // 
            this.sellerOrderForm_orderPrice.AutoSize = true;
            this.sellerOrderForm_orderPrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellerOrderForm_orderPrice.Location = new System.Drawing.Point(184, 421);
            this.sellerOrderForm_orderPrice.Name = "sellerOrderForm_orderPrice";
            this.sellerOrderForm_orderPrice.Size = new System.Drawing.Size(17, 17);
            this.sellerOrderForm_orderPrice.TabIndex = 32;
            this.sellerOrderForm_orderPrice.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(103, 421);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 17);
            this.label10.TabIndex = 30;
            this.label10.Text = "Price (TK):";
            // 
            // sellerOrderForm_orderTable
            // 
            this.sellerOrderForm_orderTable.AllowUserToAddRows = false;
            this.sellerOrderForm_orderTable.AllowUserToDeleteRows = false;
            this.sellerOrderForm_orderTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sellerOrderForm_orderTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.sellerOrderForm_orderTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.sellerOrderForm_orderTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sellerOrderForm_orderTable.EnableHeadersVisualStyles = false;
            this.sellerOrderForm_orderTable.Location = new System.Drawing.Point(14, 29);
            this.sellerOrderForm_orderTable.Name = "sellerOrderForm_orderTable";
            this.sellerOrderForm_orderTable.ReadOnly = true;
            this.sellerOrderForm_orderTable.RowHeadersVisible = false;
            this.sellerOrderForm_orderTable.Size = new System.Drawing.Size(327, 325);
            this.sellerOrderForm_orderTable.TabIndex = 5;
            this.sellerOrderForm_orderTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sellerOrderForm_orderTable_CellClick);
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // UserOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserOrderForm";
            this.Size = new System.Drawing.Size(1251, 745);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userOrderForm_ItemTable)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellerOrderForm_quantity)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellerOrderForm_orderTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView userOrderForm_ItemTable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView sellerOrderForm_orderTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cashierOrderForm_price;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown sellerOrderForm_quantity;
        private System.Windows.Forms.Label cashierOrderForm_prodName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox sellerOrderForm_productID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox sellerOrderForm_type;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button sellerOrderForm_addBtn;
        private System.Windows.Forms.Button sellerOrderForm_receiptBtn;
        private System.Windows.Forms.Button sellerOrderForm_payBtn;
        private System.Windows.Forms.Label sellerOrderForm_change;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox sellerOrderForm_amount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label sellerOrderForm_orderPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button sellerOrderForm_clearBtn;
        private System.Windows.Forms.Button sellerOrderForm_removeBtn;
        private System.Windows.Forms.Label sellerOrderForm_prodName;
        private System.Windows.Forms.Label sellerOrderForm_price;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}
