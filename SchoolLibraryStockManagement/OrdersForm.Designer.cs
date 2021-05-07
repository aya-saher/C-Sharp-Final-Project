namespace SchoolLibraryStockManagement
{
    partial class OrdersForm
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
            this.dGVOrderItems = new System.Windows.Forms.DataGridView();
            this.tBSearch = new System.Windows.Forms.TextBox();
            this.btnSerach = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dGVOrders = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tB_referenceNum = new System.Windows.Forms.TextBox();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.btnEditOrderItem = new System.Windows.Forms.Button();
            this.tB_productCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tB_Quantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDeleteOrederItem = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.btn_clear_items = new System.Windows.Forms.Button();
            this.cB_search = new System.Windows.Forms.ComboBox();
            this.btn_editOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVOrderItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVOrderItems
            // 
            this.dGVOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVOrderItems.Location = new System.Drawing.Point(224, 251);
            this.dGVOrderItems.Name = "dGVOrderItems";
            this.dGVOrderItems.Size = new System.Drawing.Size(443, 185);
            this.dGVOrderItems.TabIndex = 1;
            this.dGVOrderItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVOrderItems_CellClick);
            // 
            // tBSearch
            // 
            this.tBSearch.Location = new System.Drawing.Point(419, 16);
            this.tBSearch.MaxLength = 7;
            this.tBSearch.Name = "tBSearch";
            this.tBSearch.Size = new System.Drawing.Size(100, 20);
            this.tBSearch.TabIndex = 2;
            // 
            // btnSerach
            // 
            this.btnSerach.Location = new System.Drawing.Point(525, 14);
            this.btnSerach.Name = "btnSerach";
            this.btnSerach.Size = new System.Drawing.Size(75, 23);
            this.btnSerach.TabIndex = 3;
            this.btnSerach.Text = "Search";
            this.btnSerach.UseVisualStyleBackColor = true;
            this.btnSerach.Click += new System.EventHandler(this.btnSerach_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // dGVOrders
            // 
            this.dGVOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVOrders.Location = new System.Drawing.Point(226, 46);
            this.dGVOrders.Name = "dGVOrders";
            this.dGVOrders.Size = new System.Drawing.Size(543, 186);
            this.dGVOrders.TabIndex = 22;
            this.dGVOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVOrders_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Reference Number";
            // 
            // tB_referenceNum
            // 
            this.tB_referenceNum.Location = new System.Drawing.Point(115, 82);
            this.tB_referenceNum.MaxLength = 6;
            this.tB_referenceNum.Name = "tB_referenceNum";
            this.tB_referenceNum.Size = new System.Drawing.Size(100, 20);
            this.tB_referenceNum.TabIndex = 24;
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Enabled = false;
            this.btnDeleteOrder.Location = new System.Drawing.Point(15, 145);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(200, 23);
            this.btnDeleteOrder.TabIndex = 25;
            this.btnDeleteOrder.Text = "Delete";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // btnEditOrderItem
            // 
            this.btnEditOrderItem.Enabled = false;
            this.btnEditOrderItem.Location = new System.Drawing.Point(15, 329);
            this.btnEditOrderItem.Name = "btnEditOrderItem";
            this.btnEditOrderItem.Size = new System.Drawing.Size(175, 23);
            this.btnEditOrderItem.TabIndex = 28;
            this.btnEditOrderItem.Text = "Edit";
            this.btnEditOrderItem.UseVisualStyleBackColor = true;
            this.btnEditOrderItem.Click += new System.EventHandler(this.btnEditOrderItem_Click);
            // 
            // tB_productCode
            // 
            this.tB_productCode.Enabled = false;
            this.tB_productCode.Location = new System.Drawing.Point(90, 270);
            this.tB_productCode.Name = "tB_productCode";
            this.tB_productCode.ReadOnly = true;
            this.tB_productCode.Size = new System.Drawing.Size(100, 20);
            this.tB_productCode.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Product Code";
            // 
            // tB_Quantity
            // 
            this.tB_Quantity.Location = new System.Drawing.Point(90, 296);
            this.tB_Quantity.MaxLength = 6;
            this.tB_Quantity.Name = "tB_Quantity";
            this.tB_Quantity.Size = new System.Drawing.Size(100, 20);
            this.tB_Quantity.TabIndex = 30;
            this.tB_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB_Quantity_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Quantity";
            // 
            // btnDeleteOrederItem
            // 
            this.btnDeleteOrederItem.Enabled = false;
            this.btnDeleteOrederItem.Location = new System.Drawing.Point(15, 358);
            this.btnDeleteOrederItem.Name = "btnDeleteOrederItem";
            this.btnDeleteOrederItem.Size = new System.Drawing.Size(175, 23);
            this.btnDeleteOrederItem.TabIndex = 31;
            this.btnDeleteOrederItem.Text = "Delete";
            this.btnDeleteOrederItem.UseVisualStyleBackColor = true;
            this.btnDeleteOrederItem.Click += new System.EventHandler(this.btnDeleteOrederItem_Click);
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(15, 175);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(200, 23);
            this.bClear.TabIndex = 39;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // btn_clear_items
            // 
            this.btn_clear_items.Location = new System.Drawing.Point(15, 387);
            this.btn_clear_items.Name = "btn_clear_items";
            this.btn_clear_items.Size = new System.Drawing.Size(175, 23);
            this.btn_clear_items.TabIndex = 40;
            this.btn_clear_items.Text = "Clear";
            this.btn_clear_items.UseVisualStyleBackColor = true;
            this.btn_clear_items.Click += new System.EventHandler(this.btn_clear_items_Click);
            // 
            // cB_search
            // 
            this.cB_search.FormattingEnabled = true;
            this.cB_search.Location = new System.Drawing.Point(285, 16);
            this.cB_search.Name = "cB_search";
            this.cB_search.Size = new System.Drawing.Size(128, 21);
            this.cB_search.TabIndex = 43;
            // 
            // btn_editOrder
            // 
            this.btn_editOrder.Enabled = false;
            this.btn_editOrder.Location = new System.Drawing.Point(15, 116);
            this.btn_editOrder.Name = "btn_editOrder";
            this.btn_editOrder.Size = new System.Drawing.Size(200, 23);
            this.btn_editOrder.TabIndex = 44;
            this.btn_editOrder.Text = "Edit";
            this.btn_editOrder.UseVisualStyleBackColor = true;
            this.btn_editOrder.Click += new System.EventHandler(this.btn_editOrder_Click);
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 453);
            this.Controls.Add(this.btn_editOrder);
            this.Controls.Add(this.cB_search);
            this.Controls.Add(this.btn_clear_items);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.btnDeleteOrederItem);
            this.Controls.Add(this.tB_Quantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEditOrderItem);
            this.Controls.Add(this.tB_productCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.tB_referenceNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dGVOrders);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSerach);
            this.Controls.Add(this.tBSearch);
            this.Controls.Add(this.dGVOrderItems);
            this.Name = "OrdersForm";
            this.Text = "OrdersForm";
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVOrderItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dGVOrderItems;
        private System.Windows.Forms.TextBox tBSearch;
        private System.Windows.Forms.Button btnSerach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGVOrders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tB_referenceNum;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Button btnEditOrderItem;
        private System.Windows.Forms.TextBox tB_productCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tB_Quantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeleteOrederItem;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button btn_clear_items;
        private System.Windows.Forms.ComboBox cB_search;
        private System.Windows.Forms.Button btn_editOrder;
    }
}