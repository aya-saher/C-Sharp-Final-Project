namespace SchoolLibraryStockManagement
{
    partial class StockManagement
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
            this.btn_edir = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbl_description = new System.Windows.Forms.Label();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.txt_product = new System.Windows.Forms.TextBox();
            this.lbl_product = new System.Windows.Forms.Label();
            this.dgv_products = new System.Windows.Forms.DataGridView();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_edir
            // 
            this.btn_edir.Location = new System.Drawing.Point(210, 50);
            this.btn_edir.Name = "btn_edir";
            this.btn_edir.Size = new System.Drawing.Size(75, 23);
            this.btn_edir.TabIndex = 37;
            this.btn_edir.Text = "Edit";
            this.btn_edir.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(210, 15);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 36;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Location = new System.Drawing.Point(23, 90);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(31, 13);
            this.lbl_description.TabIndex = 33;
            this.lbl_description.Text = "Type";
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(83, 52);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(100, 20);
            this.txt_quantity.TabIndex = 32;
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
            this.dgv_products.Location = new System.Drawing.Point(12, 141);
            this.dgv_products.Name = "dgv_products";
            this.dgv_products.Size = new System.Drawing.Size(321, 147);
            this.dgv_products.TabIndex = 28;
            // 
            // cmb_type
            // 
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Location = new System.Drawing.Point(83, 87);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(100, 21);
            this.cmb_type.TabIndex = 38;
            // 
            // StockManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 321);
            this.Controls.Add(this.cmb_type);
            this.Controls.Add(this.btn_edir);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.lbl_quantity);
            this.Controls.Add(this.txt_product);
            this.Controls.Add(this.lbl_product);
            this.Controls.Add(this.dgv_products);
            this.Name = "StockManagement";
            this.Text = "StockManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_edir;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.TextBox txt_product;
        private System.Windows.Forms.Label lbl_product;
        private System.Windows.Forms.DataGridView dgv_products;
        private System.Windows.Forms.ComboBox cmb_type;
    }
}