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
            this.btn_password_update = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_password_update
            // 
            this.btn_password_update.Location = new System.Drawing.Point(63, 119);
            this.btn_password_update.Name = "btn_password_update";
            this.btn_password_update.Size = new System.Drawing.Size(90, 23);
            this.btn_password_update.TabIndex = 8;
            this.btn_password_update.Text = "Update";
            this.btn_password_update.UseVisualStyleBackColor = true;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(12, 81);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(141, 20);
            this.txt_password.TabIndex = 7;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(9, 65);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(53, 13);
            this.lbl_password.TabIndex = 6;
            this.lbl_password.Text = "Password";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 261);
            this.Controls.Add(this.btn_password_update);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.lbl_password);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_password_update;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_password;
    }
}