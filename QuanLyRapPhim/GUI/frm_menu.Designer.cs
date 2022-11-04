namespace QuanLyRapPhim.GUI
{
    partial class frm_menu
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
            this.btn_seller = new System.Windows.Forms.Button();
            this.btn_manager = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_seller
            // 
            this.btn_seller.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_seller.Location = new System.Drawing.Point(63, 27);
            this.btn_seller.Name = "btn_seller";
            this.btn_seller.Size = new System.Drawing.Size(203, 74);
            this.btn_seller.TabIndex = 0;
            this.btn_seller.Text = "Bán vé";
            this.btn_seller.UseVisualStyleBackColor = true;
            this.btn_seller.Click += new System.EventHandler(this.btn_seller_Click);
            // 
            // btn_manager
            // 
            this.btn_manager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_manager.Location = new System.Drawing.Point(63, 130);
            this.btn_manager.Name = "btn_manager";
            this.btn_manager.Size = new System.Drawing.Size(203, 74);
            this.btn_manager.TabIndex = 1;
            this.btn_manager.Text = "Quản lý";
            this.btn_manager.UseVisualStyleBackColor = true;
            this.btn_manager.Click += new System.EventHandler(this.btn_manager_Click);
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 236);
            this.Controls.Add(this.btn_manager);
            this.Controls.Add(this.btn_seller);
            this.Name = "frm_menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_seller;
        private System.Windows.Forms.Button btn_manager;
    }
}