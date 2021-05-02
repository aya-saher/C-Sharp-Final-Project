namespace SchoolLibraryStockManagement
{
    partial class Product
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
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edir = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbl_category = new System.Windows.Forms.Label();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.lbl_description = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.lbl_code = new System.Windows.Forms.Label();
            this.dgv_products = new System.Windows.Forms.DataGridView();
            this.cmb_categories = new System.Windows.Forms.ComboBox();
            this.btn_stock_management = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.cmb_columns = new System.Windows.Forms.ComboBox();
            this.btn_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(211, 135);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(91, 23);
            this.btn_delete.TabIndex = 24;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_edir
            // 
            this.btn_edir.Location = new System.Drawing.Point(211, 100);
            this.btn_edir.Name = "btn_edir";
            this.btn_edir.Size = new System.Drawing.Size(91, 23);
            this.btn_edir.TabIndex = 23;
            this.btn_edir.Text = "Edit";
            this.btn_edir.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(211, 65);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(91, 23);
            this.btn_add.TabIndex = 22;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Location = new System.Drawing.Point(24, 176);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(49, 13);
            this.lbl_category.TabIndex = 20;
            this.lbl_category.Text = "Category";
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(84, 137);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(100, 20);
            this.txt_description.TabIndex = 19;
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Location = new System.Drawing.Point(24, 140);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(60, 13);
            this.lbl_description.TabIndex = 18;
            this.lbl_description.Text = "Description";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(84, 102);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 17;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(24, 105);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 16;
            this.lbl_name.Text = "Name";
            // 
            // txt_code
            // 
            this.txt_code.Location = new System.Drawing.Point(84, 67);
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(100, 20);
            this.txt_code.TabIndex = 15;
            // 
            // lbl_code
            // 
            this.lbl_code.AutoSize = true;
            this.lbl_code.Location = new System.Drawing.Point(24, 70);
            this.lbl_code.Name = "lbl_code";
            this.lbl_code.Size = new System.Drawing.Size(32, 13);
            this.lbl_code.TabIndex = 14;
            this.lbl_code.Text = "Code";
            // 
            // dgv_products
            // 
            this.dgv_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_products.Location = new System.Drawing.Point(344, 58);
            this.dgv_products.Name = "dgv_products";
            this.dgv_products.Size = new System.Drawing.Size(364, 147);
            this.dgv_products.TabIndex = 13;
            // 
            // cmb_categories
            // 
            this.cmb_categories.FormattingEnabled = true;
            this.cmb_categories.Location = new System.Drawing.Point(84, 171);
            this.cmb_categories.Name = "cmb_categories";
            this.cmb_categories.Size = new System.Drawing.Size(100, 21);
            this.cmb_categories.TabIndex = 26;
            // 
            // btn_stock_management
            // 
            this.btn_stock_management.Location = new System.Drawing.Point(211, 169);
            this.btn_stock_management.Name = "btn_stock_management";
            this.btn_stock_management.Size = new System.Drawing.Size(91, 23);
            this.btn_stock_management.TabIndex = 27;
            this.btn_stock_management.Text = "Stock Manag.";
            this.btn_stock_management.UseVisualStyleBackColor = true;
            this.btn_stock_management.Click += new System.EventHandler(this.btn_stock_management_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(455, 31);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(156, 20);
            this.txt_search.TabIndex = 28;
            // 
            // cmb_columns
            // 
            this.cmb_columns.FormattingEnabled = true;
            this.cmb_columns.Location = new System.Drawing.Point(344, 32);
            this.cmb_columns.Name = "cmb_columns";
            this.cmb_columns.Size = new System.Drawing.Size(105, 21);
            this.cmb_columns.TabIndex = 29;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(617, 29);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(91, 23);
            this.btn_search.TabIndex = 30;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 236);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.cmb_columns);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_stock_management);
            this.Controls.Add(this.cmb_categories);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edir);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txt_code);
            this.Controls.Add(this.lbl_code);
            this.Controls.Add(this.dgv_products);
            this.Name = "Product";
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edir;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.Label lbl_code;
        private System.Windows.Forms.DataGridView dgv_products;
        private System.Windows.Forms.ComboBox cmb_categories;
        private System.Windows.Forms.Button btn_stock_management;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.ComboBox cmb_columns;
        private System.Windows.Forms.Button btn_search;
    }
}