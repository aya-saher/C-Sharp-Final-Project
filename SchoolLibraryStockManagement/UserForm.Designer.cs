namespace SchoolLibraryStockManagement
{
    partial class UserForm
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
            this.lbl_username = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_role = new System.Windows.Forms.TextBox();
            this.lbl_role = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edir = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_activation = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.cmb_columns = new System.Windows.Forms.ComboBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.dgv_products = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(32, 74);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(55, 13);
            this.lbl_username.TabIndex = 1;
            this.lbl_username.Text = "Username";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(85, 71);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(100, 20);
            this.txt_username.TabIndex = 2;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(85, 106);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 4;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(32, 109);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 3;
            this.lbl_name.Text = "Name";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(85, 141);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(100, 20);
            this.txt_password.TabIndex = 6;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(32, 144);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(53, 13);
            this.lbl_password.TabIndex = 5;
            this.lbl_password.Text = "Password";
            // 
            // txt_role
            // 
            this.txt_role.Location = new System.Drawing.Point(85, 177);
            this.txt_role.Name = "txt_role";
            this.txt_role.Size = new System.Drawing.Size(100, 20);
            this.txt_role.TabIndex = 8;
            // 
            // lbl_role
            // 
            this.lbl_role.AutoSize = true;
            this.lbl_role.Location = new System.Drawing.Point(32, 180);
            this.lbl_role.Name = "lbl_role";
            this.lbl_role.Size = new System.Drawing.Size(29, 13);
            this.lbl_role.TabIndex = 7;
            this.lbl_role.Text = "Role";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(219, 69);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_edir
            // 
            this.btn_edir.Location = new System.Drawing.Point(219, 104);
            this.btn_edir.Name = "btn_edir";
            this.btn_edir.Size = new System.Drawing.Size(75, 23);
            this.btn_edir.TabIndex = 10;
            this.btn_edir.Text = "Edit";
            this.btn_edir.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(219, 139);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 11;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_activation
            // 
            this.btn_activation.Location = new System.Drawing.Point(219, 175);
            this.btn_activation.Name = "btn_activation";
            this.btn_activation.Size = new System.Drawing.Size(75, 23);
            this.btn_activation.TabIndex = 12;
            this.btn_activation.Text = "Activation";
            this.btn_activation.UseVisualStyleBackColor = true;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(619, 33);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(91, 23);
            this.btn_search.TabIndex = 34;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // cmb_columns
            // 
            this.cmb_columns.FormattingEnabled = true;
            this.cmb_columns.Location = new System.Drawing.Point(346, 36);
            this.cmb_columns.Name = "cmb_columns";
            this.cmb_columns.Size = new System.Drawing.Size(105, 21);
            this.cmb_columns.TabIndex = 33;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(457, 35);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(156, 20);
            this.txt_search.TabIndex = 32;
            // 
            // dgv_products
            // 
            this.dgv_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_products.Location = new System.Drawing.Point(346, 62);
            this.dgv_products.Name = "dgv_products";
            this.dgv_products.Size = new System.Drawing.Size(364, 147);
            this.dgv_products.TabIndex = 31;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 248);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.cmb_columns);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.dgv_products);
            this.Controls.Add(this.btn_activation);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edir);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_role);
            this.Controls.Add(this.lbl_role);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.lbl_username);
            this.Name = "User";
            this.Text = "User";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_role;
        private System.Windows.Forms.Label lbl_role;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edir;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_activation;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ComboBox cmb_columns;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.DataGridView dgv_products;
    }
}