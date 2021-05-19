namespace SchoolLibraryStockManagement
{
    partial class StockManagementForm
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
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.txt_product = new System.Windows.Forms.TextBox();
            this.lbl_product = new System.Windows.Forms.Label();
            this.dgv_products = new System.Windows.Forms.DataGridView();
            this.dgv_stock = new System.Windows.Forms.DataGridView();
            this.btn_remove = new System.Windows.Forms.Button();
            this.txt_quantity = new System.Windows.Forms.NumericUpDown();
            this.btn_insert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(210, 50);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 37;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(210, 15);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 36;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Location = new System.Drawing.Point(23, 55);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(46, 13);
            this.lbl_quantity.TabIndex = 31;
            this.lbl_quantity.Text = "Quantity";
            // 
            // txt_product
            // 
            this.txt_product.Location = new System.Drawing.Point(83, 17);
            this.txt_product.Name = "txt_product";
            this.txt_product.ReadOnly = true;
            this.txt_product.Size = new System.Drawing.Size(100, 20);
            this.txt_product.TabIndex = 30;
            // 
            // lbl_product
            // 
            this.lbl_product.AutoSize = true;
            this.lbl_product.Location = new System.Drawing.Point(23, 20);
            this.lbl_product.Name = "lbl_product";
            this.lbl_product.Size = new System.Drawing.Size(44, 13);
            this.lbl_product.TabIndex = 29;
            this.lbl_product.Text = "Product";
            // 
            // dgv_products
            // 
            this.dgv_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_products.Location = new System.Drawing.Point(345, 12);
            this.dgv_products.Name = "dgv_products";
            this.dgv_products.Size = new System.Drawing.Size(417, 147);
            this.dgv_products.TabIndex = 28;
            this.dgv_products.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_products_CellMouseDoubleClick);
            // 
            // dgv_stock
            // 
            this.dgv_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_stock.Location = new System.Drawing.Point(345, 208);
            this.dgv_stock.Name = "dgv_stock";
            this.dgv_stock.Size = new System.Drawing.Size(417, 147);
            this.dgv_stock.TabIndex = 39;
            this.dgv_stock.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_stock_CellMouseDoubleClick);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(210, 86);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(75, 23);
            this.btn_remove.TabIndex = 40;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(83, 53);
            this.txt_quantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(100, 20);
            this.txt_quantity.TabIndex = 41;
            this.txt_quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(26, 123);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(259, 23);
            this.btn_insert.TabIndex = 42;
            this.btn_insert.Text = "Inset All";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // StockManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 367);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.dgv_stock);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbl_quantity);
            this.Controls.Add(this.txt_product);
            this.Controls.Add(this.lbl_product);
            this.Controls.Add(this.dgv_products);
            this.Name = "StockManagementForm";
            this.Text = "StockManagement";
            this.Load += new System.EventHandler(this.StockManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.TextBox txt_product;
        private System.Windows.Forms.Label lbl_product;
        private System.Windows.Forms.DataGridView dgv_products;
        private System.Windows.Forms.DataGridView dgv_stock;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.NumericUpDown txt_quantity;
        private System.Windows.Forms.Button btn_insert;
    }
}