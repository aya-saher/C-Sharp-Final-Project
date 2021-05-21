namespace SchoolLibraryStockManagement
{
    partial class OrderForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tBProductCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnProductSearch = new System.Windows.Forms.Button();
            this.btnAllOrders = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.btnAddOrderItem = new System.Windows.Forms.Button();
            this.tBQuantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cBSearch = new System.Windows.Forms.ComboBox();
            this.dGVOrderItems = new System.Windows.Forms.DataGridView();
            this.dGVProducts = new System.Windows.Forms.DataGridView();
            this.bClearProducts = new System.Windows.Forms.Button();
            this.tBSearch = new System.Windows.Forms.TextBox();
            this.btnDeleteOrderItem = new System.Windows.Forms.Button();
            this.btnEditOrderItem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dGVOrderItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVProducts)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tBProductCode
            // 
            this.tBProductCode.Enabled = false;
            this.tBProductCode.Location = new System.Drawing.Point(114, 153);
            this.tBProductCode.Name = "tBProductCode";
            this.tBProductCode.Size = new System.Drawing.Size(100, 20);
            this.tBProductCode.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Product Code";
            // 
            // btnProductSearch
            // 
            this.btnProductSearch.BackColor = System.Drawing.Color.White;
            this.btnProductSearch.FlatAppearance.BorderSize = 0;
            this.btnProductSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductSearch.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductSearch.Location = new System.Drawing.Point(880, 115);
            this.btnProductSearch.Name = "btnProductSearch";
            this.btnProductSearch.Size = new System.Drawing.Size(104, 21);
            this.btnProductSearch.TabIndex = 34;
            this.btnProductSearch.Text = "Search";
            this.btnProductSearch.UseVisualStyleBackColor = false;
            this.btnProductSearch.Click += new System.EventHandler(this.btnProductSearch_Click);
            // 
            // btnAllOrders
            // 
            this.btnAllOrders.BackColor = System.Drawing.Color.White;
            this.btnAllOrders.FlatAppearance.BorderSize = 0;
            this.btnAllOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllOrders.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllOrders.Location = new System.Drawing.Point(26, 525);
            this.btnAllOrders.Name = "btnAllOrders";
            this.btnAllOrders.Size = new System.Drawing.Size(188, 23);
            this.btnAllOrders.TabIndex = 33;
            this.btnAllOrders.Text = "View All Orders";
            this.btnAllOrders.UseVisualStyleBackColor = false;
            this.btnAllOrders.Click += new System.EventHandler(this.btnAllOrders_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.BackColor = System.Drawing.Color.White;
            this.btnAddOrder.Enabled = false;
            this.btnAddOrder.FlatAppearance.BorderSize = 0;
            this.btnAddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOrder.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrder.Location = new System.Drawing.Point(25, 467);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(189, 23);
            this.btnAddOrder.TabIndex = 31;
            this.btnAddOrder.Text = "Add Order";
            this.btnAddOrder.UseVisualStyleBackColor = false;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.BackColor = System.Drawing.Color.White;
            this.btnDeleteOrder.Enabled = false;
            this.btnDeleteOrder.FlatAppearance.BorderSize = 0;
            this.btnDeleteOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteOrder.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteOrder.Location = new System.Drawing.Point(25, 496);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(189, 23);
            this.btnDeleteOrder.TabIndex = 30;
            this.btnDeleteOrder.Text = "Delete Order";
            this.btnDeleteOrder.UseVisualStyleBackColor = false;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // btnAddOrderItem
            // 
            this.btnAddOrderItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.btnAddOrderItem.Enabled = false;
            this.btnAddOrderItem.FlatAppearance.BorderSize = 0;
            this.btnAddOrderItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOrderItem.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrderItem.ForeColor = System.Drawing.Color.Snow;
            this.btnAddOrderItem.Location = new System.Drawing.Point(25, 228);
            this.btnAddOrderItem.Name = "btnAddOrderItem";
            this.btnAddOrderItem.Size = new System.Drawing.Size(189, 23);
            this.btnAddOrderItem.TabIndex = 25;
            this.btnAddOrderItem.Text = "Add To Order";
            this.btnAddOrderItem.UseVisualStyleBackColor = false;
            this.btnAddOrderItem.Click += new System.EventHandler(this.btnAddOrderItem_Click);
            // 
            // tBQuantity
            // 
            this.tBQuantity.Location = new System.Drawing.Point(114, 185);
            this.tBQuantity.MaxLength = 6;
            this.tBQuantity.Name = "tBQuantity";
            this.tBQuantity.Size = new System.Drawing.Size(100, 20);
            this.tBQuantity.TabIndex = 24;
            this.tBQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBQuantity_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Quantity";
            // 
            // cBSearch
            // 
            this.cBSearch.FormattingEnabled = true;
            this.cBSearch.Location = new System.Drawing.Point(604, 115);
            this.cBSearch.Name = "cBSearch";
            this.cBSearch.Size = new System.Drawing.Size(117, 21);
            this.cBSearch.TabIndex = 22;
            // 
            // dGVOrderItems
            // 
            this.dGVOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVOrderItems.Location = new System.Drawing.Point(241, 398);
            this.dGVOrderItems.Name = "dGVOrderItems";
            this.dGVOrderItems.Size = new System.Drawing.Size(743, 225);
            this.dGVOrderItems.TabIndex = 21;
            this.dGVOrderItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVOrderItems_CellClick);
            // 
            // dGVProducts
            // 
            this.dGVProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVProducts.Location = new System.Drawing.Point(241, 153);
            this.dGVProducts.Name = "dGVProducts";
            this.dGVProducts.Size = new System.Drawing.Size(743, 220);
            this.dGVProducts.TabIndex = 20;
            this.dGVProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVProducts_CellClick);
            // 
            // bClearProducts
            // 
            this.bClearProducts.BackColor = System.Drawing.Color.White;
            this.bClearProducts.FlatAppearance.BorderSize = 0;
            this.bClearProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bClearProducts.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClearProducts.Location = new System.Drawing.Point(25, 312);
            this.bClearProducts.Name = "bClearProducts";
            this.bClearProducts.Size = new System.Drawing.Size(189, 23);
            this.bClearProducts.TabIndex = 38;
            this.bClearProducts.Text = "Clear";
            this.bClearProducts.UseVisualStyleBackColor = false;
            this.bClearProducts.Click += new System.EventHandler(this.bClearProducts_Click);
            // 
            // tBSearch
            // 
            this.tBSearch.Location = new System.Drawing.Point(738, 115);
            this.tBSearch.Name = "tBSearch";
            this.tBSearch.Size = new System.Drawing.Size(111, 20);
            this.tBSearch.TabIndex = 39;
            // 
            // btnDeleteOrderItem
            // 
            this.btnDeleteOrderItem.BackColor = System.Drawing.Color.White;
            this.btnDeleteOrderItem.Enabled = false;
            this.btnDeleteOrderItem.FlatAppearance.BorderSize = 0;
            this.btnDeleteOrderItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteOrderItem.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteOrderItem.Location = new System.Drawing.Point(25, 257);
            this.btnDeleteOrderItem.Name = "btnDeleteOrderItem";
            this.btnDeleteOrderItem.Size = new System.Drawing.Size(189, 23);
            this.btnDeleteOrderItem.TabIndex = 40;
            this.btnDeleteOrderItem.Text = "Delete From Order";
            this.btnDeleteOrderItem.UseVisualStyleBackColor = false;
            this.btnDeleteOrderItem.Click += new System.EventHandler(this.btnDeleteOrderItem_Click);
            // 
            // btnEditOrderItem
            // 
            this.btnEditOrderItem.BackColor = System.Drawing.Color.White;
            this.btnEditOrderItem.Enabled = false;
            this.btnEditOrderItem.FlatAppearance.BorderSize = 0;
            this.btnEditOrderItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditOrderItem.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditOrderItem.Location = new System.Drawing.Point(25, 283);
            this.btnEditOrderItem.Name = "btnEditOrderItem";
            this.btnEditOrderItem.Size = new System.Drawing.Size(189, 23);
            this.btnEditOrderItem.TabIndex = 41;
            this.btnEditOrderItem.Text = "Edit";
            this.btnEditOrderItem.UseVisualStyleBackColor = false;
            this.btnEditOrderItem.Click += new System.EventHandler(this.btnEditOrderItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(9, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "ORDERS MANAGEMENT";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(187)))), ((int)(((byte)(173)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(27, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 68);
            this.panel1.TabIndex = 42;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 664);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEditOrderItem);
            this.Controls.Add(this.btnDeleteOrderItem);
            this.Controls.Add(this.tBSearch);
            this.Controls.Add(this.bClearProducts);
            this.Controls.Add(this.tBProductCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnProductSearch);
            this.Controls.Add(this.btnAllOrders);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.btnAddOrderItem);
            this.Controls.Add(this.tBQuantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBSearch);
            this.Controls.Add(this.dGVOrderItems);
            this.Controls.Add(this.dGVProducts);
            this.Name = "OrderForm";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVOrderItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVProducts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBProductCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnProductSearch;
        private System.Windows.Forms.Button btnAllOrders;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Button btnAddOrderItem;
        private System.Windows.Forms.TextBox tBQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBSearch;
        private System.Windows.Forms.DataGridView dGVOrderItems;
        private System.Windows.Forms.DataGridView dGVProducts;
        private System.Windows.Forms.Button bClearProducts;
        private System.Windows.Forms.TextBox tBSearch;
        private System.Windows.Forms.Button btnDeleteOrderItem;
        private System.Windows.Forms.Button btnEditOrderItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}