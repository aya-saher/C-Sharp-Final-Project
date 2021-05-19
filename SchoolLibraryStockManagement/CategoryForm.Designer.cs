namespace SchoolLibraryStockManagement
{
    partial class CategoryForm
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
            this.txt_description = new System.Windows.Forms.TextBox();
            this.lbl_description = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.cmb_columns = new System.Windows.Forms.ComboBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.dgv_products = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(284, 182);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(100, 28);
            this.btn_delete.TabIndex = 24;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_edir
            // 
            this.btn_edir.Location = new System.Drawing.Point(284, 139);
            this.btn_edir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_edir.Name = "btn_edir";
            this.btn_edir.Size = new System.Drawing.Size(100, 28);
            this.btn_edir.TabIndex = 23;
            this.btn_edir.Text = "Edit";
            this.btn_edir.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(284, 96);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 28);
            this.btn_add.TabIndex = 22;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(111, 143);
            this.txt_description.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(132, 22);
            this.txt_description.TabIndex = 17;
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Location = new System.Drawing.Point(35, 145);
            this.lbl_description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(79, 17);
            this.lbl_description.TabIndex = 16;
            this.lbl_description.Text = "Description";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(111, 100);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(132, 22);
            this.txt_name.TabIndex = 15;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(35, 102);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(45, 17);
            this.lbl_name.TabIndex = 14;
            this.lbl_name.Text = "Name";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(792, 36);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(121, 28);
            this.btn_search.TabIndex = 34;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // cmb_columns
            // 
            this.cmb_columns.FormattingEnabled = true;
            this.cmb_columns.Location = new System.Drawing.Point(428, 37);
            this.cmb_columns.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_columns.Name = "cmb_columns";
            this.cmb_columns.Size = new System.Drawing.Size(139, 24);
            this.cmb_columns.TabIndex = 33;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(576, 38);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(207, 22);
            this.txt_search.TabIndex = 32;
            // 
            // dgv_products
            // 
            this.dgv_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_products.Location = new System.Drawing.Point(428, 71);
            this.dgv_products.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_products.Name = "dgv_products";
            this.dgv_products.RowHeadersWidth = 51;
            this.dgv_products.Size = new System.Drawing.Size(485, 181);
            this.dgv_products.TabIndex = 31;
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 288);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.cmb_columns);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.dgv_products);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edir);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_name);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CategoryForm";
            this.Text = "Category";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edir;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ComboBox cmb_columns;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.DataGridView dgv_products;

    }
}