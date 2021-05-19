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
            ((System.ComponentModel.ISupportInitialize)(this.dGVOrderItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // tBProductCode
            // 
            this.tBProductCode.Enabled = false;
            this.tBProductCode.Location = new System.Drawing.Point(103, 60);
            this.tBProductCode.Name = "tBProductCode";
            this.tBProductCode.Size = new System.Drawing.Size(100, 20);
            this.tBProductCode.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Product Code";
            // 
            // btnProductSearch
            // 
            this.btnProductSearch.Location = new System.Drawing.Point(684, 21);
            this.btnProductSearch.Name = "btnProductSearch";
            this.btnProductSearch.Size = new System.Drawing.Size(100, 21);
            this.btnProductSearch.TabIndex = 34;
            this.btnProductSearch.Text = "Search";
            this.btnProductSearch.UseVisualStyleBackColor = true;
            this.btnProductSearch.Click += new System.EventHandler(this.btnProductSearch_Click);
            // 
            // btnAllOrders
            // 
            this.btnAllOrders.Location = new System.Drawing.Point(26, 433);
            this.btnAllOrders.Name = "btnAllOrders";
            this.btnAllOrders.Size = new System.Drawing.Size(188, 23);
            this.btnAllOrders.TabIndex = 33;
            this.btnAllOrders.Text = "View All Orders";
            this.btnAllOrders.UseVisualStyleBackColor = true;
            this.btnAllOrders.Click += new System.EventHandler(this.btnAllOrders_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Enabled = false;
            this.btnAddOrder.Location = new System.Drawing.Point(25, 375);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(189, 23);
            this.btnAddOrder.TabIndex = 31;
            this.btnAddOrder.Text = "Add Order";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Enabled = false;
            this.btnDeleteOrder.Location = new System.Drawing.Point(25, 404);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(189, 23);
            this.btnDeleteOrder.TabIndex = 30;
            this.btnDeleteOrder.Text = "Delete Order";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // btnAddOrderItem
            // 
            this.btnAddOrderItem.Enabled = false;
            this.btnAddOrderItem.Location = new System.Drawing.Point(25, 136);
            this.btnAddOrderItem.Name = "btnAddOrderItem";
            this.btnAddOrderItem.Size = new System.Drawing.Size(175, 23);
            this.btnAddOrderItem.TabIndex = 25;
            this.btnAddOrderItem.Text = "Add To Order";
            this.btnAddOrderItem.UseVisualStyleBackColor = true;
            this.btnAddOrderItem.Click += new System.EventHandler(this.btnAddOrderItem_Click);
            // 
            // tBQuantity
            // 
            this.tBQuantity.Location = new System.Drawing.Point(103, 92);
            this.tBQuantity.MaxLength = 6;
            this.tBQuantity.Name = "tBQuantity";
            this.tBQuantity.Size = new System.Drawing.Size(100, 20);
            this.tBQuantity.TabIndex = 24;
            this.tBQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBQuantity_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Quantity";
            // 
            // cBSearch
            // 
            this.cBSearch.FormattingEnabled = true;
            this.cBSearch.Location = new System.Drawing.Point(477, 21);
            this.cBSearch.Name = "cBSearch";
            this.cBSearch.Size = new System.Drawing.Size(95, 21);
            this.cBSearch.TabIndex = 22;
            // 
            // dGVOrderItems
            // 
            this.dGVOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVOrderItems.Location = new System.Drawing.Point(241, 306);
            this.dGVOrderItems.Name = "dGVOrderItems";
            this.dGVOrderItems.Size = new System.Drawing.Size(555, 225);
            this.dGVOrderItems.TabIndex = 21;
            this.dGVOrderItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVOrderItems_CellClick);
            // 
            // dGVProducts
            // 
            this.dGVProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVProducts.Location = new System.Drawing.Point(241, 48);
            this.dGVProducts.Name = "dGVProducts";
            this.dGVProducts.Size = new System.Drawing.Size(743, 220);
            this.dGVProducts.TabIndex = 20;
            this.dGVProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVProducts_CellClick);
            // 
            // bClearProducts
            // 
            this.bClearProducts.Location = new System.Drawing.Point(25, 216);
            this.bClearProducts.Name = "bClearProducts";
            this.bClearProducts.Size = new System.Drawing.Size(175, 23);
            this.bClearProducts.TabIndex = 38;
            this.bClearProducts.Text = "Clear";
            this.bClearProducts.UseVisualStyleBackColor = true;
            this.bClearProducts.Click += new System.EventHandler(this.bClearProducts_Click);
            // 
            // tBSearch
            // 
            this.tBSearch.Location = new System.Drawing.Point(578, 21);
            this.tBSearch.Name = "tBSearch";
            this.tBSearch.Size = new System.Drawing.Size(100, 20);
            this.tBSearch.TabIndex = 39;
            // 
            // btnDeleteOrderItem
            // 
            this.btnDeleteOrderItem.Enabled = false;
            this.btnDeleteOrderItem.Location = new System.Drawing.Point(25, 162);
            this.btnDeleteOrderItem.Name = "btnDeleteOrderItem";
            this.btnDeleteOrderItem.Size = new System.Drawing.Size(175, 23);
            this.btnDeleteOrderItem.TabIndex = 40;
            this.btnDeleteOrderItem.Text = "Delete From Order";
            this.btnDeleteOrderItem.UseVisualStyleBackColor = true;
            this.btnDeleteOrderItem.Click += new System.EventHandler(this.btnDeleteOrderItem_Click);
            // 
            // btnEditOrderItem
            // 
            this.btnEditOrderItem.Enabled = false;
            this.btnEditOrderItem.Location = new System.Drawing.Point(25, 188);
            this.btnEditOrderItem.Name = "btnEditOrderItem";
            this.btnEditOrderItem.Size = new System.Drawing.Size(175, 23);
            this.btnEditOrderItem.TabIndex = 41;
            this.btnEditOrderItem.Text = "Edit";
            this.btnEditOrderItem.UseVisualStyleBackColor = true;
            this.btnEditOrderItem.Click += new System.EventHandler(this.btnEditOrderItem_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 540);
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
    }
}