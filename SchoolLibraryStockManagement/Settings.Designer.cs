namespace SchoolLibraryStockManagement
{
    partial class Settings
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
            this.btn_settings_update = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_settings_update
            // 
            this.btn_settings_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.btn_settings_update.FlatAppearance.BorderSize = 0;
            this.btn_settings_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings_update.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_settings_update.ForeColor = System.Drawing.Color.White;
            this.btn_settings_update.Location = new System.Drawing.Point(84, 213);
            this.btn_settings_update.Name = "btn_settings_update";
            this.btn_settings_update.Size = new System.Drawing.Size(90, 23);
            this.btn_settings_update.TabIndex = 8;
            this.btn_settings_update.Text = "Update";
            this.btn_settings_update.UseVisualStyleBackColor = false;
            this.btn_settings_update.Click += new System.EventHandler(this.btn_settings_update_Click);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(12, 81);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(162, 20);
            this.txt_name.TabIndex = 7;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(9, 65);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 6;
            this.lbl_name.Text = "Name";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(12, 128);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(162, 20);
            this.txt_username.TabIndex = 10;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(9, 112);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(55, 13);
            this.lbl_username.TabIndex = 9;
            this.lbl_username.Text = "Username";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(12, 174);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(162, 20);
            this.txt_password.TabIndex = 12;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(9, 158);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(53, 13);
            this.lbl_password.TabIndex = 11;
            this.lbl_password.Text = "Password";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 261);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.btn_settings_update);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_name);
            this.Name = "Settings";
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_settings_update;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_password;
    }
}