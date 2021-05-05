namespace SchoolLibraryStockManagement
{
    partial class ReportForm
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
            this.lbl_top_selling = new System.Windows.Forms.Label();
            this.lbl_out_of_stock = new System.Windows.Forms.Label();
            this.lbl_product_movement = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_top_selling
            // 
            this.lbl_top_selling.AutoSize = true;
            this.lbl_top_selling.Location = new System.Drawing.Point(321, 126);
            this.lbl_top_selling.Name = "lbl_top_selling";
            this.lbl_top_selling.Size = new System.Drawing.Size(60, 13);
            this.lbl_top_selling.TabIndex = 12;
            this.lbl_top_selling.Text = "Top Selling";
            this.lbl_top_selling.Click += new System.EventHandler(this.lbl_top_selling_Click);
            // 
            // lbl_out_of_stock
            // 
            this.lbl_out_of_stock.AutoSize = true;
            this.lbl_out_of_stock.Location = new System.Drawing.Point(186, 126);
            this.lbl_out_of_stock.Name = "lbl_out_of_stock";
            this.lbl_out_of_stock.Size = new System.Drawing.Size(67, 13);
            this.lbl_out_of_stock.TabIndex = 11;
            this.lbl_out_of_stock.Text = "Out of Stock";
            this.lbl_out_of_stock.Click += new System.EventHandler(this.lbl_out_of_stock_Click);
            // 
            // lbl_product_movement
            // 
            this.lbl_product_movement.AutoSize = true;
            this.lbl_product_movement.Location = new System.Drawing.Point(37, 126);
            this.lbl_product_movement.Name = "lbl_product_movement";
            this.lbl_product_movement.Size = new System.Drawing.Size(97, 13);
            this.lbl_product_movement.TabIndex = 10;
            this.lbl_product_movement.Text = "Product Movement";
            this.lbl_product_movement.Click += new System.EventHandler(this.lbl_product_movement_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(307, 73);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(172, 73);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(34, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 230);
            this.Controls.Add(this.lbl_top_selling);
            this.Controls.Add(this.lbl_out_of_stock);
            this.Controls.Add(this.lbl_product_movement);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ReportForm";
            this.Text = "Report";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_top_selling;
        private System.Windows.Forms.Label lbl_out_of_stock;
        private System.Windows.Forms.Label lbl_product_movement;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}